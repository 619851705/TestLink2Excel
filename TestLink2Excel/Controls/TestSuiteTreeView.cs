using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using TestLink2Excel.Model;
using TestLink2Excel.Utils;
using TestLink2Excel.Dialogs;

namespace TestLink2Excel.Controls
{
    public partial class TestSuiteTreeView : UserControl
	{

        #region Constructors
		public TestSuiteTreeView()
        {
            InitializeComponent();
            
        }
		#endregion

        #region Properties
        public event TreeViewEventHandler SuiteNodeClickedEvent;
        public event TreeViewEventHandler CaseNodeClickedEvent;
        public int Count { get { return suiteTreeView.Nodes.Count; } }
        #endregion

        #region Public methodes

        /// <summary>
		/// Generating tree node based on TestSuite object.
		/// </summary>
		/// <param name="suite"></param>
		public void GenerateTreeNode(TestSuite suite)
		{
            suiteTreeView.BeginUpdate();
            suiteTreeView.Nodes.Add(MakeSuiteTree(suite));
            suiteTreeView.EndUpdate();
		}

        /// <summary>
        /// Show Dialog to select suites and make xlsx file with them.
        /// </summary>
        /// <param name="fileName"></param>
        public void GenerateExcelFile(string fileName)
        {
            SuiteExportChoseForm exportDialog = new SuiteExportChoseForm(suiteTreeView.Nodes);
            exportDialog.ShowDialog();
            if (exportDialog.Result == DialogResult.OK)
            {

                List<TestSuite> suites = makeSuiteList(exportDialog.Nodes);
                ExcelWriter file = new ExcelWriter(fileName);
                foreach (TestSuite suite in suites)
                {
                    file.generateSuiteSheet(suite);
                } 
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
            exportDialog.ShowDialog();
            if (exportDialog.Result == DialogResult.OK)
            {
                List<TestSuite> suites = makeSuiteList(exportDialog.Nodes);
                XMLSuite xml = new XMLSuite();
                foreach (TestSuite suite in suites)
                {
                    xml.AddSuite(suite);
                }
                xml.saveAs(fileName);
            }
        }

        /// <summary>
        /// Clear tree view Nodes.
        /// </summary>
        public void Clear()
        {
            suiteTreeView.Nodes.Clear();
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
                    suiteTreeView.BeginUpdate();
                    node.Text = node.Text = (node.Tag as TestSuite).Name;
                    suiteTreeView.EndUpdate();
                }
                else if (node.Nodes.Count > 0)
                {
                    UpdateTreeViewSuiteNames(suite, node.Nodes);
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
                    suiteTreeView.BeginUpdate();
                    node.Text = node.Text = tc.Name;
                    suiteTreeView.EndUpdate();
                }
                else if (node.Nodes.Count > 0)
                {
                    UpdateTreeViewCaseNames(tc, node.Nodes);
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
            suite.PropertyChanged += new PropertyChangedEventHandler(suite_PropertyChanged);
			foreach (TestSuite s in suite.UnderSuits)
			{
				node.Nodes.Add(MakeSuiteTree(s));
			}

			foreach (TestCase testCase in suite.Tcs)
			{
                testCase.PropertyChanged += new PropertyChangedEventHandler(testCase_PropertyChanged);
                TreeNode tcNode = new TreeNode();
				tcNode.Text = testCase.Name;
				tcNode.Tag = testCase;
				tcNode.ImageIndex = 1;
				tcNode.SelectedImageIndex = 0;
				node.Nodes.Add(tcNode);
			}
			return node;
        }

        private List<TestSuite> makeSuiteList(TreeNodeCollection nodes)
        {
            List<TestSuite> suites = new List<TestSuite>();
            foreach (TreeNode node in nodes)
            {
                if(node.Checked == true && node.Nodes.Count > 0)
                {
                    TestSuite suite = makeSuite(node);
                    suites.Add(suite);
                }
            }
            return suites;
        }

        private TestSuite makeSuite(TreeNode node)
        {
            TestSuite suite = new TestSuite((node.Tag as TestSuite).Name, (node.Tag as TestSuite).Description);
            foreach (TreeNode n in node.Nodes)
            {
                if (n.Nodes.Count > 0 && n.Checked == true)
                {
                    suite.UnderSuits.Add(makeSuite(n));
                }
                else if (n.Checked == true && (n.Tag as TestCase) != null)
                {
                    suite.Tcs.Add(n.Tag as TestCase);
                }
            }
            return suite;
        }



        /// <summary>
        /// Disable all tool strip buttons exluded paste.
        /// </summary>
        private void disableToolStripButtons()
        {
            foreach (ToolStripItem item in toolStrip.Items)
            {
                ToolStripButton button = item as ToolStripButton;
                if (button != null && !button.Equals(pasteToolStripButton)) button.Enabled = false;
            }
        }
        /// <summary>
        /// Enable tool strip buttons with active action for given node.
        /// </summary>
        /// <param name="treeNode"></param>
        private void enableToolStripButtons(TreeNode treeNode)
        {
            disableToolStripButtons();
            if (treeNode.Index > 0) moveUpToolStripButton.Enabled = true;
            if (treeNode.Parent != null && (treeNode.Index < treeNode.Parent.Nodes.Count - 1)) moveDownToolStripButton.Enabled = true;
            newNodeToolStripButton.Enabled = true;
            newTestCaseToolStripButton.Enabled = true;
            copyToolStripButton.Enabled = true;
            deleteToolStripButton.Enabled = true;
        }

        private void suiteNodeClicked(object sender, TreeViewEventArgs e)
        {
            if (this.SuiteNodeClickedEvent != null)
            {
                this.SuiteNodeClickedEvent(sender, e);
            }
        }

        private void caseNodeClicked(object sender, TreeViewEventArgs e)
        {
            if (this.CaseNodeClickedEvent != null)
            {
                this.CaseNodeClickedEvent(sender, e);
            }
        }
        #endregion

        #region Events handlers
        private void suite_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            TestSuite suite = sender as TestSuite;
            UpdateTreeViewSuiteNames(suite, suiteTreeView.Nodes);
        }

        private void testCase_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            TestCase tc = sender as TestCase;
            UpdateTreeViewCaseNames(tc, suiteTreeView.Nodes);
        }

        private void suiteTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TestSuite suite = e.Node.Tag as TestSuite;
            TestCase testCase = e.Node.Tag as TestCase;
            if (suite != null)
            {
                suiteNodeClicked(suite, e);
            }
            else if (testCase != null)
            {
                this.CaseNodeClickedEvent(testCase, e);
            }
            enableToolStripButtons(e.Node);
        }


        /// <summary>
        /// to musze poukładać
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void suiteTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                e.Node.TreeView.SelectedNode = e.Node;
                treeContextMenuStrip.Show(Cursor.Position);
            }
        }


        private void newNodeToolStripButton_Click(object sender, System.EventArgs e)
        {

        }

        private void newCaseToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        private void moveUpToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        private void moveDownToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        private void copyToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        private void pasteToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }
        #endregion
    }
}
