using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TestLink2Excel.Model;

namespace TestLink2Excel
{
    public partial class TestCaseDetailsForm : UserControl
    {
        #region Constructors
        public TestCaseDetailsForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Public Methodes
        
        /// <summary>
        /// Show given test case in test case form and make it visible.
        /// </summary>
        /// <param name="tc"></param>
        public void displayCase(TestCase tc)
        {
            this.Tag = tc;
            loadTestCaseForm(tc);
            this.Visible = true;
        }
        #endregion

        #region Private methodes
        
        /// <summary>
        /// Fill test case form with given TestCase object data.
        /// </summary>
        /// <param name="testCase"></param>
        private void loadTestCaseForm(TestCase testCase)
        {
            int x = 10, y = 15;
            testCaseNameText.Text = testCase.Name;
            testCaseSummaryText.Text = testCase.Summary;
            testCasePreconditionsText.Text = testCase.Preconditions;
            actionsPanel.Controls.Clear();
            expectionsPanel.Controls.Clear();
            int textBoxWeight = actionsPanel.Size.Width - x - 30 - 10;
            foreach (Step step in testCase.Steps)
            {
                addStep(step, textBoxWeight, x, y);
                y += 80;
            }
        }

        /// <summary>
        /// Add new controls for action and expected result Then fill them with Step data.
        /// </summary>
        /// <param name="step"></param>
        /// <param name="boxWeight"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        private void addStep(Step step, int boxWeight, int x, int y)
        {
            actionsPanel.Controls.Add(createStepNumberLabel(step.StepNumber,x,y));
            Control actions = createCaseTextBox(step.Action, boxWeight, x, y);
            actions.Tag = step;
            actionsPanel.Controls.Add(actions);
            expectionsPanel.Controls.Add(createStepNumberLabel(step.StepNumber, x, y));
            Control expectations = createCaseTextBox(step.ExpectedResult, boxWeight, x, y);
            expectations.Tag = step;
            expectionsPanel.Controls.Add(expectations);
        }


        /// <summary>
        /// Create Text box fill them with stepText and return.
        /// </summary>
        /// <param name="stepText"></param>
        /// <param name="boxWeight"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private Control createCaseTextBox(string stepText, int boxWeight, int x, int y)
        {
            TextBox text = new TextBox();
            text.Location = new System.Drawing.Point(x + 30, y);
            text.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            text.Multiline = true;
            text.Size = new System.Drawing.Size(boxWeight, 69);
            text.Text = stepText;
            text.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            return text;
        }

        /// <summary>
        /// Create label with given step number and return them.
        /// </summary>
        /// <param name="stepNumber"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private Control createStepNumberLabel(int stepNumber, int x, int y)
        {
            Label t = new Label();
            t.Text = stepNumber.ToString() + ": ";
            t.TextAlign = ContentAlignment.MiddleRight;
            t.Location = new System.Drawing.Point(x, y + 2);
            t.Size = new System.Drawing.Size(25, 18);
            t.TabIndex = stepNumber;
            return t;
        }
        #endregion

        #region Event handlers

        private void cancelButton_Click(object sender, EventArgs e)
        {
            displayCase(this.Tag as TestCase);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            TestCase tc = this.Tag as TestCase;
            tc.Name = testCaseNameText.Text;
            tc.Summary = testCaseSummaryText.Text;
            tc.Preconditions = testCasePreconditionsText.Text;
            foreach (Control box in actionsPanel.Controls)
            {
                Step step = box.Tag as Step;
                if(step != null)
                {
                    step.Action = box.Text;
                }
            }
            foreach (Control box in expectionsPanel.Controls)
            {
                Step step = box.Tag as Step;
                if (step != null)
                {
                    step.ExpectedResult = box.Text;
                }
            }
        }

        #endregion
    }
}
