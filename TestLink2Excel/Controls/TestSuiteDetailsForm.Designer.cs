namespace TestLink2Excel.Controls
{
    partial class TestSuiteDetailsForm
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
            this.testSuiteFormPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.testSuiteCancelButton = new System.Windows.Forms.Button();
            this.testSuiteSaveButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.testSuiteSummaryText = new System.Windows.Forms.TextBox();
            this.testSuiteSummaryLabel = new System.Windows.Forms.Label();
            this.testSuiteNameText = new System.Windows.Forms.TextBox();
            this.testSuiteNameLabel = new System.Windows.Forms.Label();
            this.testSuiteFormPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // testSuiteFormPanel
            // 
            this.testSuiteFormPanel.Controls.Add(this.panel3);
            this.testSuiteFormPanel.Controls.Add(this.panel2);
            this.testSuiteFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testSuiteFormPanel.Location = new System.Drawing.Point(0, 0);
            this.testSuiteFormPanel.Name = "testSuiteFormPanel";
            this.testSuiteFormPanel.Size = new System.Drawing.Size(661, 478);
            this.testSuiteFormPanel.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.testSuiteCancelButton);
            this.panel3.Controls.Add(this.testSuiteSaveButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 442);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(661, 36);
            this.panel3.TabIndex = 1;
            // 
            // testSuiteCancelButton
            // 
            this.testSuiteCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.testSuiteCancelButton.Location = new System.Drawing.Point(559, 6);
            this.testSuiteCancelButton.Name = "testSuiteCancelButton";
            this.testSuiteCancelButton.Size = new System.Drawing.Size(75, 23);
            this.testSuiteCancelButton.TabIndex = 1;
            this.testSuiteCancelButton.Text = "Cancel";
            this.testSuiteCancelButton.UseVisualStyleBackColor = true;
            this.testSuiteCancelButton.Click += new System.EventHandler(this.testSuiteCancelButton_Click);
            // 
            // testSuiteSaveButton
            // 
            this.testSuiteSaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.testSuiteSaveButton.Location = new System.Drawing.Point(459, 5);
            this.testSuiteSaveButton.Name = "testSuiteSaveButton";
            this.testSuiteSaveButton.Size = new System.Drawing.Size(75, 23);
            this.testSuiteSaveButton.TabIndex = 0;
            this.testSuiteSaveButton.Text = "Save";
            this.testSuiteSaveButton.UseVisualStyleBackColor = true;
            this.testSuiteSaveButton.Click += new System.EventHandler(this.testSuiteSaveButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.testSuiteSummaryText);
            this.panel2.Controls.Add(this.testSuiteSummaryLabel);
            this.panel2.Controls.Add(this.testSuiteNameText);
            this.panel2.Controls.Add(this.testSuiteNameLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(661, 143);
            this.panel2.TabIndex = 0;
            // 
            // testSuiteSummaryText
            // 
            this.testSuiteSummaryText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.testSuiteSummaryText.Location = new System.Drawing.Point(105, 55);
            this.testSuiteSummaryText.Multiline = true;
            this.testSuiteSummaryText.Name = "testSuiteSummaryText";
            this.testSuiteSummaryText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.testSuiteSummaryText.Size = new System.Drawing.Size(544, 69);
            this.testSuiteSummaryText.TabIndex = 3;
            // 
            // testSuiteSummaryLabel
            // 
            this.testSuiteSummaryLabel.AutoSize = true;
            this.testSuiteSummaryLabel.Location = new System.Drawing.Point(34, 58);
            this.testSuiteSummaryLabel.Name = "testSuiteSummaryLabel";
            this.testSuiteSummaryLabel.Size = new System.Drawing.Size(56, 13);
            this.testSuiteSummaryLabel.TabIndex = 2;
            this.testSuiteSummaryLabel.Text = "Summary: ";
            // 
            // testSuiteNameText
            // 
            this.testSuiteNameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.testSuiteNameText.Location = new System.Drawing.Point(105, 19);
            this.testSuiteNameText.Name = "testSuiteNameText";
            this.testSuiteNameText.Size = new System.Drawing.Size(544, 20);
            this.testSuiteNameText.TabIndex = 1;
            // 
            // testSuiteNameLabel
            // 
            this.testSuiteNameLabel.AutoSize = true;
            this.testSuiteNameLabel.Location = new System.Drawing.Point(49, 22);
            this.testSuiteNameLabel.Name = "testSuiteNameLabel";
            this.testSuiteNameLabel.Size = new System.Drawing.Size(41, 13);
            this.testSuiteNameLabel.TabIndex = 0;
            this.testSuiteNameLabel.Text = "Name: ";
            // 
            // TestSuiteDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.testSuiteFormPanel);
            this.Name = "TestSuiteDetailsForm";
            this.Size = new System.Drawing.Size(661, 478);
            this.testSuiteFormPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel testSuiteFormPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button testSuiteCancelButton;
        private System.Windows.Forms.Button testSuiteSaveButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox testSuiteSummaryText;
        private System.Windows.Forms.Label testSuiteSummaryLabel;
        private System.Windows.Forms.TextBox testSuiteNameText;
        private System.Windows.Forms.Label testSuiteNameLabel;

    }
}
