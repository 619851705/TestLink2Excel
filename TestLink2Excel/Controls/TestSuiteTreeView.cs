using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using TestLink2Excel.Dialogs;
using TestLink2Excel.Model;
using TestLink2Excel.Utils;

namespace TestLink2Excel.Controls
{
	public partial class TestSuiteTreeView : UserControl
	{
		private TreeNode copiedNode;

		#region Constructors

		public TestSuiteTreeView()
		{
			InitializeComponent();
		}

		#endregion

		#region Properties

		public event TreeViewEventHandler SuiteNodeClickedEvent;
		public event TreeViewEventHandler CaseNodeClickedEvent;
		public int Count { get { return this.suiteTreeView.Nodes.Count; } }

		#endregion

		#region Public methodes

		/// <summary>
		/// Generating tree node based on TestSuite object.
		/// </summary>
		/// <param name="suite"></param>
		public void GenerateTreeNode(TestSuite suite)
		{
			this.suiteTreeView.BeginUpdate();
			this.suiteTreeView.Nodes.Add(this.MakeSuiteTree(suite));
			this.suiteTreeView.EndUpdate();
		}

		/// <summary>
		/// Show Dialog to select suites and make xlsx file with them.
		/// </summary>
		/// <param name="fileName"></param>
		public void GenerateExcelFile(string fileName)
		{
			SuiteExportChoseForm exportDialog = new SuiteExportChoseForm(this.suiteTreeView.Nodes);
			exportDialog.ShowDialog();

			if (exportDialog.Result == DialogResult.OK)
			{
				List<TestSuite> suites = this.MakeSuiteList(exportDialog.Nodes);
				ExcelWriter file = new ExcelWriter(fileName);

				foreach (TestSuite suite in suites)
					file.GenerateSuiteSheet(suite);

				file.Save();
				file.Close();
			}
		}

		/// <summary>
		/// Show Dialog to select suites and make xml file with them.
		/// </summary>
		/// <param name="fileName"></param>
		public void GenerateXmlFile(string fileName)
		{
			SuiteExportChoseForm exportDialog = new SuiteExportChoseForm(suiteTreeView.Nodes);

			if (exportDialog.ShowDialog() == DialogResult.OK)
			{
				List<TestSuite> suites = this.MakeSuiteList(exportDialog.Nodes);
				XMLSuite xml = new XMLSuite();

				foreach (TestSuite suite in suites)
					xml.AddSuite(suite);

				xml.SaveAs(fileName);
			}
		}

		/// <summary>
		/// Clear tree view Nodes.
		/// </summary>
		public void Clear()
		{
			this.suiteTreeView.Nodes.Clear();
		}

		#endregion

		#region Private methodes

		/// <summary>
		/// Update given suite node Text to equals with suite Name.
		/// </summary>
		/// <param name="suite"></param>
		/// <param name="nodes"></param>
		private void UpdateTreeViewSuiteNames(TestSuite suite, TreeNodeCollection nodes)
		{
			foreach (TreeNode node in nodes)
			{
				TestSuite suiteTag = node.Tag as TestSuite;

				if (suiteTag != null && suiteTag.Equals(suite))
				{
					this.suiteTreeView.BeginUpdate();
					node.Text = node.Text = (node.Tag as TestSuite).Name;
					this.suiteTreeView.EndUpdate();
				}
				else if (node.Nodes.Count > 0)
				{
					this.UpdateTreeViewSuiteNames(suite, node.Nodes);
				}
			}
		}

		/// <summary>
		/// Update given test case node Text to equals with test case Name.
		/// </summary>
		/// <param name="tc"></param>
		/// <param name="nodes"></param>
		private void UpdateTreeViewCaseNames(TestCase tc, TreeNodeCollection nodes)
		{
			foreach (TreeNode node in nodes)
			{
				TestCase tcTag = node.Tag as TestCase;

				if (tcTag != null && tcTag.Equals(tc))
				{
					this.suiteTreeView.BeginUpdate();
					node.Text = node.Text = tc.Name;
					this.suiteTreeView.EndUpdate();
				}
				else if (node.Nodes.Count > 0)
				{
					this.UpdateTreeViewCaseNames(tc, node.Nodes);
				}
			}
		}

		private void AddTestCaseToSuit(TreeNode node, TestCase testCase)
		{
			if (node != null)
			{
				TestSuite suite = node.Tag as TestSuite;

				if (suite != null)
				{
					suite.Tcs.Add(testCase);

					testCase.PropertyChanged += new PropertyChangedEventHandler(TestCase_PropertyChanged);

					TreeNode tcNode = new TreeNode();

					tcNode.Text = testCase.Name;
					tcNode.Tag = testCase;
					tcNode.ImageIndex = 1;
					tcNode.SelectedImageIndex = 0;
					node.Nodes.Add(tcNode);
				}
			}
		}

		/// <summary>
		/// Make TreeNode from given suite and place suite ref into node Tag.
		/// </summary>
		/// <param name="suite"></param>
		/// <returns></returns>
		private TreeNode MakeSuiteTree(TestSuite suite)
		{
			TreeNode node = new TreeNode();
			node.Text = suite.Name;
			node.Tag = suite;
			suite.PropertyChanged += new PropertyChangedEventHandler(Suite_PropertyChanged);

			foreach (TestSuite s in suite.UnderSuits)
			{
				node.Nodes.Add(MakeSuiteTree(s));
			}

			foreach (TestCase testCase in suite.Tcs)
			{
				testCase.PropertyChanged += new PropertyChangedEventHandler(TestCase_PropertyChanged);
				TreeNode tcNode = new TreeNode();
				tcNode.Text = testCase.Name;
				tcNode.Tag = testCase;
				tcNode.ImageIndex = 1;
				tcNode.SelectedImageIndex = 0;
				node.Nodes.Add(tcNode);
			}

			return node;
		}

		private List<TestSuite> MakeSuiteList(TreeNodeCollection nodes)
		{
			List<TestSuite> suites = new List<TestSuite>();

			foreach (TreeNode node in nodes)
			{
				if (node.Checked == true && node.Nodes.Count > 0)
				{
					TestSuite suite = MakeSuite(node);
					suites.Add(suite);
				}
			}

			return suites;
		}

		private TestSuite MakeSuite(TreeNode node)
		{
			TestSuite suite = new TestSuite((node.Tag as TestSuite).Name, (node.Tag as TestSuite).Description);

			foreach (TreeNode n in node.Nodes)
			{
				if (n.Nodes.Count > 0 && n.Checked == true)
					suite.UnderSuits.Add(MakeSuite(n));
				else if (n.Checked == true && (n.Tag as TestCase) != null)
					suite.Tcs.Add(n.Tag as TestCase);
			}

			return suite;
		}

		/// <summary>
		/// Disable all tool strip buttons exluded paste.
		/// </summary>
		private void DisableToolStripButtons()
		{
			foreach (ToolStripItem item in toolStrip.Items)
			{
				ToolStripButton button = item as ToolStripButton;

				if (button != null && !button.Equals(this.pasteToolStripButton))
					button.Enabled = false;
			}
		}

		/// <summary>
		/// Enable tool strip buttons with active action for given node.
		/// </summary>
		/// <param name="treeNode"></param>
		private void EnableToolStripButtons(TreeNode treeNode)
		{
			this.DisableToolStripButtons();

			if (treeNode.Index > 0)
				this.moveUpToolStripButton.Enabled = true;

			if (treeNode.Parent != null && (treeNode.Index < treeNode.Parent.Nodes.Count - 1))
				this.moveDownToolStripButton.Enabled = true;

			this.newNodeToolStripButton.Enabled = true;
			this.newTestCaseToolStripButton.Enabled = true;
			this.copyToolStripButton.Enabled = true;
			this.deleteToolStripButton.Enabled = true;
		}

		private void SuiteNodeClicked(object sender, TreeViewEventArgs e)
		{
			if (this.SuiteNodeClickedEvent != null)
				this.SuiteNodeClickedEvent(sender, e);
		}

		private void CaseNodeClicked(object sender, TreeViewEventArgs e)
		{
			if (this.CaseNodeClickedEvent != null)
				this.CaseNodeClickedEvent(sender, e);
		}

		#endregion

		#region Events handlers

		private void Suite_PropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			TestSuite suite = sender as TestSuite;
			this.UpdateTreeViewSuiteNames(suite, this.suiteTreeView.Nodes);
		}

		private void TestCase_PropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			TestCase tc = sender as TestCase;
			this.UpdateTreeViewCaseNames(tc, this.suiteTreeView.Nodes);
		}

		private void SuiteTreeView_AfterSelect(object sender, TreeViewEventArgs e)
		{
			TestSuite suite = e.Node.Tag as TestSuite;
			TestCase testCase = e.Node.Tag as TestCase;

			if (suite != null)
				this.SuiteNodeClicked(suite, e);
			else if (testCase != null)
				this.CaseNodeClickedEvent(testCase, e);

			this.EnableToolStripButtons(e.Node);
		}

		/// <summary>
		/// to musze poukładać
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SuiteTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			if (e.Button == System.Windows.Forms.MouseButtons.Right)
			{
				e.Node.TreeView.SelectedNode = e.Node;
				this.treeContextMenuStrip.Show(Cursor.Position);
			}
		}

		private void newNodeToolStripButton_Click(object sender, System.EventArgs e)
		{
			NewSuiteDialog newSuiteDialog = new NewSuiteDialog();

			if (newSuiteDialog.ShowDialog() == DialogResult.OK)
			{
				TreeNode suiteNode = this.MakeSuiteTree(newSuiteDialog.TestSuite);

				if (this.suiteTreeView.SelectedNode != null)
				{
					if (this.suiteTreeView.SelectedNode.Tag is TestSuite)
						this.suiteTreeView.SelectedNode.Nodes.Add(suiteNode);
					else if (this.suiteTreeView.SelectedNode.Parent != null)
						this.suiteTreeView.SelectedNode.Parent.Nodes.Add(suiteNode);
					else
						this.suiteTreeView.Nodes.Add(suiteNode);
				}
				else
					this.suiteTreeView.Nodes.Add(suiteNode);
			}
		}

		private void newTestCaseToolStripButton_Click(object sender, System.EventArgs e)
		{
			if (this.suiteTreeView.SelectedNode != null)
			{
				NewCaseDialog dialog = new NewCaseDialog();
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					if (this.suiteTreeView.SelectedNode.Tag is TestSuite)
						this.AddTestCaseToSuit(this.suiteTreeView.SelectedNode, dialog.TestCase);
					else if (this.suiteTreeView.SelectedNode.Parent != null)
						this.AddTestCaseToSuit(this.suiteTreeView.SelectedNode.Parent, dialog.TestCase);
				}
			}
		}

		private void moveUpToolStripButton_Click(object sender, System.EventArgs e)
		{
			if (this.suiteTreeView.SelectedNode.PrevNode != null)
				this.suiteTreeView.SelectedNode = this.suiteTreeView.SelectedNode.PrevNode;
		}

		private void moveDownToolStripButton_Click(object sender, System.EventArgs e)
		{
			if (this.suiteTreeView.SelectedNode.NextNode != null)
				this.suiteTreeView.SelectedNode = this.suiteTreeView.SelectedNode.NextNode;
		}

		private void deleteToolStripButton_Click(object sender, System.EventArgs e)
		{
			if (this.suiteTreeView.SelectedNode != null)
				this.suiteTreeView.SelectedNode.Remove();
		}

		#endregion

		private void pasteToolStripButton_Click(object sender, System.EventArgs e)
		{
			if (copiedNode != null)
			{
				if (this.suiteTreeView.SelectedNode != null)
				{
					if (this.suiteTreeView.SelectedNode.Tag is TestSuite)
						this.suiteTreeView.SelectedNode.Nodes.Add(copiedNode);
					else if (this.suiteTreeView.SelectedNode.Parent != null)
						this.suiteTreeView.SelectedNode.Parent.Nodes.Add(copiedNode);
					else
						this.suiteTreeView.Nodes.Add(copiedNode);
				}
				else
					this.suiteTreeView.Nodes.Add(copiedNode);
			}
		}

		private void copyToolStripButton_Click(object sender, System.EventArgs e)
		{
			this.copiedNode = (TreeNode)this.suiteTreeView.SelectedNode.Clone();

			this.pasteToolStripButton.Enabled = this.pasteToolStripMenuItem.Enabled = this.copiedNode != null;
		}
	}
}
