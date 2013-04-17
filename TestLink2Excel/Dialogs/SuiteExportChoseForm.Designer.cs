namespace TestLink2Excel.Dialogs
{
	partial class SuiteExportChoseForm
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
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node0");
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.SuspendLayout();
			// 
			// treeView1
			// 
			this.treeView1.CheckBoxes = true;
			this.treeView1.Location = new System.Drawing.Point(13, 13);
			this.treeView1.Name = "treeView1";
			treeNode1.Name = "Node0";
			treeNode1.Text = "Node0";
			this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
			this.treeView1.Size = new System.Drawing.Size(173, 183);
			this.treeView1.TabIndex = 0;
			// 
			// SuiteExportChoseForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.treeView1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SuiteExportChoseForm";
			this.Text = "SuiteExportChoseForm";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TreeView treeView1;
	}
}