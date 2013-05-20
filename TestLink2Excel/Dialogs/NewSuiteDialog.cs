using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TestLink2Excel.Model;

namespace TestLink2Excel.Dialogs
{
	public partial class NewSuiteDialog : Form
	{
		public TestSuite TestSuite { get;internal set; }

		public NewSuiteDialog()
		{
			InitializeComponent();
			this.TestSuite = new TestSuite("", "");
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			this.TestSuite.Name = this.txtTestSuiteName.Text;
			this.TestSuite.Description = this.txtTestSuiteSummary.Text;
		}
	}
}
