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

			this.testSuiteTreeView.SuiteNodeClickedEvent += new TreeViewEventHandler(TestSuiteTreeViewSuiteNodeClickedEvent);
			this.testSuiteTreeView.CaseNodeClickedEvent += new TreeViewEventHandler(TestSuiteTreeViewCaseNodeClickedEvent);
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
				XMLSuite a = new XMLSuite(this.openFileDialog.FileName);
				List<TestSuite> suites = a.MakeTestSuite();

				foreach (TestSuite suite in suites)
				{
					this.testSuiteTreeView.GenerateTreeNode(suite);
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
			if (this.testSuiteTreeView.Count == 0)
				return;

			DialogResult result = MessageBox.Show(Messages.AreYouSure, WindowsNames.Confirmation, MessageBoxButtons.OKCancel);

			if (result == DialogResult.OK)
			{
				this.testSuiteTreeView.Clear();
				this.testSuiteDetailsForm.Hide();
				this.testCaseDetailsForm.Hide();
			}
		}

		/// <summary>
		/// Opens save file dialog, generate excel file and save them with given filename.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ExcelSheetToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (this.testSuiteTreeView.Count > 0)
			{
				DialogResult result = this.xlsxSaveFileDialog.ShowDialog();

				if (result == DialogResult.OK) // Test result.
					this.testSuiteTreeView.GenerateExcelFile(this.xlsxSaveFileDialog.FileName);
			}
		}

		private void TestLinkXlsToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (this.testSuiteTreeView.Count > 0)
			{
				DialogResult result = this.xmlSaveFileDialog.ShowDialog();

				if (result == DialogResult.OK) // Test result.
					this.testSuiteTreeView.GenerateXmlFile(this.xmlSaveFileDialog.FileName);
			}
		}

		private void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}

		void TestSuiteTreeViewCaseNodeClickedEvent(object sender, TreeViewEventArgs e)
		{
			if (this.testSuiteDetailsForm.Visible == true)
				this.testSuiteDetailsForm.Visible = false;

			this.testCaseDetailsForm.DisplayCase(sender as TestCase);
		}

		void TestSuiteTreeViewSuiteNodeClickedEvent(object sender, TreeViewEventArgs e)
		{
			if (this.testCaseDetailsForm.Visible == true)
				this.testCaseDetailsForm.Visible = false;

			this.testSuiteDetailsForm.DisplaySuite(sender as TestSuite);
		}

		#endregion
	}
}
