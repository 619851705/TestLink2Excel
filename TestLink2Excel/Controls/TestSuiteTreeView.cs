using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TestLink2Excel.Model;

namespace TestLink2Excel.Controls
{
    public partial class TestSuiteTreeView : UserControl
	{

        #region Constructors
		public TestSuiteTreeView()
        {
            InitializeComponent();
        }
		#endregion

        #region Public methodes

        /// <summary>
		/// Generating tree node based on TestSuite object.
		/// </summary>
		/// <param name="suite"></param>
		public void generateTreeNode(TestSuite suite)
		{
            suiteTreeView.BeginUpdate();
            suiteTreeView.Nodes.Add(makeSuiteTree(suite));
            suiteTreeView.EndUpdate();
		}
        #endregion

        #region Private methodes


        /// <summary>
        /// Update given suite node Text to equals with suite Name.
        /// </summary>
        /// <param name="suite"></param>
        /// <param name="nodes"></param>
        private void updateTreeViewSuiteNames(TestSuite suite, TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                TestSuite suiteTag = node.Tag as TestSuite;
                if (suiteTag != null && suiteTag.Equals(suite))
                {
                    suiteTreeView.BeginUpdate();
                    node.Text = node.Text = (node.Tag as TestSuite).Name;
                    suiteTreeView.EndUpdate();
                }
                else if (node.Nodes.Count > 0)
                {
                    updateTreeViewSuiteNames(suite, node.Nodes);
                }
            }
        }




        /// <summary>
        /// Make TreeNode from given suite and place suite ref into node Tag.
        /// </summary>
        /// <param name="suite"></param>
        /// <returns></returns>
		private TreeNode makeSuiteTree(TestSuite suite)
		{
			TreeNode node = new TreeNode();
			node.Text = suite.Name;
			node.Tag = suite;
			node.SelectedImageIndex = 0;
			node.ImageIndex = 2;

            suite.PropertyChanged += new PropertyChangedEventHandler(suite_PropertyChanged);

			foreach (TestSuite s in suite.UnderSuits)
			{
				node.Nodes.Add(makeSuiteTree(s));
			}

			foreach (TestCase testCase in suite.Tcs)
			{
				TreeNode tcNode = new TreeNode();
				tcNode.Text = testCase.Name;
				tcNode.Tag = testCase;
				tcNode.ImageIndex = 1;
				tcNode.SelectedImageIndex = 0;
				node.Nodes.Add(tcNode);
			}
			return node;
        }
        #endregion

        #region Events handlers
        void suite_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            TestSuite suite = sender as TestSuite;
            updateTreeViewSuiteNames(suite, suiteTreeView.Nodes);
        }


        /// <summary>
        /// to musze poukładać
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void suiteTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                e.Node.TreeView.SelectedNode = e.Node;
                treeContextMenuStrip.Show(Cursor.Position);
            }
        }
        #endregion
    }
}
