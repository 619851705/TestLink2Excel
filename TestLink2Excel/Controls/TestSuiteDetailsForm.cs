using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
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
        public void displaySuite(TestSuite suite)
        {
            this.Tag = suite;
            testSuiteNameText.Text = suite.Name;
            testSuiteSummaryText.Text = suite.Description;
            this.Visible = true;
        }

        private void testSuiteSaveButton_Click(object sender, EventArgs e)
        {
            TestSuite suite = this.Tag as TestSuite;
            suite.Name = testSuiteNameText.Text;
            suite.Description = testSuiteSummaryText.Text;
        }

        private void testSuiteCancelButton_Click(object sender, EventArgs e)
        {
            displaySuite(this.Tag as TestSuite);
        }
    }
}
