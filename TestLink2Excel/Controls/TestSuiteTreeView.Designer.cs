namespace TestLink2Excel.Controls
{
    partial class TestSuiteTreeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestSuiteTreeView));
            this.suiteTreeView = new System.Windows.Forms.TreeView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newNodeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.newTestCaseToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // suiteTreeView
            // 
            this.suiteTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.suiteTreeView.ForeColor = System.Drawing.SystemColors.WindowText;
            this.suiteTreeView.FullRowSelect = true;
            this.suiteTreeView.HideSelection = false;
            this.suiteTreeView.LabelEdit = true;
            this.suiteTreeView.Location = new System.Drawing.Point(0, 25);
            this.suiteTreeView.Name = "suiteTreeView";
            this.suiteTreeView.Size = new System.Drawing.Size(239, 413);
            this.suiteTreeView.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newNodeToolStripButton,
            this.newTestCaseToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(239, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "New Test Case";
            // 
            // newNodeToolStripButton
            // 
            this.newNodeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newNodeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newNodeToolStripButton.Image")));
            this.newNodeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newNodeToolStripButton.Name = "newNodeToolStripButton";
            this.newNodeToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newNodeToolStripButton.Text = "New Suite Folder";
            this.newNodeToolStripButton.ToolTipText = "New Folder";
            this.newNodeToolStripButton.Visible = false;
            // 
            // newTestCaseToolStripButton
            // 
            this.newTestCaseToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newTestCaseToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newTestCaseToolStripButton.Image")));
            this.newTestCaseToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newTestCaseToolStripButton.Name = "newTestCaseToolStripButton";
            this.newTestCaseToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newTestCaseToolStripButton.Text = "New Test Case";
            this.newTestCaseToolStripButton.Visible = false;
            // 
            // TestSuiteTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.suiteTreeView);
            this.Controls.Add(this.toolStrip1);
            this.Name = "TestSuiteTreeView";
            this.Size = new System.Drawing.Size(239, 438);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView suiteTreeView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newNodeToolStripButton;
        private System.Windows.Forms.ToolStripButton newTestCaseToolStripButton;

    }
}
