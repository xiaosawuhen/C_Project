namespace AllControl
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.welcome_tab = new System.Windows.Forms.TabPage();
            this.welcomeMainTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.fileView = new System.Windows.Forms.TreeView();
            this.tabControl.SuspendLayout();
            this.welcome_tab.SuspendLayout();
            this.welcomeMainTablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.welcome_tab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(984, 562);
            this.tabControl.TabIndex = 1;
            // 
            // welcome_tab
            // 
            this.welcome_tab.Controls.Add(this.welcomeMainTablePanel);
            this.welcome_tab.Location = new System.Drawing.Point(4, 22);
            this.welcome_tab.Margin = new System.Windows.Forms.Padding(0);
            this.welcome_tab.Name = "welcome_tab";
            this.welcome_tab.Size = new System.Drawing.Size(976, 536);
            this.welcome_tab.TabIndex = 1;
            this.welcome_tab.Text = "Welcome";
            this.welcome_tab.UseVisualStyleBackColor = true;
            // 
            // welcomeMainTablePanel
            // 
            this.welcomeMainTablePanel.ColumnCount = 2;
            this.welcomeMainTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.welcomeMainTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.welcomeMainTablePanel.Controls.Add(this.fileView, 0, 0);
            this.welcomeMainTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcomeMainTablePanel.Location = new System.Drawing.Point(0, 0);
            this.welcomeMainTablePanel.Margin = new System.Windows.Forms.Padding(0);
            this.welcomeMainTablePanel.Name = "welcomeMainTablePanel";
            this.welcomeMainTablePanel.RowCount = 1;
            this.welcomeMainTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.welcomeMainTablePanel.Size = new System.Drawing.Size(976, 536);
            this.welcomeMainTablePanel.TabIndex = 0;
            // 
            // fileView
            // 
            this.fileView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileView.Location = new System.Drawing.Point(0, 0);
            this.fileView.Margin = new System.Windows.Forms.Padding(0);
            this.fileView.Name = "fileView";
            this.fileView.Size = new System.Drawing.Size(195, 536);
            this.fileView.TabIndex = 0;
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.tabControl);
            this.Name = "main_form";
            this.Text = "総合管理";
            this.tabControl.ResumeLayout(false);
            this.welcome_tab.ResumeLayout(false);
            this.welcomeMainTablePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage welcome_tab;
        private System.Windows.Forms.TableLayoutPanel welcomeMainTablePanel;
        private System.Windows.Forms.TreeView fileView;
    }
}

