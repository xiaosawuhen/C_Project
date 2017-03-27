using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Security.AccessControl;

namespace AllControl
{

    public class FileViewControl
    {
        private TreeView view = null;
        private string path = "E:\\";

        public FileViewControl(TreeView treeView)
        {
            this.view = treeView;
        }
        
        public void initialize()
        {
            if(!Directory.Exists(path))
            {
                return;
            }

            view.Nodes.Clear();
            TreeNode headNode = createTreeNode("E", path);
            view.Nodes.Add(headNode);

            addSubTreeNode(headNode, path);

            //view.ExpandAll();
            this.view.MouseDown += new System.Windows.Forms.MouseEventHandler(this.viewMouseDown);

            this.view.AfterExpand += new TreeViewEventHandler(this.viewAfterExpand);
        }

        private void viewAfterExpand(object sender, TreeViewEventArgs e)
        {
            TreeNode treeNode = e.Node;

            IEnumerator iEnumerator = treeNode.Nodes.GetEnumerator();
            while (iEnumerator.MoveNext())
            {
                TreeNode subNode = (TreeNode)iEnumerator.Current;
                subNode.Nodes.Clear();
                string name = subNode.Name;
                if (Directory.Exists(name))
                {
                    addSubTreeNode(subNode, name);
                }
            }
        }

        public void addSubTreeNode(TreeNode node, String path)
        {
            string[] directories = Directory.GetDirectories(path);
            foreach (string directory in directories)
            {
                DirectoryInfo DirectoryInfo = new DirectoryInfo(directory);

                if (DirectoryInfo.Attributes.Equals(FileAttributes.Directory))
                {
                    //MessageBox.Show(directory + "---" + DirectoryInfo.Attributes.ToString());
                    TreeNode treeNode = createTreeNode(Path.GetFileName(directory), directory);
                    node.Nodes.Add(treeNode);
                }

                //addSubTreeNode(treeNode, directory);
            }

            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                TreeNode treeNode = createTreeNode(Path.GetFileName(file), file);
                node.Nodes.Add(treeNode);
            }
            //node.Expand();
        }

        private TreeNode createTreeNode(string name, string path)
        {
            TreeNode treeNode = new TreeNode();
            treeNode.Name = path;
            treeNode.Text = name;

            return treeNode;
        }

        private void viewMouseDown(object sender, MouseEventArgs e)
        {
            this.view.ContextMenuStrip = null;
            if (e.Button == MouseButtons.Right)
            {
                Point point = this.view.PointToClient(Control.MousePosition);
                TreeNode treeNode = this.view.GetNodeAt(point.X, point.Y);
                if (treeNode != null)
                {
                    this.view.SelectedNode = treeNode;
                    this.view.ContextMenuStrip = createContextMenuStrip();
                }
            }
        }

        public ContextMenuStrip createContextMenuStrip()
        {
            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
            contextMenuStrip.BackColor = System.Drawing.Color.WhiteSmoke;
            contextMenuStrip.Size = new System.Drawing.Size(44, 22);

            ToolStripMenuItem menuItemOpen = createToolItem("Open", "Open");
            menuItemOpen.Click += new EventHandler(OpenClick);
            contextMenuStrip.Items.Add(menuItemOpen);

            return contextMenuStrip;
        }

        public ToolStripMenuItem createToolItem(string name, string text)
        {
            ToolStripMenuItem item = new ToolStripMenuItem();
            item.BackColor = System.Drawing.Color.WhiteSmoke;
            item.Name = name;
            item.Size = new System.Drawing.Size(44, 22);
            item.Text = text;

            return item;
        }

        private void OpenClick(object sender, EventArgs e)
        {
            TreeNode treeNode = this.view.SelectedNode;
            string file = treeNode.Name;
            System.Diagnostics.Process.Start("\"" + file + "\"");
        }
    }
}
