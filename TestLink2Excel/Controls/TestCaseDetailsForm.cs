using System;
using System.Drawing;
using System.Windows.Forms;
using TestLink2Excel.Model;
using System.ComponentModel;
using TestLink2Excel.Dialogs;

namespace TestLink2Excel
{
	public partial class TestCaseDetailsForm : UserControl
	{
		[Category("Appearance")]
		public bool ShowExtraButtons
		{
			get
			{
				return this.pnlExtraButtons.Visible;
			}
			set
			{
				this.pnlExtraButtons.Visible = value;
			}
		}

		#region Constructors

		public TestCaseDetailsForm()
		{
			InitializeComponent();
		}

		public TestCaseDetailsForm(bool showExtraButtons)
		{
			InitializeComponent();
			this.pnlExtraButtons.Visible = showExtraButtons;
		}

		#endregion

		#region Public Methodes

		/// <summary>
		/// Show given test case in test case form and make it visible.
		/// </summary>
		/// <param name="tc"></param>
		public void DisplayCase(TestCase tc)
		{
			this.Tag = tc;
			this.LoadTestCaseForm(tc);
			this.Visible = true;
		}

		#endregion

		#region Private methodes

		/// <summary>
		/// Fill test case form with given TestCase object data.
		/// </summary>
		/// <param name="testCase"></param>
		private void LoadTestCaseForm(TestCase testCase)
		{
			int x = 10, y = 15;

			this.txtTestCaseName.Text = testCase.Name;
			this.txtTestCaseSummary.Text = testCase.Summary;
			this.txtTestCasePreconditions.Text = testCase.Preconditions;
			this.pnlActions.Controls.Clear();
			this.pnlExpections.Controls.Clear();

			int textBoxWeight = this.pnlActions.Size.Width - x - 30 - 10;

			foreach (Step step in testCase.Steps)
			{
				this.AddStep(step, textBoxWeight, x, y);
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
		private void AddStep(Step step, int boxWeight, int x, int y)
		{
			this.pnlActions.Controls.Add(this.CreateStepNumberLabel(step.StepNumber, x, y));
			Control actions = this.CreateCaseTextBox(step.Action, boxWeight, x, y);
			actions.Tag = step;
			this.pnlActions.Controls.Add(actions);
			this.pnlExpections.Controls.Add(this.CreateStepNumberLabel(step.StepNumber, x, y));
			Control expectations = this.CreateCaseTextBox(step.ExpectedResult, boxWeight, x, y);
			expectations.Tag = step;
			this.pnlExpections.Controls.Add(expectations);
		}

		/// <summary>
		/// Create Text box fill them with stepText and return.
		/// </summary>
		/// <param name="stepText"></param>
		/// <param name="boxWeight"></param>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		private Control CreateCaseTextBox(string stepText, int boxWeight, int x, int y)
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
		private Control CreateStepNumberLabel(int stepNumber, int x, int y)
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

		private void CancelButton_Click(object sender, EventArgs e)
		{
			this.DisplayCase(this.Tag as TestCase);
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			TestCase tc = this.Tag as TestCase;

			tc.Name = this.txtTestCaseName.Text;
			tc.Summary = this.txtTestCaseSummary.Text;
			tc.Preconditions = this.txtTestCasePreconditions.Text;

			foreach (Control box in this.pnlActions.Controls)
			{
				Step step = box.Tag as Step;

				if (step != null)
					step.Action = box.Text;
			}

			foreach (Control box in this.pnlExpections.Controls)
			{
				Step step = box.Tag as Step;

				if (step != null)
					step.ExpectedResult = box.Text;
			}
		}

		#endregion

		private void btnAddStep_Click(object sender, EventArgs e)
		{
			NewStepDialog dialog = new NewStepDialog();

			if (dialog.ShowDialog() == DialogResult.OK)
				(this.Tag as TestCase).Steps.Add(dialog.Step);

			this.LoadTestCaseForm(this.Tag as TestCase);
		}

		private void txtTestCaseName_TextChanged(object sender, EventArgs e)
		{
			if (this.ShowExtraButtons)
			{
				TestCase testCase = this.Tag as TestCase;

				testCase.Name = txtTestCaseName.Text;
			}
		}

		private void txtTestCaseSummary_TextChanged(object sender, EventArgs e)
		{
			if (this.ShowExtraButtons)
			{
				TestCase testCase = this.Tag as TestCase;

				testCase.Summary = txtTestCaseSummary.Text;
			}
		}

		private void txtTestCasePreconditions_TextChanged(object sender, EventArgs e)
		{
			if (this.ShowExtraButtons)
			{
				TestCase testCase = this.Tag as TestCase;

				testCase.Preconditions = txtTestCasePreconditions.Text;
			}
		}
	}
}
