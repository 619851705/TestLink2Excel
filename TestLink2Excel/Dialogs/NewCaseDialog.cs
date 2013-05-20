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
	public partial class NewCaseDialog : Form
	{
		public TestCase TestCase
		{
			get
			{
				return this.testCaseDetailsForm1.Tag as TestCase;
			}
		}

		public NewCaseDialog()
		{
			InitializeComponent();
			this.testCaseDetailsForm1.DisplayCase(new TestCase(""));
		}
	}
}
