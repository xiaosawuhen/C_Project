using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkManager
{
    public partial class main_form : Form
    {
        private string baseConf = "config\\work\\conf.xml";
        private WorkListControl workListControl = null;
        private WorkInfoControl workInfo = null;

        public main_form()
        {
            InitializeComponent();
            
            Info.config = ConfigIO.getConfig(baseConf);

            workListControl = new WorkListControl(this.workTitlePanel);
            workInfo = new WorkInfoControl(this.workContentInfoView,this.workContentResultView,this.workContentWorkSpaceView,this.workContentManageView);

            workListControl.connectView(workInfo);
        }

        public TabPage getTabPage()
        {
            return this.workManager;
        }

        private bool managerShow = true;
        private bool workspaceShow = true;
        private bool resultShow = true;
        private bool infoShow = true;

        private void showView()
        {
            int size = 0;
            Stack<TreeView> stack = new Stack<TreeView>();
            if (managerShow)
            {
                size++;
                stack.Push(this.workContentManageView);
            }
            if (workspaceShow)
            {
                size++;
                stack.Push(this.workContentWorkSpaceView);
            }
            if (resultShow)
            {
                size++;
                stack.Push(this.workContentResultView);
            }
            if (infoShow)
            {
                size++;
                stack.Push(this.workContentInfoView);
            }

            if (size == 0)
            {
                this.tableLayoutPanel1.Controls.Clear();
                this.tableLayoutPanel1.ColumnCount = 4;
                this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
                this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
                this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
                this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
                this.tableLayoutPanel1.Controls.Add(this.workContentInfoView, 0, 0);
                this.tableLayoutPanel1.Controls.Add(this.workContentResultView, 1, 0);
                this.tableLayoutPanel1.Controls.Add(this.workContentWorkSpaceView, 2, 0);
                this.tableLayoutPanel1.Controls.Add(this.workContentManageView, 3, 0);
            }
            else
            {
                this.tableLayoutPanel1.Controls.Clear();
                this.tableLayoutPanel1.ColumnCount = size;
                for (int i = 0; i < size; i++)
                {
                    this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100 / size));
                    this.tableLayoutPanel1.Controls.Add(stack.Pop(), i, 0);
                }
            }
        }

        private void managerMenu_Click(object sender, EventArgs e)
        {
            managerShow = !managerShow;
            showView();
        }

        private void workspaceMenu_Click(object sender, EventArgs e)
        {
            workspaceShow = !workspaceShow;
            showView();
        }

        private void resultMenu_Click(object sender, EventArgs e)
        {
            resultShow = !resultShow;
            showView();
        }

        private void infoMenu_Click(object sender, EventArgs e)
        {
            infoShow = !infoShow;
            showView();
        }

        public void changeConfig()
        {
            Config config = new Config();
            config.BathPath = "E:\\02_work";

            WorkInfo baseWorkInfo = new WorkInfo();

            baseWorkInfo.InfoName = "資産";// 資産
            baseWorkInfo.ResultName = "成果物";// 成果物
            baseWorkInfo.WorkSpaceName = "工程";// 工程
            baseWorkInfo.ManagerName = "管理"; // 管理
            config.WorkInfo = baseWorkInfo;

            ConfigIO.setConfig(config, baseConf);
        }

    }
}
