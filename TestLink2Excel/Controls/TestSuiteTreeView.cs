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
    }
}
