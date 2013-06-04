using System;
using System.Windows.Forms;
using TestLink2Excel.Model;

namespace TestLink2Excel.Controls
{
	public partial class TestSuiteDetailsForm : UserControl
	{
		#region Constructors

		public TestSuiteDetailsForm()
		{
			InitializeComponent();
		}

		#endregion

		/// <summary>
		/// Show given suite on suite form and make form visible.
		/// </summary>
		/// <param name="suite"></param>
		public void DisplaySuite(TestSuite suite)
		{
			this.Tag = suite;
			this.txtTestSuiteName.Text = suite.Name;
			this.txtTestSuiteSummary.Text = suite.Description;
			this.Visible = true;
		}

		private void TestSuiteSaveButton_Click(object sender, EventArgs e)
		{
			TestSuite suite = this.Tag as TestSuite;

			suite.Name = this.txtTestSuiteName.Text;
			suite.Description = this.txtTestSuiteSummary.Text;
		}

		private void TestSuiteCancelButton_Click(object sender, EventArgs e)
		{
			this.DisplaySuite(this.Tag as TestSuite);
		}

		private void txtTestSuiteSummary_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Control && e.KeyCode == Keys.A)
				(sender as TextBox).SelectAll();
		}
	}
}
