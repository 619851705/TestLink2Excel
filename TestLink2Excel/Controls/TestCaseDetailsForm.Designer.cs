namespace TestLink2Excel.Controls
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.testCaseNameLabel = new System.Windows.Forms.Label();
            this.testCaseNameText = new System.Windows.Forms.TextBox();
            this.textCasePreconditionsLabel = new System.Windows.Forms.Label();
            this.testCaseSummaryText = new System.Windows.Forms.TextBox();
            this.testCasePreconditionsText = new System.Windows.Forms.TextBox();
            this.textCaseSummaryLabel = new System.Windows.Forms.Label();
            this.stepsGroupBox = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.actionGroupBox = new System.Windows.Forms.GroupBox();
            this.actionsPanel = new System.Windows.Forms.Panel();
            this.expectionGroupBox = new System.Windows.Forms.GroupBox();
            this.expectionsPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.stepsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.actionGroupBox.SuspendLayout();
            this.expectionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.testCaseNameLabel);
            this.panel1.Controls.Add(this.testCaseNameText);
            this.panel1.Controls.Add(this.textCasePreconditionsLabel);
            this.panel1.Controls.Add(this.testCaseSummaryText);
            this.panel1.Controls.Add(this.testCasePreconditionsText);
            this.panel1.Controls.Add(this.textCaseSummaryLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 189);
            this.panel1.TabIndex = 8;
            // 
            // testCaseNameLabel
            // 
            this.testCaseNameLabel.AutoSize = true;
            this.testCaseNameLabel.Location = new System.Drawing.Point(39, 9);
            this.testCaseNameLabel.Name = "testCaseNameLabel";
            this.testCaseNameLabel.Size = new System.Drawing.Size(35, 13);
            this.testCaseNameLabel.TabIndex = 1;
            this.testCaseNameLabel.Text = "Name";
            // 
            // testCaseNameText
            // 
            this.testCaseNameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.testCaseNameText.Location = new System.Drawing.Point(86, 6);
            this.testCaseNameText.Name = "testCaseNameText";
            this.testCaseNameText.Size = new System.Drawing.Size(511, 20);
            this.testCaseNameText.TabIndex = 0;
            // 
            // textCasePreconditionsLabel
            // 
            this.textCasePreconditionsLabel.AutoSize = true;
            this.textCasePreconditionsLabel.Location = new System.Drawing.Point(3, 110);
            this.textCasePreconditionsLabel.Name = "textCasePreconditionsLabel";
            this.textCasePreconditionsLabel.Size = new System.Drawing.Size(71, 13);
            this.textCasePreconditionsLabel.TabIndex = 5;
            this.textCasePreconditionsLabel.Text = "Preconditions";
            // 
            // testCaseSummaryText
            // 
            this.testCaseSummaryText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.testCaseSummaryText.Location = new System.Drawing.Point(86, 32);
            this.testCaseSummaryText.Multiline = true;
            this.testCaseSummaryText.Name = "testCaseSummaryText";
            this.testCaseSummaryText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.testCaseSummaryText.Size = new System.Drawing.Size(511, 69);
            this.testCaseSummaryText.TabIndex = 2;
            // 
            // testCasePreconditionsText
            // 
            this.testCasePreconditionsText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.testCasePreconditionsText.Location = new System.Drawing.Point(86, 107);
            this.testCasePreconditionsText.Multiline = true;
            this.testCasePreconditionsText.Name = "testCasePreconditionsText";
            this.testCasePreconditionsText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.testCasePreconditionsText.Size = new System.Drawing.Size(511, 69);
            this.testCasePreconditionsText.TabIndex = 4;
            // 
            // textCaseSummaryLabel
            // 
            this.textCaseSummaryLabel.AutoSize = true;
            this.textCaseSummaryLabel.Location = new System.Drawing.Point(24, 35);
            this.textCaseSummaryLabel.Name = "textCaseSummaryLabel";
            this.textCaseSummaryLabel.Size = new System.Drawing.Size(50, 13);
            this.textCaseSummaryLabel.TabIndex = 3;
            this.textCaseSummaryLabel.Text = "Summary";
            // 
            // stepsGroupBox
            // 
            this.stepsGroupBox.Controls.Add(this.splitContainer1);
            this.stepsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stepsGroupBox.Location = new System.Drawing.Point(0, 189);
            this.stepsGroupBox.Name = "stepsGroupBox";
            this.stepsGroupBox.Size = new System.Drawing.Size(609, 252);
            this.stepsGroupBox.TabIndex = 9;
            this.stepsGroupBox.TabStop = false;
            this.stepsGroupBox.Text = "Steps: ";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 16);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.actionGroupBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.expectionGroupBox);
            this.splitContainer1.Size = new System.Drawing.Size(603, 233);
            this.splitContainer1.SplitterDistance = 298;
            this.splitContainer1.TabIndex = 0;
            // 
            // actionGroupBox
            // 
            this.actionGroupBox.Controls.Add(this.actionsPanel);
            this.actionGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionGroupBox.Location = new System.Drawing.Point(0, 0);
            this.actionGroupBox.Name = "actionGroupBox";
            this.actionGroupBox.Size = new System.Drawing.Size(298, 233);
            this.actionGroupBox.TabIndex = 0;
            this.actionGroupBox.TabStop = false;
            this.actionGroupBox.Text = "Action:";
            // 
            // actionsPanel
            // 
            this.actionsPanel.AutoScroll = true;
            this.actionsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionsPanel.Location = new System.Drawing.Point(3, 16);
            this.actionsPanel.Name = "actionsPanel";
            this.actionsPanel.Size = new System.Drawing.Size(292, 214);
            this.actionsPanel.TabIndex = 0;
            // 
            // expectionGroupBox
            // 
            this.expectionGroupBox.Controls.Add(this.expectionsPanel);
            this.expectionGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expectionGroupBox.Location = new System.Drawing.Point(0, 0);
            this.expectionGroupBox.Name = "expectionGroupBox";
            this.expectionGroupBox.Size = new System.Drawing.Size(301, 233);
            this.expectionGroupBox.TabIndex = 1;
            this.expectionGroupBox.TabStop = false;
            this.expectionGroupBox.Text = "Expections:";
            // 
            // expectionsPanel
            // 
            this.expectionsPanel.AutoScroll = true;
            this.expectionsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expectionsPanel.Location = new System.Drawing.Point(3, 16);
            this.expectionsPanel.Name = "expectionsPanel";
            this.expectionsPanel.Size = new System.Drawing.Size(295, 214);
            this.expectionsPanel.TabIndex = 0;
            // 
            // TestCaseDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.stepsGroupBox);
            this.Controls.Add(this.panel1);
            this.Name = "TestCaseDetailsForm";
            this.Size = new System.Drawing.Size(609, 441);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.stepsGroupBox.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.actionGroupBox.ResumeLayout(false);
            this.expectionGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label testCaseNameLabel;
        private System.Windows.Forms.TextBox testCaseNameText;
        private System.Windows.Forms.Label textCasePreconditionsLabel;
        private System.Windows.Forms.TextBox testCaseSummaryText;
        private System.Windows.Forms.TextBox testCasePreconditionsText;
        private System.Windows.Forms.Label textCaseSummaryLabel;
        private System.Windows.Forms.GroupBox stepsGroupBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox actionGroupBox;
        private System.Windows.Forms.Panel actionsPanel;
        private System.Windows.Forms.GroupBox expectionGroupBox;
        private System.Windows.Forms.Panel expectionsPanel;
    }
}
