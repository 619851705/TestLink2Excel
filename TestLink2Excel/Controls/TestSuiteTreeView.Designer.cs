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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestSuiteTreeView));
            this.suiteTreeView = new System.Windows.Forms.TreeView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newNodeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.newTestCaseToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.treeContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.moveUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.folderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeViewImages = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1.SuspendLayout();
            this.treeContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // suiteTreeView
            // 
            this.suiteTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.suiteTreeView.ForeColor = System.Drawing.SystemColors.WindowText;
            this.suiteTreeView.FullRowSelect = true;
            this.suiteTreeView.HideSelection = false;
            this.suiteTreeView.ImageIndex = 2;
            this.suiteTreeView.ImageList = this.treeViewImages;
            this.suiteTreeView.LabelEdit = true;
            this.suiteTreeView.Location = new System.Drawing.Point(0, 25);
            this.suiteTreeView.Name = "suiteTreeView";
            this.suiteTreeView.SelectedImageIndex = 0;
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
            // treeContextMenuStrip
            // 
            this.treeContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripMenuItem3,
            this.moveUpToolStripMenuItem,
            this.moveDownToolStripMenuItem,
            this.toolStripMenuItem2,
            this.newToolStripMenuItem1,
            this.deleteToolStripMenuItem});
            this.treeContextMenuStrip.Name = "treeContextMenuStrip";
            this.treeContextMenuStrip.Size = new System.Drawing.Size(139, 148);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(135, 6);
            // 
            // moveUpToolStripMenuItem
            // 
            this.moveUpToolStripMenuItem.Name = "moveUpToolStripMenuItem";
            this.moveUpToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.moveUpToolStripMenuItem.Text = "Move Up";
            // 
            // moveDownToolStripMenuItem
            // 
            this.moveDownToolStripMenuItem.Name = "moveDownToolStripMenuItem";
            this.moveDownToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.moveDownToolStripMenuItem.Text = "Move Down";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(135, 6);
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.folderToolStripMenuItem,
            this.caseToolStripMenuItem});
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.newToolStripMenuItem1.Text = "New";
            // 
            // folderToolStripMenuItem
            // 
            this.folderToolStripMenuItem.Name = "folderToolStripMenuItem";
            this.folderToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.folderToolStripMenuItem.Text = "Folder";
            // 
            // caseToolStripMenuItem
            // 
            this.caseToolStripMenuItem.Name = "caseToolStripMenuItem";
            this.caseToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.caseToolStripMenuItem.Text = "Case";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // treeViewImages
            // 
            this.treeViewImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("treeViewImages.ImageStream")));
            this.treeViewImages.TransparentColor = System.Drawing.Color.Transparent;
            this.treeViewImages.Images.SetKeyName(0, "arrow-ico.ico");
            this.treeViewImages.Images.SetKeyName(1, "note.ico");
            this.treeViewImages.Images.SetKeyName(2, "small-folder.ico");
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
            this.treeContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView suiteTreeView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newNodeToolStripButton;
		private System.Windows.Forms.ToolStripButton newTestCaseToolStripButton;
		private System.Windows.Forms.ContextMenuStrip treeContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem moveUpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem moveDownToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem folderToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem caseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ImageList treeViewImages;

    }
}
