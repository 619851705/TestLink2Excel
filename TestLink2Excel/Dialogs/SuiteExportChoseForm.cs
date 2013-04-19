using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

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
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Result = DialogResult.Cancel;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Result = DialogResult.OK;
        }

        private void treeView_AfterCheck(object sender, TreeViewEventArgs e)
        {

            if (e.Node.Nodes.Count > 0 && e.Action == TreeViewAction.ByMouse)
            {
                checkAllNodes(e.Node, e.Node.Checked);
                if (e.Node.Checked == true) checkParentNode(e.Node);
            }
        }

        private void checkParentNode(TreeNode treeNode)
        {
            
            if (treeNode.Parent != null && treeNode.Parent.Checked == false)
            {
                treeNode.Parent.Checked = true;
                checkParentNode(treeNode);
            }
        }

        private void checkAllNodes(TreeNode treeNode, bool nodeChecked)
        {
            foreach(TreeNode node in treeNode.Nodes)
             {
                node.Checked = nodeChecked;
                if(node.Nodes.Count > 0)
                {
                    checkAllNodes(node, nodeChecked);
                }
            }
        }
    }
}
