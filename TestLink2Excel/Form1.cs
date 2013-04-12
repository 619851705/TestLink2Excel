using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestLink2Excel
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        #region eventHandlers
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "XML suite file (*.xml)|*.xml|All files (*.*)|*.*";
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                XMLSuite a = new XMLSuite(dialog.FileName);
                List<TestSuite> suites = a.makeTestSuite();
                suiteTreeView.BeginUpdate();
                foreach (TestSuite suite in suites)
                {
                    suiteTreeView.Nodes.Add(makeSuiteTree(suite));
                }
                ObjectHelper.OnChanged += new ObjectHelperOnHangeHandler(ObjectHelper_OnChanged);
                suiteTreeView.EndUpdate();
            }

        }

        private void suiteTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TestSuite suite = e.Node.Tag as TestSuite;
            TestCase testCase = e.Node.Tag as TestCase;
            if (suite != null)
            {
                showSuiteForm(suite);
                showToolStripButtons(e.Node);
            }
            else if (testCase != null)
            {
                showTestCaseForm(testCase);
                hideToolStripButtons();
            }
        }

        private void ObjectHelper_OnChanged(object instance)
        {
            TestSuite a = instance as TestSuite;
            suiteTreeView.BeginUpdate();
            foreach (TreeNode node in suiteTreeView.Nodes)
            {
                updateSuiteNames(a, node);
            }
            suiteTreeView.EndUpdate();
        }

        #endregion

        #region functions
        private void updateSuiteNames(TestSuite suite, TreeNode rootNode)
        {
            if (rootNode.Tag == suite) rootNode.Text = suite.Name;
            foreach (TreeNode node in rootNode.Nodes)
            {
                updateSuiteNames(suite, node);
            }
        }

        private TreeNode makeSuiteTree(TestSuite suite)
        {
            TreeNode node = new TreeNode();
            node.Text = suite.Name;
            node.Tag = suite;
            node.SelectedImageIndex = 2;
            node.ImageIndex = 0;
            foreach (TestSuite s in suite.UnderSuits)
            {
                node.Nodes.Add(makeSuiteTree(s));
            }
            
            foreach (TestCase testCase in suite.Tcs)
            {
                TreeNode tcNode = new TreeNode();
                tcNode.Text = testCase.Name;
                tcNode.Tag = testCase;
                tcNode.ImageIndex = 4;
                tcNode.SelectedImageIndex = 3;
                node.Nodes.Add(tcNode);
            }
            return node;
        }
        #endregion


        private void hideToolStripButtons()
        {
            newNodeToolStripButton.Visible = false;
            newTestCaseToolStripButton.Visible = false;
        }

        private void showToolStripButtons(TreeNode treeNode)
        {
            if (!newNodeToolStripButton.Visible) newNodeToolStripButton.Visible = true;
            newNodeToolStripButton.Tag = treeNode;
            if (!newTestCaseToolStripButton.Visible) newTestCaseToolStripButton.Visible = true;
            newNodeToolStripButton.Tag = treeNode;
        }

        private void showTestCaseForm(TestCase testCase)
        {
            

            if (testSuiteFormPanel.Visible) testSuiteFormPanel.Visible = false;
            if (!testCaseFormPanel.Visible) testCaseFormPanel.Visible = true;

            loadtestCaseForm(testCase);
        }


        private void showSuiteForm(TestSuite suite)
        {
            if (testCaseFormPanel.Visible) testCaseFormPanel.Visible = false;
            if (!testSuiteFormPanel.Visible) testSuiteFormPanel.Visible = true;

            loadTestSuiteForm(suite);
        }

        private void loadTestSuiteForm(TestSuite suite)
        {
            testSuiteFormPanel.Tag = suite;
            testSuiteNameText.Text = suite.Name;
            testSuiteNameText.Tag = suite.Name;
            testSuiteSummaryText.Text = suite.Description;
            testSuiteSummaryText.Tag = suite.Description;
        }


        private void loadtestCaseForm(TestCase testCase)
        {
            int x = 10, y = 15;
            testCaseFormPanel.Tag = testCase;
            testCaseNameText.Text = testCase.Name;
            testCaseNameText.Tag = testCase.Name;
            testCaseSummaryText.Text = testCase.Summary;
            testCaseSummaryText.Tag = testCase.Summary;
            testCasePreconditionsText.Text = testCase.Preconditions;
            testCasePreconditionsText.Tag = testCase.Preconditions;
            actionsPanel.Controls.Clear();
            expectionsPanel.Controls.Clear();
            int textBoxWeight = actionsPanel.Size.Width - x - 30 - 10;
            foreach (Step step in testCase.Steps)
            {
                addStep(step, textBoxWeight, x, y);
                y += 80;
            }
        }

        private void addStep(Step step, int boxWeight, int x, int y)
        {
            Label t = new Label();
            t.Text = step.StepNumber.ToString() + ": ";
            t.TextAlign = ContentAlignment.MiddleRight;
            t.Location = new System.Drawing.Point(x, y + 2);
            t.Size = new System.Drawing.Size(25, 18);
            t.TabIndex = step.StepNumber;
            actionsPanel.Controls.Add(t);

            TextBox text = new TextBox();
            text.Location = new System.Drawing.Point(x + 30, y);
            text.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            text.Multiline = true;
            text.Size = new System.Drawing.Size(boxWeight, 69);
            text.Text = step.Action;
            text.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            text.Tag = step;
            actionsPanel.Controls.Add(text);


            Label t2 = new Label();
            t2.Text = step.StepNumber.ToString() + ": ";
            t2.TextAlign = ContentAlignment.MiddleRight;
            t2.Location = new System.Drawing.Point(x, y + 2);
            t2.Size = new System.Drawing.Size(25, 18);
            t2.TabIndex = step.StepNumber;
            expectionsPanel.Controls.Add(t2);


            TextBox expected = new TextBox();
            expected.Location = new System.Drawing.Point(x + 30, y);
            expected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                            | System.Windows.Forms.AnchorStyles.Right)));
            expected.Multiline = true;
            expected.Size = new System.Drawing.Size(boxWeight, 69);
            expected.Text = step.ExpectedResult;
            expected.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            expected.Tag = step;
            expectionsPanel.Controls.Add(expected);
        }

        private void testSuiteSaveButton_Click(object sender, EventArgs e)
        {
            TestSuite suite = testSuiteFormPanel.Tag as TestSuite;
            suite.Description = testSuiteSummaryText.Text;
            suite.Name = testSuiteNameText.Text;
            loadTestSuiteForm(suite);
        }

        private void testSuiteCancelButton_Click(object sender, EventArgs e)
        {
            TestSuite suite = testSuiteFormPanel.Tag as TestSuite;
            loadTestSuiteForm(suite);
        }

        private void saveTestCaseButton_Click(object sender, EventArgs e)
        {
            TestCase testCase = testCaseFormPanel.Tag as TestCase;
            testCase.Name = testCaseNameText.Text;
            testCase.Summary = testCaseSummaryText.Text;
            testCase.Preconditions = testCasePreconditionsText.Text;
            foreach (Control box in actionsPanel.Controls)
            {
                Step step = box.Tag as Step;
                if(step != null)
                {
                    step.Action = box.Text;
                }
            }
            foreach (Control box in expectionsPanel.Controls)
            {
                Step step = box.Tag as Step;
                if (step != null)
                {
                    step.ExpectedResult = box.Text;
                }
            }
        }

        private void cancelTestCaseButton_Click(object sender, EventArgs e)
        {
            TestCase testCase = testCaseFormPanel.Tag as TestCase;
            loadtestCaseForm(testCase);
        }

        private void excelSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<TestSuite> suites = new List<TestSuite>();
            foreach (TreeNode node in suiteTreeView.Nodes)
            {
                TestSuite suite = node.Tag as TestSuite;
                suites.Add(suite);
            }
            if (suites.Count > 0)
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Microsoft Excel Worksheet (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK) // Test result.
                {
                    ExcelWriter file = new ExcelWriter(dialog.FileName);
                    foreach (TestSuite suite in suites)
                    {
                        file.generateSuiteSheet(suite);
                    }
                    file.Save();
                    file.Close();
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string i = ((TestSuite)suiteTreeView.SelectedNode.Tag).Name;
            MessageBox.Show(i);
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            suiteTreeView.Nodes.Add(makeSuiteTree(new TestSuite("<<New Test Suite>>",string.Empty)));
        }

        private void newNodeToolStripButton_Click(object sender, EventArgs e)
        {
            TreeNode node = newNodeToolStripButton.Tag as TreeNode;
            node.Nodes.Add(makeSuiteTree(new TestSuite("<<New Test Suite>>", string.Empty)));
        }

        private void newTestCaseToolStripButton_Click(object sender, EventArgs e)
        {
            TreeNode node = newNodeToolStripButton.Tag as TreeNode;
            TreeNode tcNode = new TreeNode();
            tcNode.Text = "<<new Test Case>>";
            tcNode.Tag = new TestCase("<<new Test Case>>");
            node.Nodes.Add(tcNode);
            tcNode.BeginEdit();
        }

        private void suiteTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                e.Node.TreeView.SelectedNode = e.Node;
                treeContextMenuStrip.Show(Cursor.Position);
            }
        }

        private void testLinkXlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestSuite suite = suiteTreeView.SelectedNode.Tag as TestSuite;
            if (suite != null)
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "XML File (*.xml)|*.xml|All files (*.*)|*.*";
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK) // Test result.
                {
                    XMLSuite x = new XMLSuite(suite);
                    x.saveAs(dialog.FileName);
                }
            }
        }
    }
}
