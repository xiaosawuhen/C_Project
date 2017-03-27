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

namespace WorkManager
{
    public class WorkInfoControl
    {
        private TreeViewControl infoView = null;
        private TreeViewControl resultView = null;
        private TreeViewControl workSpaceView = null;
        private TreeViewControl manageView = null;

        // 資産
        // 成果物
        // 工程
        // 管理

        public WorkInfoControl(TreeView InfoView, TreeView ResultView, TreeView WorkSpaceView, TreeView ManageView)
        {
            this.infoView = new TreeViewControl(InfoView);
            this.resultView = new TreeViewControl(ResultView);
            this.workSpaceView = new TreeViewControl(WorkSpaceView);
            this.manageView = new TreeViewControl(ManageView);
        }

        public void init(string path, WorkInfo workInfo)
        {
            infoView.initialize(path + "\\" + workInfo.InfoName);
            resultView.initialize(path + "\\" + workInfo.ResultName);
            workSpaceView.initialize(path + "\\" + workInfo.WorkSpaceName);
            manageView.initialize(path + "\\" + workInfo.ManagerName);
        }
    }

    public class TreeViewControl
    {
        private TreeView view = null;

        public TreeViewControl(TreeView view)
        {
            this.view = view;
        }

        public void initialize(string path)
        {
            if(!Directory.Exists(path))
            {
                return;
            }

            view.Nodes.Clear();
            TreeNode headNode = createTreeNode(Path.GetFileName(path), path);
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
                TreeNode treeNode = createTreeNode(Path.GetFileName(directory), directory);
                node.Nodes.Add(treeNode);
                //addSubTreeNode(treeNode, directory);
            }

            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                TreeNode treeNode = createTreeNode(Path.GetFileName(file), file);
                node.Nodes.Add(treeNode);
            }
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

            ToolStripMenuItem menuItemOpenSpace = createToolItem("OpenWorkSpace", "OpenWorkSpace");
            menuItemOpenSpace.Click += new EventHandler(openSpaceClick);
            contextMenuStrip.Items.Add(menuItemOpenSpace);

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

        private void openSpaceClick(object sender, EventArgs e)
        {
            // "C:\Users\ydd-pc-869>E:\00_software\java\eclipse-jee-kepler-SR1-win32-x86_64\eclipse\eclipse.exe" -data "E:\02_work\瑞雪\工程\ruixue.crm.fw\trunk"
            string eclipseEXE = "E:\\00_software\\java\\eclipse-jee-kepler-SR1-win32-x86_64\\eclipse\\eclipsec.exe";
            TreeNode treeNode = this.view.SelectedNode;
            if (treeNode!= null && treeNode.Parent == null)
            {
                string comment = eclipseEXE + " -data " + treeNode.Name + "";
               // MessageBox.Show(comment);
                System.Diagnostics.Process p = new System.Diagnostics.Process();

                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.RedirectStandardInput = true;
                p.Start();
                p.StandardInput.WriteLine(comment);
                p.Close();
            }
        }
    }
}
