namespace TestLink2Excel.Dialogs
{
	partial class NewSuiteDialog
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtTestSuiteSummary = new System.Windows.Forms.TextBox();
			this.lblTestSuiteSummary = new System.Windows.Forms.Label();
			this.txtTestSuiteName = new System.Windows.Forms.TextBox();
			this.lblTestSuiteName = new System.Windows.Forms.Label();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtTestSuiteSummary
			// 
			this.txtTestSuiteSummary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTestSuiteSummary.Location = new System.Drawing.Point(75, 48);
			this.txtTestSuiteSummary.Multiline = true;
			this.txtTestSuiteSummary.Name = "txtTestSuiteSummary";
			this.txtTestSuiteSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtTestSuiteSummary.Size = new System.Drawing.Size(170, 69);
			this.txtTestSuiteSummary.TabIndex = 7;
			// 
			// lblTestSuiteSummary
			// 
			this.lblTestSuiteSummary.AutoSize = true;
			this.lblTestSuiteSummary.Location = new System.Drawing.Point(4, 51);
			this.lblTestSuiteSummary.Name = "lblTestSuiteSummary";
			this.lblTestSuiteSummary.Size = new System.Drawing.Size(56, 13);
			this.lblTestSuiteSummary.TabIndex = 6;
			this.lblTestSuiteSummary.Text = "Summary: ";
			// 
			// txtTestSuiteName
			// 
			this.txtTestSuiteName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTestSuiteName.Location = new System.Drawing.Point(75, 12);
			this.txtTestSuiteName.Name = "txtTestSuiteName";
			this.txtTestSuiteName.Size = new System.Drawing.Size(170, 20);
			this.txtTestSuiteName.TabIndex = 5;
			// 
			// lblTestSuiteName
			// 
			this.lblTestSuiteName.AutoSize = true;
			this.lblTestSuiteName.Location = new System.Drawing.Point(4, 15);
			this.lblTestSuiteName.Name = "lblTestSuiteName";
			this.lblTestSuiteName.Size = new System.Drawing.Size(41, 13);
			this.lblTestSuiteName.TabIndex = 4;
			this.lblTestSuiteName.Text = "Name: ";
			// 
			// btnOK
			// 
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(12, 158);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 8;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(170, 158);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 9;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// NewSuite
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(257, 192);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.txtTestSuiteSummary);
			this.Controls.Add(this.lblTestSuiteSummary);
			this.Controls.Add(this.txtTestSuiteName);
			this.Controls.Add(this.lblTestSuiteName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "NewSuite";
			this.Text = "New Suite";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtTestSuiteSummary;
		private System.Windows.Forms.Label lblTestSuiteSummary;
		private System.Windows.Forms.TextBox txtTestSuiteName;
		private System.Windows.Forms.Label lblTestSuiteName;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;

	}
}