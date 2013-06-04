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
			this.pnlTestSuiteForm = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btnTestSuiteCancel = new System.Windows.Forms.Button();
			this.btnTestSuiteSave = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txtTestSuiteSummary = new System.Windows.Forms.TextBox();
			this.lblTestSuiteSummary = new System.Windows.Forms.Label();
			this.txtTestSuiteName = new System.Windows.Forms.TextBox();
			this.lblTestSuiteName = new System.Windows.Forms.Label();
			this.pnlTestSuiteForm.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlTestSuiteForm
			// 
			this.pnlTestSuiteForm.Controls.Add(this.panel3);
			this.pnlTestSuiteForm.Controls.Add(this.panel2);
			this.pnlTestSuiteForm.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlTestSuiteForm.Location = new System.Drawing.Point(0, 0);
			this.pnlTestSuiteForm.Name = "pnlTestSuiteForm";
			this.pnlTestSuiteForm.Size = new System.Drawing.Size(661, 478);
			this.pnlTestSuiteForm.TabIndex = 5;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.btnTestSuiteCancel);
			this.panel3.Controls.Add(this.btnTestSuiteSave);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 442);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(661, 36);
			this.panel3.TabIndex = 1;
			// 
			// btnTestSuiteCancel
			// 
			this.btnTestSuiteCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnTestSuiteCancel.Location = new System.Drawing.Point(559, 6);
			this.btnTestSuiteCancel.Name = "btnTestSuiteCancel";
			this.btnTestSuiteCancel.Size = new System.Drawing.Size(75, 23);
			this.btnTestSuiteCancel.TabIndex = 1;
			this.btnTestSuiteCancel.Text = "Reload";
			this.btnTestSuiteCancel.UseVisualStyleBackColor = true;
			this.btnTestSuiteCancel.Click += new System.EventHandler(this.TestSuiteCancelButton_Click);
			// 
			// btnTestSuiteSave
			// 
			this.btnTestSuiteSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnTestSuiteSave.Location = new System.Drawing.Point(459, 5);
			this.btnTestSuiteSave.Name = "btnTestSuiteSave";
			this.btnTestSuiteSave.Size = new System.Drawing.Size(75, 23);
			this.btnTestSuiteSave.TabIndex = 0;
			this.btnTestSuiteSave.Text = "Save";
			this.btnTestSuiteSave.UseVisualStyleBackColor = true;
			this.btnTestSuiteSave.Click += new System.EventHandler(this.TestSuiteSaveButton_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.txtTestSuiteSummary);
			this.panel2.Controls.Add(this.lblTestSuiteSummary);
			this.panel2.Controls.Add(this.txtTestSuiteName);
			this.panel2.Controls.Add(this.lblTestSuiteName);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(661, 143);
			this.panel2.TabIndex = 0;
			// 
			// txtTestSuiteSummary
			// 
			this.txtTestSuiteSummary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTestSuiteSummary.Location = new System.Drawing.Point(105, 55);
			this.txtTestSuiteSummary.Multiline = true;
			this.txtTestSuiteSummary.Name = "txtTestSuiteSummary";
			this.txtTestSuiteSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtTestSuiteSummary.Size = new System.Drawing.Size(544, 69);
			this.txtTestSuiteSummary.TabIndex = 3;
			this.txtTestSuiteSummary.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTestSuiteSummary_KeyDown);
			// 
			// lblTestSuiteSummary
			// 
			this.lblTestSuiteSummary.AutoSize = true;
			this.lblTestSuiteSummary.Location = new System.Drawing.Point(34, 58);
			this.lblTestSuiteSummary.Name = "lblTestSuiteSummary";
			this.lblTestSuiteSummary.Size = new System.Drawing.Size(56, 13);
			this.lblTestSuiteSummary.TabIndex = 2;
			this.lblTestSuiteSummary.Text = "Summary: ";
			// 
			// txtTestSuiteName
			// 
			this.txtTestSuiteName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTestSuiteName.Location = new System.Drawing.Point(105, 19);
			this.txtTestSuiteName.Name = "txtTestSuiteName";
			this.txtTestSuiteName.Size = new System.Drawing.Size(544, 20);
			this.txtTestSuiteName.TabIndex = 1;
			// 
			// lblTestSuiteName
			// 
			this.lblTestSuiteName.AutoSize = true;
			this.lblTestSuiteName.Location = new System.Drawing.Point(49, 22);
			this.lblTestSuiteName.Name = "lblTestSuiteName";
			this.lblTestSuiteName.Size = new System.Drawing.Size(41, 13);
			this.lblTestSuiteName.TabIndex = 0;
			this.lblTestSuiteName.Text = "Name: ";
			// 
			// TestSuiteDetailsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pnlTestSuiteForm);
			this.Name = "TestSuiteDetailsForm";
			this.Size = new System.Drawing.Size(661, 478);
			this.pnlTestSuiteForm.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTestSuiteForm;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnTestSuiteCancel;
        private System.Windows.Forms.Button btnTestSuiteSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTestSuiteSummary;
        private System.Windows.Forms.Label lblTestSuiteSummary;
        private System.Windows.Forms.TextBox txtTestSuiteName;
        private System.Windows.Forms.Label lblTestSuiteName;

    }
}
