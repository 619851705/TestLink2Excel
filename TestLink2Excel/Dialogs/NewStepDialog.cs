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
	public partial class NewStepDialog : Form
	{
		public Step Step { get; internal set; }

		public NewStepDialog()
		{
			InitializeComponent();
			Step = new Step();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			this.Step = new Step() { Action = txtAction.Text, ExpectedResult = txtExpectations.Text, StepNumber = (int)nudStepNumber.Value };
		}
	}
}
