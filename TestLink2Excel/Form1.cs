using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TestLink2Excel.Dialogs;
using TestLink2Excel.Model;
using TestLink2Excel.Properties;
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

        #region Event Handlers
        private void OpenToolStripMenuItemClick(object sender, EventArgs e)
        {

            DialogResult result = openFileDialog.ShowDialog();
			if (result == DialogResult.OK) // Test result.
			{
			    XMLSuite a = new XMLSuite(openFileDialog.FileName);
			    List<TestSuite> suites = a.makeTestSuite();
			    foreach (TestSuite suite in suites)
			    {
					testSuiteTreeView.generateTreeNode(suite);
			    }
			
			}
        }

		private void ExcelSheetToolStripMenuItemClick(object sender, EventArgs e)
		{
            if (testSuiteTreeView.Count > 0)
            {
                DialogResult result = saveFileDialog.ShowDialog();
                if (result == DialogResult.OK) // Test result.
                {
                    testSuiteTreeView.generateExcelFile(saveFileDialog.FileName);
                }
            }
		}

        private void AboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
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
