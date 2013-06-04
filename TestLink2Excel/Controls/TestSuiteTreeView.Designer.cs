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
			this.treeViewImages = new System.Windows.Forms.ImageList(this.components);
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.newNodeToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.newTestCaseToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.moveUpToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.moveDownToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.treeContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.hereIWantButtonsFromToolBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newCaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.moveUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.moveDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.folderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.caseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.imageListDrag = new System.Windows.Forms.ImageList(this.components);
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.toolStrip.SuspendLayout();
			this.treeContextMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// suiteTreeView
			// 
			this.suiteTreeView.AllowDrop = true;
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
			this.suiteTreeView.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.suiteTreeView_ItemDrag);
			this.suiteTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.SuiteTreeView_AfterSelect);
			this.suiteTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.SuiteTreeView_NodeMouseClick);
			this.suiteTreeView.DragDrop += new System.Windows.Forms.DragEventHandler(this.suiteTreeView_DragDrop);
			this.suiteTreeView.DragEnter += new System.Windows.Forms.DragEventHandler(this.suiteTreeView_DragEnter);
			this.suiteTreeView.DragOver += new System.Windows.Forms.DragEventHandler(this.suiteTreeView_DragOver);
			this.suiteTreeView.DragLeave += new System.EventHandler(this.suiteTreeView_DragLeave);
			this.suiteTreeView.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.suiteTreeView_GiveFeedback);
			// 
			// treeViewImages
			// 
			this.treeViewImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("treeViewImages.ImageStream")));
			this.treeViewImages.TransparentColor = System.Drawing.Color.Transparent;
			this.treeViewImages.Images.SetKeyName(0, "arrow-ico.ico");
			this.treeViewImages.Images.SetKeyName(1, "note.ico");
			this.treeViewImages.Images.SetKeyName(2, "small-folder.ico");
			// 
			// toolStrip
			// 
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newNodeToolStripButton,
            this.newTestCaseToolStripButton,
            this.toolStripSeparator1,
            this.moveUpToolStripButton,
            this.moveDownToolStripButton,
            this.toolStripSeparator2,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.deleteToolStripButton});
			this.toolStrip.Location = new System.Drawing.Point(0, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new System.Drawing.Size(239, 25);
			this.toolStrip.TabIndex = 4;
			this.toolStrip.Text = "New Test Case";
			// 
			// newNodeToolStripButton
			// 
			this.newNodeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.newNodeToolStripButton.Enabled = false;
			this.newNodeToolStripButton.Image = global::TestLink2Excel.Properties.Resources.add_folder_ico;
			this.newNodeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.newNodeToolStripButton.Name = "newNodeToolStripButton";
			this.newNodeToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.newNodeToolStripButton.Text = "New Suite Folder";
			this.newNodeToolStripButton.ToolTipText = "New Folder";
			this.newNodeToolStripButton.Click += new System.EventHandler(this.newNodeToolStripButton_Click);
			// 
			// newTestCaseToolStripButton
			// 
			this.newTestCaseToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.newTestCaseToolStripButton.Enabled = false;
			this.newTestCaseToolStripButton.Image = global::TestLink2Excel.Properties.Resources.add_note;
			this.newTestCaseToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.newTestCaseToolStripButton.Name = "newTestCaseToolStripButton";
			this.newTestCaseToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.newTestCaseToolStripButton.Text = "New Test Case";
			this.newTestCaseToolStripButton.Click += new System.EventHandler(this.newTestCaseToolStripButton_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// moveUpToolStripButton
			// 
			this.moveUpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.moveUpToolStripButton.Enabled = false;
			this.moveUpToolStripButton.Image = global::TestLink2Excel.Properties.Resources.move_up_ico;
			this.moveUpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.moveUpToolStripButton.Name = "moveUpToolStripButton";
			this.moveUpToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.moveUpToolStripButton.Text = "moveUpToolStripButton";
			this.moveUpToolStripButton.ToolTipText = "Move Up";
			this.moveUpToolStripButton.Click += new System.EventHandler(this.moveUpToolStripButton_Click);
			// 
			// moveDownToolStripButton
			// 
			this.moveDownToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.moveDownToolStripButton.Enabled = false;
			this.moveDownToolStripButton.Image = global::TestLink2Excel.Properties.Resources.move_down_ico;
			this.moveDownToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.moveDownToolStripButton.Name = "moveDownToolStripButton";
			this.moveDownToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.moveDownToolStripButton.Text = "moveDownToolStripButton";
			this.moveDownToolStripButton.ToolTipText = "Move Down";
			this.moveDownToolStripButton.Click += new System.EventHandler(this.moveDownToolStripButton_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// copyToolStripButton
			// 
			this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.copyToolStripButton.Enabled = false;
			this.copyToolStripButton.Image = global::TestLink2Excel.Properties.Resources.copy_ico;
			this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.copyToolStripButton.Name = "copyToolStripButton";
			this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.copyToolStripButton.Text = "copyToolStripButton";
			this.copyToolStripButton.ToolTipText = "Copy";
			this.copyToolStripButton.Click += new System.EventHandler(this.copyToolStripButton_Click);
			// 
			// pasteToolStripButton
			// 
			this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.pasteToolStripButton.Enabled = false;
			this.pasteToolStripButton.Image = global::TestLink2Excel.Properties.Resources.paste_ico;
			this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.pasteToolStripButton.Name = "pasteToolStripButton";
			this.pasteToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.pasteToolStripButton.Text = "pasteToolStripButton";
			this.pasteToolStripButton.ToolTipText = "Paste";
			this.pasteToolStripButton.Click += new System.EventHandler(this.pasteToolStripButton_Click);
			// 
			// deleteToolStripButton
			// 
			this.deleteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.deleteToolStripButton.Enabled = false;
			this.deleteToolStripButton.Image = global::TestLink2Excel.Properties.Resources.delete_co;
			this.deleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.deleteToolStripButton.Name = "deleteToolStripButton";
			this.deleteToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.deleteToolStripButton.Text = "deleteToolStripButton";
			this.deleteToolStripButton.ToolTipText = "Delete";
			this.deleteToolStripButton.Click += new System.EventHandler(this.deleteToolStripButton_Click);
			// 
			// treeContextMenuStrip
			// 
			this.treeContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hereIWantButtonsFromToolBarToolStripMenuItem,
            this.newCaseToolStripMenuItem,
            this.toolStripMenuItem1,
            this.moveUpToolStripMenuItem,
            this.moveDownToolStripMenuItem,
            this.toolStripMenuItem2,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem});
			this.treeContextMenuStrip.Name = "treeContextMenuStrip";
			this.treeContextMenuStrip.Size = new System.Drawing.Size(139, 170);
			// 
			// hereIWantButtonsFromToolBarToolStripMenuItem
			// 
			this.hereIWantButtonsFromToolBarToolStripMenuItem.Image = global::TestLink2Excel.Properties.Resources.add_folder_ico;
			this.hereIWantButtonsFromToolBarToolStripMenuItem.Name = "hereIWantButtonsFromToolBarToolStripMenuItem";
			this.hereIWantButtonsFromToolBarToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
			this.hereIWantButtonsFromToolBarToolStripMenuItem.Text = "New Folder";
			this.hereIWantButtonsFromToolBarToolStripMenuItem.Click += new System.EventHandler(this.newNodeToolStripButton_Click);
			// 
			// newCaseToolStripMenuItem
			// 
			this.newCaseToolStripMenuItem.Image = global::TestLink2Excel.Properties.Resources.add_note;
			this.newCaseToolStripMenuItem.Name = "newCaseToolStripMenuItem";
			this.newCaseToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
			this.newCaseToolStripMenuItem.Text = "New Case";
			this.newCaseToolStripMenuItem.Click += new System.EventHandler(this.newTestCaseToolStripButton_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(135, 6);
			// 
			// moveUpToolStripMenuItem
			// 
			this.moveUpToolStripMenuItem.Image = global::TestLink2Excel.Properties.Resources.move_up_ico;
			this.moveUpToolStripMenuItem.Name = "moveUpToolStripMenuItem";
			this.moveUpToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
			this.moveUpToolStripMenuItem.Text = "Move Up";
			this.moveUpToolStripMenuItem.Click += new System.EventHandler(this.moveUpToolStripButton_Click);
			// 
			// moveDownToolStripMenuItem
			// 
			this.moveDownToolStripMenuItem.Image = global::TestLink2Excel.Properties.Resources.move_down_ico;
			this.moveDownToolStripMenuItem.Name = "moveDownToolStripMenuItem";
			this.moveDownToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
			this.moveDownToolStripMenuItem.Text = "Move Down";
			this.moveDownToolStripMenuItem.Click += new System.EventHandler(this.moveDownToolStripButton_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(135, 6);
			// 
			// copyToolStripMenuItem
			// 
			this.copyToolStripMenuItem.Image = global::TestLink2Excel.Properties.Resources.copy_ico;
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
			this.copyToolStripMenuItem.Text = "Copy";
			this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripButton_Click);
			// 
			// pasteToolStripMenuItem
			// 
			this.pasteToolStripMenuItem.Image = global::TestLink2Excel.Properties.Resources.paste_ico;
			this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
			this.pasteToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
			this.pasteToolStripMenuItem.Text = "Paste";
			this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripButton_Click);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Image = global::TestLink2Excel.Properties.Resources.delete_co;
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
			this.deleteToolStripMenuItem.Text = "Delete";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripButton_Click);
			// 
			// folderToolStripMenuItem
			// 
			this.folderToolStripMenuItem.Name = "folderToolStripMenuItem";
			this.folderToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.folderToolStripMenuItem.Text = "Folder";
			// 
			// caseToolStripMenuItem
			// 
			this.caseToolStripMenuItem.Name = "caseToolStripMenuItem";
			this.caseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.caseToolStripMenuItem.Text = "Case";
			// 
			// imageListDrag
			// 
			this.imageListDrag.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageListDrag.ImageSize = new System.Drawing.Size(16, 16);
			this.imageListDrag.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// timer
			// 
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// TestSuiteTreeView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.suiteTreeView);
			this.Controls.Add(this.toolStrip);
			this.Name = "TestSuiteTreeView";
			this.Size = new System.Drawing.Size(239, 438);
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.treeContextMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip treeContextMenuStrip;
        private System.Windows.Forms.ImageList treeViewImages;
        private System.Windows.Forms.TreeView suiteTreeView;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton newNodeToolStripButton;
		private System.Windows.Forms.ToolStripButton newTestCaseToolStripButton;
        private System.Windows.Forms.ToolStripButton moveUpToolStripButton;
        private System.Windows.Forms.ToolStripButton moveDownToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripButton deleteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem folderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hereIWantButtonsFromToolBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem moveUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ImageList imageListDrag;
		private System.Windows.Forms.Timer timer;

    }
}
