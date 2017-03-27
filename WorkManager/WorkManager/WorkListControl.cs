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

namespace WorkManager
{
    public class WorkListControl
    {
        private Panel workTitlePanel = null;
        private WorkInfoControl workInfoControl = null; 

        public WorkListControl(Panel workTitlePanel)
        {
            this.workTitlePanel = workTitlePanel;

            //
            this.workTitlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.workTitlePanelMouseDown);
            initWorkPanel();
        }

        private void initWorkPanel()
        {
            this.workTitlePanel.Controls.Clear();
            LinkLabelFactory.resetPosition();
            string basePath = Info.config.BathPath;
            foreach (string subPath in Directory.GetDirectories(basePath))
            {
                LinkLabel linkLabel = LinkLabelFactory.createLinkLabel(Path.GetFileName(subPath));
                linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel_LinkClicked);
                this.workTitlePanel.Controls.Add(linkLabel);
            }
        }

        public void connectView(WorkInfoControl workInfo)
        {
            this.workInfoControl = workInfo;
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel linkLabel = (LinkLabel)sender;
            string filePath = linkLabel.Name;
            this.workInfoControl.init(filePath, Info.config.WorkInfo);
        }

        private void workTitlePanelMouseDown(object sender, MouseEventArgs e)
        {
            workTitlePanel.ContextMenuStrip = null;
            if (e.Button == MouseButtons.Right)
            {
                Point point = workTitlePanel.PointToClient(Control.MousePosition);

                ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
                contextMenuStrip.BackColor = System.Drawing.Color.WhiteSmoke;
                contextMenuStrip.Size = new System.Drawing.Size(44, 22);

                ToolStripMenuItem menuItem = createToolItem("New", "New");
                menuItem.Click += new EventHandler(menuItem_Clicked);
                contextMenuStrip.Items.Add(menuItem);

                workTitlePanel.ContextMenuStrip = contextMenuStrip;

            }
        }

        private void menuItem_Clicked(object sender, EventArgs e)
        {
            WorkNameForm form = new WorkNameForm();
            DialogResult dialogResult = form.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                string path = Info.config.BathPath + "\\" + form.getName();
                Directory.CreateDirectory(path);

                WorkInfo workInfo = Info.config.WorkInfo;
                Directory.CreateDirectory(path + "\\" + workInfo.InfoName);
                Directory.CreateDirectory(path + "\\" + workInfo.ManagerName);
                Directory.CreateDirectory(path + "\\" + workInfo.ResultName);
                Directory.CreateDirectory(path + "\\" + workInfo.WorkSpaceName);
                initWorkPanel();
            }
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
    }

    public class LinkLabelFactory
    {
        private static int currentX = 0;
        private static int currentY = 0;

        private static int sizeY = 12;

        public static void resetPosition()
        {
            currentX = 0;
            currentY = 0;
        }

        public static LinkLabel createLinkLabel(string name)
        {

            //int sizeX = name.Length * 15;

            LinkLabel linkLabel = new System.Windows.Forms.LinkLabel();
            linkLabel.AutoSize = true;
            linkLabel.BackColor = Color.Orange;
            linkLabel.LinkColor = Color.Black;
            linkLabel.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel.Location = new System.Drawing.Point(currentX, currentY);
            linkLabel.Name = WorkFile.newProject(name);
            //linkLabel.Size = new System.Drawing.Size(sizeX, sizeY);
            linkLabel.TabIndex = 0;
            linkLabel.TabStop = true;
            linkLabel.Text = name;

            Graphics g = linkLabel.CreateGraphics();
            Font stringFont = new Font("Arial", 9);
            SizeF stringSize = g.MeasureString(name, stringFont);

            //MessageBox.Show(stringSize.Width.ToString());
            calculateXY((int)stringSize.Width, sizeY);

            return linkLabel;
        }

        private static void calculateXY(int x, int y)
        {
            currentX += x;

            if (currentX > 800)
            {
                currentX = 0;
                currentY += y;
            }
        }
    }
}
