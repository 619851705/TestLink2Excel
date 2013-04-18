using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TestLink2Excel.Model;
using TestLink2Excel.Utils;

namespace TestLink2Excel
{
    public partial class MainForm : Form
    {

        #region Constructors
        public MainForm()
        {
            InitializeComponent();
            testSuiteTreeView.suiteNodeClickedEvent += new TreeViewEventHandler(testSuiteTreeView_suiteNodeClickedEvent);
            testSuiteTreeView.caseNodeClickedEvent += new TreeViewEventHandler(testSuiteTreeView_caseNodeClickedEvent);
        }

        #endregion
        #region menuEventHandlers
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "XML suite file (*.xml)|*.xml|All files (*.*)|*.*";
			DialogResult result = dialog.ShowDialog();
			if (result == DialogResult.OK) // Test result.
			{
			    XMLSuite a = new XMLSuite(dialog.FileName);
			    List<TestSuite> suites = a.makeTestSuite();
			    foreach (TestSuite suite in suites)
			    {
					testSuiteTreeView.generateTreeNode(suite);
			    }
			
			}
        }

		private void excelSheetToolStripMenuItem_Click(object sender, EventArgs e)
		{
            //List<TestSuite> suites = new List<TestSuite>();
            //foreach (TreeNode node in suiteTreeView.Nodes)
            //{
            //    TestSuite suite = node.Tag as TestSuite;
            //    suites.Add(suite);
            //}
            //if (suites.Count > 0)
            //{
            //    SaveFileDialog dialog = new SaveFileDialog();
            //    dialog.Filter = "Microsoft Excel Worksheet (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            //    DialogResult result = dialog.ShowDialog();
            //    if (result == DialogResult.OK) // Test result.
            //    {
            //        ExcelWriter file = new ExcelWriter(dialog.FileName);
            //        foreach (TestSuite suite in suites)
            //        {
            //            file.generateSuiteSheet(suite);
            //        }
            //        file.Save();
            //        file.Close();
            //    }
            //}
		}

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //todo 
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //suiteTreeView.Nodes.Add(makeSuiteTree(new TestSuite("<<New Test Suite>>",string.Empty)));
        }
		private void newNodeToolStripButton_Click(object sender, EventArgs e)
		{
			//    TreeNode node = newNodeToolStripButton.Tag as TreeNode;
			//    node.Nodes.Add(makeSuiteTree(new TestSuite("<<New Test Suite>>", string.Empty)));
		}

		private void newTestCaseToolStripButton_Click(object sender, EventArgs e)
		{
			//TreeNode node = newNodeToolStripButton.Tag as TreeNode;
			//TreeNode tcNode = new TreeNode();
			//tcNode.Text = "<<new Test Case>>";
			//tcNode.Tag = new TestCase("<<new Test Case>>");
			//node.Nodes.Add(tcNode);
			//tcNode.BeginEdit();
            //
		}

		private void testLinkXlsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//TestSuite suite = suiteTreeView.SelectedNode.Tag as TestSuite;
			//if (suite != null)
			//{
			//    SaveFileDialog dialog = new SaveFileDialog();
			//    dialog.Filter = "XML File (*.xml)|*.xml|All files (*.*)|*.*";
			//    DialogResult result = dialog.ShowDialog();
			//    if (result == DialogResult.OK) // Test result.
			//    {
			//        XMLSuite x = new XMLSuite(suite);
			//        x.saveAs(dialog.FileName);
			//    }
			//}
		}
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void testSuiteTreeView_caseNodeClickedEvent(object sender, TreeViewEventArgs e)
        {
            if (testSuiteDetailsForm.Visible == true)
            {
                testSuiteDetailsForm.Visible = false;
            }
            testCaseDetailsForm.displayCase(sender as TestCase);
        }

        void testSuiteTreeView_suiteNodeClickedEvent(object sender, TreeViewEventArgs e)
        {
            if (testCaseDetailsForm.Visible == true)
            {
                testCaseDetailsForm.Visible = false;
            }
            testSuiteDetailsForm.displaySuite(sender as TestSuite);
        }
		#endregion
	}
}
