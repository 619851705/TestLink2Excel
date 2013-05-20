using System;
using System.Windows.Forms;

namespace TestLink2Excel.Dialogs
{
	public partial class SuiteExportChoseForm : Form
	{
		#region Constructors

		public SuiteExportChoseForm()
		{
			InitializeComponent();
		}

		public SuiteExportChoseForm(TreeNodeCollection treeNodeCollection)
		{
			InitializeComponent();
			treeView.Nodes.Clear();

			foreach (TreeNode node in treeNodeCollection)
			{
				TreeNode n = node.Clone() as TreeNode;
				treeView.Nodes.Add(n);
			}
		}

		#endregion

		#region Properties

		public DialogResult Result { get; set; }
		public TreeNodeCollection Nodes { get { return treeView.Nodes; } }

		#endregion

		#region Event handlers

		private void treeView_AfterCheck(object sender, TreeViewEventArgs e)
		{
			if (e.Node.Nodes.Count > 0 && e.Action == TreeViewAction.ByMouse)
				checkAllNodes(e.Node, e.Node.Checked);

			if (e.Node.Checked == true && e.Action == TreeViewAction.ByMouse)
				CheckParentNode(e.Node);
		}

		#endregion

		#region Private methodes

		private void CheckParentNode(TreeNode treeNode)
		{
			if (treeNode.Parent != null && treeNode.Parent.Checked == false)
			{
				treeNode.Parent.Checked = true;
				this.CheckParentNode(treeNode.Parent);
			}
		}

		private void checkAllNodes(TreeNode treeNode, bool nodeChecked)
		{
			foreach (TreeNode node in treeNode.Nodes)
			{
				node.Checked = nodeChecked;
				if (node.Nodes.Count > 0)
					checkAllNodes(node, nodeChecked);
			}
		}

		#endregion
	}
}
