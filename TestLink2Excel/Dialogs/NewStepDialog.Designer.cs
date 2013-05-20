namespace TestLink2Excel.Dialogs
{
	partial class NewStepDialog
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
			this.nudStepNumber = new System.Windows.Forms.NumericUpDown();
			this.txtAction = new System.Windows.Forms.TextBox();
			this.txtExpectations = new System.Windows.Forms.TextBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.nudStepNumber)).BeginInit();
			this.SuspendLayout();
			// 
			// nudStepNumber
			// 
			this.nudStepNumber.Location = new System.Drawing.Point(85, 12);
			this.nudStepNumber.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.nudStepNumber.Name = "nudStepNumber";
			this.nudStepNumber.Size = new System.Drawing.Size(121, 20);
			this.nudStepNumber.TabIndex = 0;
			// 
			// txtAction
			// 
			this.txtAction.Location = new System.Drawing.Point(12, 56);
			this.txtAction.Multiline = true;
			this.txtAction.Name = "txtAction";
			this.txtAction.Size = new System.Drawing.Size(194, 111);
			this.txtAction.TabIndex = 1;
			// 
			// txtExpectations
			// 
			this.txtExpectations.Location = new System.Drawing.Point(12, 192);
			this.txtExpectations.Multiline = true;
			this.txtExpectations.Name = "txtExpectations";
			this.txtExpectations.Size = new System.Drawing.Size(194, 111);
			this.txtExpectations.TabIndex = 2;
			// 
			// btnOK
			// 
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(12, 309);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 3;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(131, 309);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Action";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 176);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Expectations";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 14);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Number";
			// 
			// NewStepDialog
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(218, 344);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.txtExpectations);
			this.Controls.Add(this.txtAction);
			this.Controls.Add(this.nudStepNumber);
			this.Name = "NewStepDialog";
			this.Text = "New Step";
			((System.ComponentModel.ISupportInitialize)(this.nudStepNumber)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown nudStepNumber;
		private System.Windows.Forms.TextBox txtAction;
		private System.Windows.Forms.TextBox txtExpectations;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}