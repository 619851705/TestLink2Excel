namespace TestLink2Excel
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.cancelTestCaseButton = new System.Windows.Forms.Button();
            this.saveTestCaseButton = new System.Windows.Forms.Button();
            this.testCaseNameLabel = new System.Windows.Forms.Label();
            this.mainSplit = new System.Windows.Forms.SplitContainer();
            this.suiteTreeView = new System.Windows.Forms.TreeView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newNodeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.newTestCaseToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.testCaseFormPanel = new System.Windows.Forms.Panel();
            this.stepsGroupBox = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.actionGroupBox = new System.Windows.Forms.GroupBox();
            this.actionsPanel = new System.Windows.Forms.Panel();
            this.expectionGroupBox = new System.Windows.Forms.GroupBox();
            this.expectionsPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.testCaseNameText = new System.Windows.Forms.TextBox();
            this.textCasePreconditionsLabel = new System.Windows.Forms.Label();
            this.testCaseSummaryText = new System.Windows.Forms.TextBox();
            this.testCasePreconditionsText = new System.Windows.Forms.TextBox();
            this.textCaseSummaryLabel = new System.Windows.Forms.Label();
            this.testSuiteFormPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.testSuiteCancelButton = new System.Windows.Forms.Button();
            this.testSuiteSaveButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.testSuiteSummaryText = new System.Windows.Forms.TextBox();
            this.testSuiteSummaryLabel = new System.Windows.Forms.Label();
            this.testSuiteNameText = new System.Windows.Forms.TextBox();
            this.testSuiteNameLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelSheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testLinkXlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplit)).BeginInit();
            this.mainSplit.Panel1.SuspendLayout();
            this.mainSplit.Panel2.SuspendLayout();
            this.mainSplit.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.testCaseFormPanel.SuspendLayout();
            this.stepsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.actionGroupBox.SuspendLayout();
            this.expectionGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.testSuiteFormPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.treeContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.cancelTestCaseButton);
            this.buttonPanel.Controls.Add(this.saveTestCaseButton);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPanel.Location = new System.Drawing.Point(0, 415);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(673, 36);
            this.buttonPanel.TabIndex = 0;
            // 
            // cancelTestCaseButton
            // 
            this.cancelTestCaseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelTestCaseButton.Location = new System.Drawing.Point(571, 6);
            this.cancelTestCaseButton.Name = "cancelTestCaseButton";
            this.cancelTestCaseButton.Size = new System.Drawing.Size(75, 23);
            this.cancelTestCaseButton.TabIndex = 1;
            this.cancelTestCaseButton.Text = "Cancel";
            this.cancelTestCaseButton.UseVisualStyleBackColor = true;
            this.cancelTestCaseButton.Click += new System.EventHandler(this.cancelTestCaseButton_Click);
            // 
            // saveTestCaseButton
            // 
            this.saveTestCaseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveTestCaseButton.Location = new System.Drawing.Point(471, 6);
            this.saveTestCaseButton.Name = "saveTestCaseButton";
            this.saveTestCaseButton.Size = new System.Drawing.Size(75, 23);
            this.saveTestCaseButton.TabIndex = 0;
            this.saveTestCaseButton.Text = "Save";
            this.saveTestCaseButton.UseVisualStyleBackColor = true;
            this.saveTestCaseButton.Click += new System.EventHandler(this.saveTestCaseButton_Click);
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
            // mainSplit
            // 
            this.mainSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplit.Location = new System.Drawing.Point(0, 24);
            this.mainSplit.Name = "mainSplit";
            // 
            // mainSplit.Panel1
            // 
            this.mainSplit.Panel1.Controls.Add(this.suiteTreeView);
            this.mainSplit.Panel1.Controls.Add(this.toolStrip1);
            // 
            // mainSplit.Panel2
            // 
            this.mainSplit.Panel2.Controls.Add(this.testCaseFormPanel);
            this.mainSplit.Panel2.Controls.Add(this.testSuiteFormPanel);
            this.mainSplit.Size = new System.Drawing.Size(922, 451);
            this.mainSplit.SplitterDistance = 245;
            this.mainSplit.TabIndex = 1;
            // 
            // suiteTreeView
            // 
            this.suiteTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.suiteTreeView.ForeColor = System.Drawing.SystemColors.WindowText;
            this.suiteTreeView.FullRowSelect = true;
            this.suiteTreeView.HideSelection = false;
            this.suiteTreeView.ImageIndex = 0;
            this.suiteTreeView.ImageList = this.imageList1;
            this.suiteTreeView.LabelEdit = true;
            this.suiteTreeView.Location = new System.Drawing.Point(0, 25);
            this.suiteTreeView.Name = "suiteTreeView";
            this.suiteTreeView.SelectedImageIndex = 0;
            this.suiteTreeView.Size = new System.Drawing.Size(245, 426);
            this.suiteTreeView.TabIndex = 1;
            this.suiteTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.suiteTreeView_AfterSelect);
            this.suiteTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.suiteTreeView_NodeMouseClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newNodeToolStripButton,
            this.newTestCaseToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(245, 25);
            this.toolStrip1.TabIndex = 2;
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
            this.newNodeToolStripButton.Click += new System.EventHandler(this.newNodeToolStripButton_Click);
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
            this.newTestCaseToolStripButton.Click += new System.EventHandler(this.newTestCaseToolStripButton_Click);
            // 
            // testCaseFormPanel
            // 
            this.testCaseFormPanel.Controls.Add(this.stepsGroupBox);
            this.testCaseFormPanel.Controls.Add(this.buttonPanel);
            this.testCaseFormPanel.Controls.Add(this.panel1);
            this.testCaseFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testCaseFormPanel.Location = new System.Drawing.Point(0, 0);
            this.testCaseFormPanel.Name = "testCaseFormPanel";
            this.testCaseFormPanel.Size = new System.Drawing.Size(673, 451);
            this.testCaseFormPanel.TabIndex = 0;
            this.testCaseFormPanel.Visible = false;
            // 
            // stepsGroupBox
            // 
            this.stepsGroupBox.Controls.Add(this.splitContainer1);
            this.stepsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stepsGroupBox.Location = new System.Drawing.Point(0, 189);
            this.stepsGroupBox.Name = "stepsGroupBox";
            this.stepsGroupBox.Size = new System.Drawing.Size(673, 226);
            this.stepsGroupBox.TabIndex = 6;
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
            this.splitContainer1.Size = new System.Drawing.Size(667, 207);
            this.splitContainer1.SplitterDistance = 330;
            this.splitContainer1.TabIndex = 0;
            // 
            // actionGroupBox
            // 
            this.actionGroupBox.Controls.Add(this.actionsPanel);
            this.actionGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionGroupBox.Location = new System.Drawing.Point(0, 0);
            this.actionGroupBox.Name = "actionGroupBox";
            this.actionGroupBox.Size = new System.Drawing.Size(330, 207);
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
            this.actionsPanel.Size = new System.Drawing.Size(324, 188);
            this.actionsPanel.TabIndex = 0;
            // 
            // expectionGroupBox
            // 
            this.expectionGroupBox.Controls.Add(this.expectionsPanel);
            this.expectionGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expectionGroupBox.Location = new System.Drawing.Point(0, 0);
            this.expectionGroupBox.Name = "expectionGroupBox";
            this.expectionGroupBox.Size = new System.Drawing.Size(333, 207);
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
            this.expectionsPanel.Size = new System.Drawing.Size(327, 188);
            this.expectionsPanel.TabIndex = 0;
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
            this.panel1.Size = new System.Drawing.Size(673, 189);
            this.panel1.TabIndex = 7;
            // 
            // testCaseNameText
            // 
            this.testCaseNameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.testCaseNameText.Location = new System.Drawing.Point(86, 6);
            this.testCaseNameText.Name = "testCaseNameText";
            this.testCaseNameText.Size = new System.Drawing.Size(575, 20);
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
            this.testCaseSummaryText.Size = new System.Drawing.Size(575, 69);
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
            this.testCasePreconditionsText.Size = new System.Drawing.Size(575, 69);
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
            // testSuiteFormPanel
            // 
            this.testSuiteFormPanel.Controls.Add(this.panel3);
            this.testSuiteFormPanel.Controls.Add(this.panel2);
            this.testSuiteFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testSuiteFormPanel.Location = new System.Drawing.Point(0, 0);
            this.testSuiteFormPanel.Name = "testSuiteFormPanel";
            this.testSuiteFormPanel.Size = new System.Drawing.Size(673, 451);
            this.testSuiteFormPanel.TabIndex = 4;
            this.testSuiteFormPanel.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.testSuiteCancelButton);
            this.panel3.Controls.Add(this.testSuiteSaveButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 415);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(673, 36);
            this.panel3.TabIndex = 1;
            // 
            // testSuiteCancelButton
            // 
            this.testSuiteCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.testSuiteCancelButton.Location = new System.Drawing.Point(571, 6);
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
            this.testSuiteSaveButton.Location = new System.Drawing.Point(471, 5);
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
            this.panel2.Size = new System.Drawing.Size(673, 143);
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
            this.testSuiteSummaryText.Size = new System.Drawing.Size(556, 69);
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
            this.testSuiteNameText.Size = new System.Drawing.Size(556, 20);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(922, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::TestLink2Excel.Properties.Resources.file_new_icon;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::TestLink2Excel.Properties.Resources.file_new_icon;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.openToolStripMenuItem.Text = "&Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelSheetToolStripMenuItem,
            this.testLinkXlsToolStripMenuItem});
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            // 
            // excelSheetToolStripMenuItem
            // 
            this.excelSheetToolStripMenuItem.Name = "excelSheetToolStripMenuItem";
            this.excelSheetToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.excelSheetToolStripMenuItem.Text = "Excel sheet...";
            this.excelSheetToolStripMenuItem.Click += new System.EventHandler(this.excelSheetToolStripMenuItem_Click);
            // 
            // testLinkXlsToolStripMenuItem
            // 
            this.testLinkXlsToolStripMenuItem.Name = "testLinkXlsToolStripMenuItem";
            this.testLinkXlsToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.testLinkXlsToolStripMenuItem.Text = "Test link xls...";
            this.testLinkXlsToolStripMenuItem.Click += new System.EventHandler(this.testLinkXlsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exitToolStripMenuItem.Text = "&E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.aboutToolStripMenuItem.Text = "&About..";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 475);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(922, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(795, 475);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 22);
            this.progressBar.TabIndex = 4;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
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
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "raritysockiesicon.ico");
            this.imageList1.Images.SetKeyName(1, "rarityticon2.ico");
            this.imageList1.Images.SetKeyName(2, "rariweticon.ico");
            this.imageList1.Images.SetKeyName(3, "Steam Icon.ico");
            this.imageList1.Images.SetKeyName(4, "Steam_Pony.ico");
            this.imageList1.Images.SetKeyName(5, "SteamPony.ico");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 497);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.mainSplit);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "TestLink 2 Excel";
            this.buttonPanel.ResumeLayout(false);
            this.mainSplit.Panel1.ResumeLayout(false);
            this.mainSplit.Panel1.PerformLayout();
            this.mainSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplit)).EndInit();
            this.mainSplit.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.testCaseFormPanel.ResumeLayout(false);
            this.stepsGroupBox.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.actionGroupBox.ResumeLayout(false);
            this.expectionGroupBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.testSuiteFormPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.treeContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.SplitContainer mainSplit;
        private System.Windows.Forms.TreeView suiteTreeView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox testCaseNameText;
        private System.Windows.Forms.Label testCaseNameLabel;
        private System.Windows.Forms.Panel testCaseFormPanel;
        private System.Windows.Forms.TextBox testCasePreconditionsText;
        private System.Windows.Forms.Label textCaseSummaryLabel;
        private System.Windows.Forms.TextBox testCaseSummaryText;
        private System.Windows.Forms.Label textCasePreconditionsLabel;
        private System.Windows.Forms.GroupBox stepsGroupBox;
        private System.Windows.Forms.GroupBox expectionGroupBox;
        private System.Windows.Forms.GroupBox actionGroupBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel actionsPanel;
        private System.Windows.Forms.Panel expectionsPanel;
        private System.Windows.Forms.Button cancelTestCaseButton;
        private System.Windows.Forms.Button saveTestCaseButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel testSuiteFormPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox testSuiteSummaryText;
        private System.Windows.Forms.Label testSuiteSummaryLabel;
        private System.Windows.Forms.TextBox testSuiteNameText;
        private System.Windows.Forms.Label testSuiteNameLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button testSuiteCancelButton;
        private System.Windows.Forms.Button testSuiteSaveButton;
        private System.Windows.Forms.ToolStripMenuItem excelSheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testLinkXlsToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ToolStripButton newNodeToolStripButton;
        private System.Windows.Forms.ToolStripButton newTestCaseToolStripButton;
        private System.Windows.Forms.ContextMenuStrip treeContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem moveUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem folderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caseToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
    }
}

