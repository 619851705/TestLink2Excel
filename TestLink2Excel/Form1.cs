using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TestLink2Excel.Commons;
using TestLink2Excel.Dialogs;
using TestLink2Excel.Model;
using TestLink2Excel.Utils;

namespace TestLink2Excel
{
    /// <summary>
    /// Main app window.
    /// </summary>
    public partial class MainForm : Form
    {
        #region Constructors
        public MainForm()
        {
            InitializeComponent();
            testSuiteTreeView.SuiteNodeClickedEvent += new TreeViewEventHandler(TestSuiteTreeViewSuiteNodeClickedEvent);
            testSuiteTreeView.CaseNodeClickedEvent += new TreeViewEventHandler(TestSuiteTreeViewCaseNodeClickedEvent);
        }

        #endregion

        #region Event Handlers
        /// <summary>
        /// Open file dialog and load selected xml file into treeview.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenToolStripMenuItemClick(object sender, EventArgs e)
        {

            DialogResult result = openFileDialog.ShowDialog();
			if (result == DialogResult.OK) // Test result.
			{
			    XMLSuite a = new XMLSuite(openFileDialog.FileName);
			    List<TestSuite> suites = a.makeTestSuite();
			    foreach (TestSuite suite in suites)
			    {
					testSuiteTreeView.GenerateTreeNode(suite);
			    }
			
			}
        }

        /// <summary>
        /// Opens AboutBox dialog.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }

        private void NewToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (testSuiteTreeView.Count == 0) return;
            DialogResult result = MessageBox.Show(Messages.AreYouSure,WindowsNames.Confirmation,MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                testSuiteTreeView.Clear();
                testSuiteDetailsForm.Hide();
                testCaseDetailsForm.Hide();
            }
        }

        /// <summary>
        /// Opens save file dialog, generate excel file and save them with given filename.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExcelSheetToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (testSuiteTreeView.Count > 0)
            {
                DialogResult result = xlsxSaveFileDialog.ShowDialog();
                if (result == DialogResult.OK) // Test result.
                {
                    testSuiteTreeView.GenerateExcelFile(xlsxSaveFileDialog.FileName);
                }
            }
        }

		private void TestLinkXlsToolStripMenuItemClick(object sender, EventArgs e)
		{
            if (testSuiteTreeView.Count > 0)
            {
                DialogResult result = xmlSaveFileDialog.ShowDialog();
                if (result == DialogResult.OK) // Test result.
                {
                    testSuiteTreeView.GenerateXmlFile(xmlSaveFileDialog.FileName);
                }
            }
		}
        private void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void TestSuiteTreeViewCaseNodeClickedEvent(object sender, TreeViewEventArgs e)
        {
            if (testSuiteDetailsForm.Visible == true)
            {
                testSuiteDetailsForm.Visible = false;
            }
            testCaseDetailsForm.displayCase(sender as TestCase);
        }

        void TestSuiteTreeViewSuiteNodeClickedEvent(object sender, TreeViewEventArgs e)
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
