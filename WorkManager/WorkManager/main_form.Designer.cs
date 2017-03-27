namespace WorkManager
{
    partial class main_form
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.workManager = new System.Windows.Forms.TabPage();
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.workTitlePanel = new System.Windows.Forms.Panel();
            this.workContentPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.workContentInfoView = new System.Windows.Forms.TreeView();
            this.workContentResultView = new System.Windows.Forms.TreeView();
            this.workContentWorkSpaceView = new System.Windows.Forms.TreeView();
            this.workContentManageView = new System.Windows.Forms.TreeView();
            this.workContentConfigMenu = new System.Windows.Forms.MenuStrip();
            this.infoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.resultMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.workspaceMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.managerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.workManager.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.workContentPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.workContentConfigMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.workManager);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 562);
            this.tabControl1.TabIndex = 1;
            // 
            // workManager
            // 
            this.workManager.Controls.Add(this.mainPanel);
            this.workManager.Location = new System.Drawing.Point(4, 22);
            this.workManager.Margin = new System.Windows.Forms.Padding(0);
            this.workManager.Name = "workManager";
            this.workManager.Size = new System.Drawing.Size(976, 536);
            this.workManager.TabIndex = 0;
            this.workManager.Text = "WorkManager";
            this.workManager.UseVisualStyleBackColor = true;
            // 
            // mainPanel
            // 
            this.mainPanel.ColumnCount = 1;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPanel.Controls.Add(this.workTitlePanel, 0, 0);
            this.mainPanel.Controls.Add(this.workContentPanel, 0, 1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 2;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.mainPanel.Size = new System.Drawing.Size(976, 536);
            this.mainPanel.TabIndex = 0;
            // 
            // workTitlePanel
            // 
            this.workTitlePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.workTitlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workTitlePanel.Location = new System.Drawing.Point(0, 0);
            this.workTitlePanel.Margin = new System.Windows.Forms.Padding(0);
            this.workTitlePanel.Name = "workTitlePanel";
            this.workTitlePanel.Size = new System.Drawing.Size(976, 160);
            this.workTitlePanel.TabIndex = 0;
            // 
            // workContentPanel
            // 
            this.workContentPanel.Controls.Add(this.tableLayoutPanel1);
            this.workContentPanel.Controls.Add(this.workContentConfigMenu);
            this.workContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workContentPanel.Location = new System.Drawing.Point(0, 160);
            this.workContentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.workContentPanel.Name = "workContentPanel";
            this.workContentPanel.Size = new System.Drawing.Size(976, 376);
            this.workContentPanel.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.workContentInfoView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.workContentResultView, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.workContentWorkSpaceView, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.workContentManageView, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(940, 376);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // workContentInfoView
            // 
            this.workContentInfoView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workContentInfoView.Location = new System.Drawing.Point(0, 0);
            this.workContentInfoView.Margin = new System.Windows.Forms.Padding(0);
            this.workContentInfoView.Name = "workContentInfoView";
            this.workContentInfoView.Size = new System.Drawing.Size(235, 376);
            this.workContentInfoView.TabIndex = 0;
            // 
            // workContentResultView
            // 
            this.workContentResultView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workContentResultView.Location = new System.Drawing.Point(235, 0);
            this.workContentResultView.Margin = new System.Windows.Forms.Padding(0);
            this.workContentResultView.Name = "workContentResultView";
            this.workContentResultView.Size = new System.Drawing.Size(235, 376);
            this.workContentResultView.TabIndex = 1;
            // 
            // workContentWorkSpaceView
            // 
            this.workContentWorkSpaceView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workContentWorkSpaceView.Location = new System.Drawing.Point(470, 0);
            this.workContentWorkSpaceView.Margin = new System.Windows.Forms.Padding(0);
            this.workContentWorkSpaceView.Name = "workContentWorkSpaceView";
            this.workContentWorkSpaceView.Size = new System.Drawing.Size(235, 376);
            this.workContentWorkSpaceView.TabIndex = 2;
            // 
            // workContentManageView
            // 
            this.workContentManageView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workContentManageView.Location = new System.Drawing.Point(705, 0);
            this.workContentManageView.Margin = new System.Windows.Forms.Padding(0);
            this.workContentManageView.Name = "workContentManageView";
            this.workContentManageView.Size = new System.Drawing.Size(235, 376);
            this.workContentManageView.TabIndex = 3;
            // 
            // workContentConfigMenu
            // 
            this.workContentConfigMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.workContentConfigMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoMenu,
            this.resultMenu,
            this.workspaceMenu,
            this.managerMenu});
            this.workContentConfigMenu.Location = new System.Drawing.Point(940, 0);
            this.workContentConfigMenu.Name = "workContentConfigMenu";
            this.workContentConfigMenu.Size = new System.Drawing.Size(36, 376);
            this.workContentConfigMenu.TabIndex = 0;
            this.workContentConfigMenu.Text = "menuStrip2";
            this.workContentConfigMenu.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // infoMenu
            // 
            this.infoMenu.Name = "infoMenu";
            this.infoMenu.Size = new System.Drawing.Size(44, 22);
            this.infoMenu.Text = "資料";
            this.infoMenu.Click += new System.EventHandler(this.infoMenu_Click);
            // 
            // resultMenu
            // 
            this.resultMenu.Name = "resultMenu";
            this.resultMenu.Size = new System.Drawing.Size(56, 22);
            this.resultMenu.Text = "成果物";
            this.resultMenu.Click += new System.EventHandler(this.resultMenu_Click);
            // 
            // workspaceMenu
            // 
            this.workspaceMenu.Name = "workspaceMenu";
            this.workspaceMenu.Size = new System.Drawing.Size(44, 22);
            this.workspaceMenu.Text = "工程";
            this.workspaceMenu.Click += new System.EventHandler(this.workspaceMenu_Click);
            // 
            // managerMenu
            // 
            this.managerMenu.Name = "managerMenu";
            this.managerMenu.Size = new System.Drawing.Size(44, 22);
            this.managerMenu.Text = "管理";
            this.managerMenu.Click += new System.EventHandler(this.managerMenu_Click);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.tabControl1);
            this.Name = "main_form";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.workManager.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.workContentPanel.ResumeLayout(false);
            this.workContentPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.workContentConfigMenu.ResumeLayout(false);
            this.workContentConfigMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage workManager;
        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private System.Windows.Forms.Panel workTitlePanel;
        private System.Windows.Forms.Panel workContentPanel;
        private System.Windows.Forms.ToolStripMenuItem infoMenu;
        private System.Windows.Forms.ToolStripMenuItem resultMenu;
        private System.Windows.Forms.ToolStripMenuItem workspaceMenu;
        private System.Windows.Forms.ToolStripMenuItem managerMenu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TreeView workContentInfoView;
        private System.Windows.Forms.TreeView workContentResultView;
        private System.Windows.Forms.TreeView workContentWorkSpaceView;
        private System.Windows.Forms.TreeView workContentManageView;
        private System.Windows.Forms.MenuStrip workContentConfigMenu;
    }
}

