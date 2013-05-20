namespace TestLink2Excel
{
    partial class TestCaseDetailsForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.pnlDetails = new System.Windows.Forms.Panel();
			this.lblTestCaseName = new System.Windows.Forms.Label();
			this.txtTestCaseName = new System.Windows.Forms.TextBox();
			this.lblTextCasePreconditions = new System.Windows.Forms.Label();
			this.txtTestCaseSummary = new System.Windows.Forms.TextBox();
			this.txtTestCasePreconditions = new System.Windows.Forms.TextBox();
			this.lblTextCaseSummary = new System.Windows.Forms.Label();
			this.grpbxSteps = new System.Windows.Forms.GroupBox();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.grpbxActionGroupBox = new System.Windows.Forms.GroupBox();
			this.pnlActions = new System.Windows.Forms.Panel();
			this.grpbxExpections = new System.Windows.Forms.GroupBox();
			this.pnlExpections = new System.Windows.Forms.Panel();
			this.pnlButtons = new System.Windows.Forms.Panel();
			this.pnlExtraButtons = new System.Windows.Forms.Panel();
			this.btnAddStep = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.pnlDetails.SuspendLayout();
			this.grpbxSteps.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.grpbxActionGroupBox.SuspendLayout();
			this.grpbxExpections.SuspendLayout();
			this.pnlButtons.SuspendLayout();
			this.pnlExtraButtons.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlDetails
			// 
			this.pnlDetails.Controls.Add(this.lblTestCaseName);
			this.pnlDetails.Controls.Add(this.txtTestCaseName);
			this.pnlDetails.Controls.Add(this.lblTextCasePreconditions);
			this.pnlDetails.Controls.Add(this.txtTestCaseSummary);
			this.pnlDetails.Controls.Add(this.txtTestCasePreconditions);
			this.pnlDetails.Controls.Add(this.lblTextCaseSummary);
			this.pnlDetails.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlDetails.Location = new System.Drawing.Point(0, 0);
			this.pnlDetails.Name = "pnlDetails";
			this.pnlDetails.Size = new System.Drawing.Size(609, 189);
			this.pnlDetails.TabIndex = 8;
			// 
			// lblTestCaseName
			// 
			this.lblTestCaseName.AutoSize = true;
			this.lblTestCaseName.Location = new System.Drawing.Point(39, 9);
			this.lblTestCaseName.Name = "lblTestCaseName";
			this.lblTestCaseName.Size = new System.Drawing.Size(35, 13);
			this.lblTestCaseName.TabIndex = 1;
			this.lblTestCaseName.Text = "Name";
			// 
			// txtTestCaseName
			// 
			this.txtTestCaseName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTestCaseName.Location = new System.Drawing.Point(86, 6);
			this.txtTestCaseName.Name = "txtTestCaseName";
			this.txtTestCaseName.Size = new System.Drawing.Size(511, 20);
			this.txtTestCaseName.TabIndex = 0;
			this.txtTestCaseName.TextChanged += new System.EventHandler(this.txtTestCaseName_TextChanged);
			// 
			// lblTextCasePreconditions
			// 
			this.lblTextCasePreconditions.AutoSize = true;
			this.lblTextCasePreconditions.Location = new System.Drawing.Point(3, 110);
			this.lblTextCasePreconditions.Name = "lblTextCasePreconditions";
			this.lblTextCasePreconditions.Size = new System.Drawing.Size(71, 13);
			this.lblTextCasePreconditions.TabIndex = 5;
			this.lblTextCasePreconditions.Text = "Preconditions";
			// 
			// txtTestCaseSummary
			// 
			this.txtTestCaseSummary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTestCaseSummary.Location = new System.Drawing.Point(86, 32);
			this.txtTestCaseSummary.Multiline = true;
			this.txtTestCaseSummary.Name = "txtTestCaseSummary";
			this.txtTestCaseSummary.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtTestCaseSummary.Size = new System.Drawing.Size(511, 69);
			this.txtTestCaseSummary.TabIndex = 2;
			this.txtTestCaseSummary.TextChanged += new System.EventHandler(this.txtTestCaseSummary_TextChanged);
			// 
			// txtTestCasePreconditions
			// 
			this.txtTestCasePreconditions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTestCasePreconditions.Location = new System.Drawing.Point(86, 107);
			this.txtTestCasePreconditions.Multiline = true;
			this.txtTestCasePreconditions.Name = "txtTestCasePreconditions";
			this.txtTestCasePreconditions.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtTestCasePreconditions.Size = new System.Drawing.Size(511, 69);
			this.txtTestCasePreconditions.TabIndex = 4;
			this.txtTestCasePreconditions.TextChanged += new System.EventHandler(this.txtTestCasePreconditions_TextChanged);
			// 
			// lblTextCaseSummary
			// 
			this.lblTextCaseSummary.AutoSize = true;
			this.lblTextCaseSummary.Location = new System.Drawing.Point(24, 35);
			this.lblTextCaseSummary.Name = "lblTextCaseSummary";
			this.lblTextCaseSummary.Size = new System.Drawing.Size(50, 13);
			this.lblTextCaseSummary.TabIndex = 3;
			this.lblTextCaseSummary.Text = "Summary";
			// 
			// grpbxSteps
			// 
			this.grpbxSteps.Controls.Add(this.splitContainer1);
			this.grpbxSteps.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grpbxSteps.Location = new System.Drawing.Point(0, 189);
			this.grpbxSteps.Name = "grpbxSteps";
			this.grpbxSteps.Size = new System.Drawing.Size(609, 211);
			this.grpbxSteps.TabIndex = 9;
			this.grpbxSteps.TabStop = false;
			this.grpbxSteps.Text = "Steps: ";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(3, 16);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.grpbxActionGroupBox);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.grpbxExpections);
			this.splitContainer1.Size = new System.Drawing.Size(603, 192);
			this.splitContainer1.SplitterDistance = 298;
			this.splitContainer1.TabIndex = 0;
			// 
			// grpbxActionGroupBox
			// 
			this.grpbxActionGroupBox.Controls.Add(this.pnlActions);
			this.grpbxActionGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grpbxActionGroupBox.Location = new System.Drawing.Point(0, 0);
			this.grpbxActionGroupBox.Name = "grpbxActionGroupBox";
			this.grpbxActionGroupBox.Size = new System.Drawing.Size(298, 192);
			this.grpbxActionGroupBox.TabIndex = 0;
			this.grpbxActionGroupBox.TabStop = false;
			this.grpbxActionGroupBox.Text = "Action:";
			// 
			// pnlActions
			// 
			this.pnlActions.AutoScroll = true;
			this.pnlActions.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlActions.Location = new System.Drawing.Point(3, 16);
			this.pnlActions.Name = "pnlActions";
			this.pnlActions.Size = new System.Drawing.Size(292, 173);
			this.pnlActions.TabIndex = 0;
			// 
			// grpbxExpections
			// 
			this.grpbxExpections.Controls.Add(this.pnlExpections);
			this.grpbxExpections.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grpbxExpections.Location = new System.Drawing.Point(0, 0);
			this.grpbxExpections.Name = "grpbxExpections";
			this.grpbxExpections.Size = new System.Drawing.Size(301, 192);
			this.grpbxExpections.TabIndex = 1;
			this.grpbxExpections.TabStop = false;
			this.grpbxExpections.Text = "Expections:";
			// 
			// pnlExpections
			// 
			this.pnlExpections.AutoScroll = true;
			this.pnlExpections.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlExpections.Location = new System.Drawing.Point(3, 16);
			this.pnlExpections.Name = "pnlExpections";
			this.pnlExpections.Size = new System.Drawing.Size(295, 173);
			this.pnlExpections.TabIndex = 0;
			// 
			// pnlButtons
			// 
			this.pnlButtons.Controls.Add(this.pnlExtraButtons);
			this.pnlButtons.Controls.Add(this.btnCancel);
			this.pnlButtons.Controls.Add(this.btnSave);
			this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlButtons.Location = new System.Drawing.Point(0, 400);
			this.pnlButtons.Name = "pnlButtons";
			this.pnlButtons.Size = new System.Drawing.Size(609, 41);
			this.pnlButtons.TabIndex = 9;
			// 
			// pnlExtraButtons
			// 
			this.pnlExtraButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlExtraButtons.Controls.Add(this.btnAddStep);
			this.pnlExtraButtons.Location = new System.Drawing.Point(6, 3);
			this.pnlExtraButtons.Name = "pnlExtraButtons";
			this.pnlExtraButtons.Size = new System.Drawing.Size(591, 32);
			this.pnlExtraButtons.TabIndex = 2;
			this.pnlExtraButtons.Visible = false;
			// 
			// btnAddStep
			// 
			this.btnAddStep.Location = new System.Drawing.Point(231, 6);
			this.btnAddStep.Name = "btnAddStep";
			this.btnAddStep.Size = new System.Drawing.Size(125, 23);
			this.btnAddStep.TabIndex = 0;
			this.btnAddStep.Text = "Add Step";
			this.btnAddStep.UseVisualStyleBackColor = true;
			this.btnAddStep.Click += new System.EventHandler(this.btnAddStep_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.Location = new System.Drawing.Point(495, 6);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.Location = new System.Drawing.Point(401, 6);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 0;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// TestCaseDetailsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.grpbxSteps);
			this.Controls.Add(this.pnlButtons);
			this.Controls.Add(this.pnlDetails);
			this.Name = "TestCaseDetailsForm";
			this.Size = new System.Drawing.Size(609, 441);
			this.pnlDetails.ResumeLayout(false);
			this.pnlDetails.PerformLayout();
			this.grpbxSteps.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.grpbxActionGroupBox.ResumeLayout(false);
			this.grpbxExpections.ResumeLayout(false);
			this.pnlButtons.ResumeLayout(false);
			this.pnlExtraButtons.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Label lblTestCaseName;
        private System.Windows.Forms.TextBox txtTestCaseName;
        private System.Windows.Forms.Label lblTextCasePreconditions;
        private System.Windows.Forms.TextBox txtTestCaseSummary;
        private System.Windows.Forms.TextBox txtTestCasePreconditions;
        private System.Windows.Forms.Label lblTextCaseSummary;
        private System.Windows.Forms.GroupBox grpbxSteps;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grpbxActionGroupBox;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.GroupBox grpbxExpections;
        private System.Windows.Forms.Panel pnlExpections;
		private System.Windows.Forms.Panel pnlButtons;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Panel pnlExtraButtons;
		private System.Windows.Forms.Button btnAddStep;
    }
}
