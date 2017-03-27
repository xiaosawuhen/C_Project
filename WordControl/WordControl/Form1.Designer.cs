namespace WordControl
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
            this.main_menu = new System.Windows.Forms.MenuStrip();
            this.表示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.非表示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.learnTab = new System.Windows.Forms.TabPage();
            this.learn_main_panel = new System.Windows.Forms.TableLayoutPanel();
            this.learn_adm_panel = new System.Windows.Forms.TableLayoutPanel();
            this.learn_example_panel = new System.Windows.Forms.Panel();
            this.learn_example_table_panel = new System.Windows.Forms.TableLayoutPanel();
            this.learn_book_text = new System.Windows.Forms.RichTextBox();
            this.learn_example_menu = new System.Windows.Forms.MenuStrip();
            this.learn_menu_modify = new System.Windows.Forms.ToolStripMenuItem();
            this.learn_menu_add = new System.Windows.Forms.ToolStripMenuItem();
            this.learn_menu_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.learn_menu_next = new System.Windows.Forms.ToolStripMenuItem();
            this.learn_menu_pre = new System.Windows.Forms.ToolStripMenuItem();
            this.learn_menu_random = new System.Windows.Forms.ToolStripMenuItem();
            this.learn_word_panel = new System.Windows.Forms.Panel();
            this.learn_word_table_panel = new System.Windows.Forms.TableLayoutPanel();
            this.learn_ch_word_text = new System.Windows.Forms.TextBox();
            this.learn_jp2_word_text = new System.Windows.Forms.TextBox();
            this.learn_jp_word_text = new System.Windows.Forms.TextBox();
            this.learn_word_list = new System.Windows.Forms.TreeView();
            this.learn_example_text = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bookStore = new System.Windows.Forms.ToolStripMenuItem();
            this.main_menu.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.learnTab.SuspendLayout();
            this.learn_main_panel.SuspendLayout();
            this.learn_adm_panel.SuspendLayout();
            this.learn_example_panel.SuspendLayout();
            this.learn_example_table_panel.SuspendLayout();
            this.learn_example_menu.SuspendLayout();
            this.learn_word_panel.SuspendLayout();
            this.learn_word_table_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_menu
            // 
            this.main_menu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.main_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.表示ToolStripMenuItem,
            this.非表示ToolStripMenuItem});
            this.main_menu.Location = new System.Drawing.Point(0, 0);
            this.main_menu.Name = "main_menu";
            this.main_menu.Size = new System.Drawing.Size(984, 26);
            this.main_menu.TabIndex = 0;
            this.main_menu.Text = "main_menu";
            // 
            // 表示ToolStripMenuItem
            // 
            this.表示ToolStripMenuItem.Name = "表示ToolStripMenuItem";
            this.表示ToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.表示ToolStripMenuItem.Text = "表示";
            // 
            // 非表示ToolStripMenuItem
            // 
            this.非表示ToolStripMenuItem.Name = "非表示ToolStripMenuItem";
            this.非表示ToolStripMenuItem.Size = new System.Drawing.Size(56, 22);
            this.非表示ToolStripMenuItem.Text = "非表示";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.learnTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 26);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(984, 536);
            this.tabControl.TabIndex = 1;
            // 
            // learnTab
            // 
            this.learnTab.Controls.Add(this.learn_main_panel);
            this.learnTab.Location = new System.Drawing.Point(4, 22);
            this.learnTab.Name = "learnTab";
            this.learnTab.Padding = new System.Windows.Forms.Padding(3);
            this.learnTab.Size = new System.Drawing.Size(976, 510);
            this.learnTab.TabIndex = 2;
            this.learnTab.Text = "単語復習";
            this.learnTab.UseVisualStyleBackColor = true;
            // 
            // learn_main_panel
            // 
            this.learn_main_panel.ColumnCount = 2;
            this.learn_main_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.learn_main_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.learn_main_panel.Controls.Add(this.learn_adm_panel, 0, 0);
            this.learn_main_panel.Controls.Add(this.learn_word_list, 1, 0);
            this.learn_main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.learn_main_panel.Location = new System.Drawing.Point(3, 3);
            this.learn_main_panel.Margin = new System.Windows.Forms.Padding(0);
            this.learn_main_panel.Name = "learn_main_panel";
            this.learn_main_panel.RowCount = 1;
            this.learn_main_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.learn_main_panel.Size = new System.Drawing.Size(970, 504);
            this.learn_main_panel.TabIndex = 1;
            // 
            // learn_adm_panel
            // 
            this.learn_adm_panel.ColumnCount = 1;
            this.learn_adm_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.learn_adm_panel.Controls.Add(this.learn_example_panel, 0, 0);
            this.learn_adm_panel.Controls.Add(this.learn_word_panel, 0, 1);
            this.learn_adm_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.learn_adm_panel.Location = new System.Drawing.Point(0, 0);
            this.learn_adm_panel.Margin = new System.Windows.Forms.Padding(0);
            this.learn_adm_panel.Name = "learn_adm_panel";
            this.learn_adm_panel.RowCount = 2;
            this.learn_adm_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.learn_adm_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.learn_adm_panel.Size = new System.Drawing.Size(776, 504);
            this.learn_adm_panel.TabIndex = 0;
            // 
            // learn_example_panel
            // 
            this.learn_example_panel.Controls.Add(this.learn_example_table_panel);
            this.learn_example_panel.Controls.Add(this.learn_example_menu);
            this.learn_example_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.learn_example_panel.Location = new System.Drawing.Point(0, 0);
            this.learn_example_panel.Margin = new System.Windows.Forms.Padding(0);
            this.learn_example_panel.Name = "learn_example_panel";
            this.learn_example_panel.Size = new System.Drawing.Size(776, 453);
            this.learn_example_panel.TabIndex = 0;
            // 
            // learn_example_table_panel
            // 
            this.learn_example_table_panel.ColumnCount = 1;
            this.learn_example_table_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.learn_example_table_panel.Controls.Add(this.learn_example_text, 0, 1);
            this.learn_example_table_panel.Controls.Add(this.panel1, 0, 0);
            this.learn_example_table_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.learn_example_table_panel.Location = new System.Drawing.Point(0, 0);
            this.learn_example_table_panel.Margin = new System.Windows.Forms.Padding(0);
            this.learn_example_table_panel.Name = "learn_example_table_panel";
            this.learn_example_table_panel.RowCount = 2;
            this.learn_example_table_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.learn_example_table_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.learn_example_table_panel.Size = new System.Drawing.Size(776, 429);
            this.learn_example_table_panel.TabIndex = 2;
            // 
            // learn_book_text
            // 
            this.learn_book_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.learn_book_text.Location = new System.Drawing.Point(0, 0);
            this.learn_book_text.Margin = new System.Windows.Forms.Padding(0);
            this.learn_book_text.Name = "learn_book_text";
            this.learn_book_text.Size = new System.Drawing.Size(776, 274);
            this.learn_book_text.TabIndex = 1;
            this.learn_book_text.Text = "";
            // 
            // learn_example_menu
            // 
            this.learn_example_menu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.learn_example_menu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.learn_example_menu.GripMargin = new System.Windows.Forms.Padding(0);
            this.learn_example_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.learn_menu_modify,
            this.learn_menu_add,
            this.learn_menu_delete,
            this.learn_menu_next,
            this.learn_menu_pre,
            this.learn_menu_random});
            this.learn_example_menu.Location = new System.Drawing.Point(0, 429);
            this.learn_example_menu.Name = "learn_example_menu";
            this.learn_example_menu.Padding = new System.Windows.Forms.Padding(0);
            this.learn_example_menu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.learn_example_menu.Size = new System.Drawing.Size(776, 24);
            this.learn_example_menu.TabIndex = 0;
            // 
            // learn_menu_modify
            // 
            this.learn_menu_modify.BackColor = System.Drawing.Color.WhiteSmoke;
            this.learn_menu_modify.Name = "learn_menu_modify";
            this.learn_menu_modify.Size = new System.Drawing.Size(44, 24);
            this.learn_menu_modify.Text = "修正";
            this.learn_menu_modify.Click += new System.EventHandler(this.learn_menu_modify_Click);
            // 
            // learn_menu_add
            // 
            this.learn_menu_add.Name = "learn_menu_add";
            this.learn_menu_add.Size = new System.Drawing.Size(44, 24);
            this.learn_menu_add.Text = "追加";
            this.learn_menu_add.Click += new System.EventHandler(this.learn_menu_add_Click);
            // 
            // learn_menu_delete
            // 
            this.learn_menu_delete.Name = "learn_menu_delete";
            this.learn_menu_delete.Size = new System.Drawing.Size(44, 24);
            this.learn_menu_delete.Text = "削除";
            this.learn_menu_delete.Click += new System.EventHandler(this.learn_menu_delete_Click);
            // 
            // learn_menu_next
            // 
            this.learn_menu_next.Name = "learn_menu_next";
            this.learn_menu_next.Size = new System.Drawing.Size(48, 24);
            this.learn_menu_next.Text = "Next";
            this.learn_menu_next.Click += new System.EventHandler(this.learn_menu_next_Click);
            // 
            // learn_menu_pre
            // 
            this.learn_menu_pre.Name = "learn_menu_pre";
            this.learn_menu_pre.Size = new System.Drawing.Size(39, 24);
            this.learn_menu_pre.Text = "Pre";
            this.learn_menu_pre.Click += new System.EventHandler(this.learn_menu_pre_Click);
            // 
            // learn_menu_random
            // 
            this.learn_menu_random.Name = "learn_menu_random";
            this.learn_menu_random.Size = new System.Drawing.Size(68, 24);
            this.learn_menu_random.Text = "Random";
            this.learn_menu_random.Click += new System.EventHandler(this.learn_menu_random_Click);
            // 
            // learn_word_panel
            // 
            this.learn_word_panel.Controls.Add(this.learn_word_table_panel);
            this.learn_word_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.learn_word_panel.Location = new System.Drawing.Point(0, 453);
            this.learn_word_panel.Margin = new System.Windows.Forms.Padding(0);
            this.learn_word_panel.Name = "learn_word_panel";
            this.learn_word_panel.Size = new System.Drawing.Size(776, 51);
            this.learn_word_panel.TabIndex = 1;
            // 
            // learn_word_table_panel
            // 
            this.learn_word_table_panel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.learn_word_table_panel.ColumnCount = 4;
            this.learn_word_table_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.learn_word_table_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.learn_word_table_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.learn_word_table_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.learn_word_table_panel.Controls.Add(this.learn_ch_word_text, 2, 0);
            this.learn_word_table_panel.Controls.Add(this.learn_jp2_word_text, 1, 0);
            this.learn_word_table_panel.Controls.Add(this.learn_jp_word_text, 0, 0);
            this.learn_word_table_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.learn_word_table_panel.Location = new System.Drawing.Point(0, 0);
            this.learn_word_table_panel.Margin = new System.Windows.Forms.Padding(0);
            this.learn_word_table_panel.Name = "learn_word_table_panel";
            this.learn_word_table_panel.RowCount = 2;
            this.learn_word_table_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.learn_word_table_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.learn_word_table_panel.Size = new System.Drawing.Size(776, 51);
            this.learn_word_table_panel.TabIndex = 0;
            // 
            // learn_ch_word_text
            // 
            this.learn_ch_word_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.learn_ch_word_text.Location = new System.Drawing.Point(388, 2);
            this.learn_ch_word_text.Margin = new System.Windows.Forms.Padding(0);
            this.learn_ch_word_text.Multiline = true;
            this.learn_ch_word_text.Name = "learn_ch_word_text";
            this.learn_ch_word_text.Size = new System.Drawing.Size(191, 22);
            this.learn_ch_word_text.TabIndex = 2;
            // 
            // learn_jp2_word_text
            // 
            this.learn_jp2_word_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.learn_jp2_word_text.Location = new System.Drawing.Point(195, 2);
            this.learn_jp2_word_text.Margin = new System.Windows.Forms.Padding(0);
            this.learn_jp2_word_text.Multiline = true;
            this.learn_jp2_word_text.Name = "learn_jp2_word_text";
            this.learn_jp2_word_text.Size = new System.Drawing.Size(191, 22);
            this.learn_jp2_word_text.TabIndex = 1;
            // 
            // learn_jp_word_text
            // 
            this.learn_jp_word_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.learn_jp_word_text.Location = new System.Drawing.Point(2, 2);
            this.learn_jp_word_text.Margin = new System.Windows.Forms.Padding(0);
            this.learn_jp_word_text.Multiline = true;
            this.learn_jp_word_text.Name = "learn_jp_word_text";
            this.learn_jp_word_text.Size = new System.Drawing.Size(191, 22);
            this.learn_jp_word_text.TabIndex = 0;
            // 
            // learn_word_list
            // 
            this.learn_word_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.learn_word_list.Location = new System.Drawing.Point(776, 0);
            this.learn_word_list.Margin = new System.Windows.Forms.Padding(0);
            this.learn_word_list.Name = "learn_word_list";
            this.learn_word_list.Size = new System.Drawing.Size(194, 504);
            this.learn_word_list.TabIndex = 1;
            this.learn_word_list.MouseDown += new System.Windows.Forms.MouseEventHandler(this.learn_word_list_MouseDown);
            // 
            // learn_example_text
            // 
            this.learn_example_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.learn_example_text.Location = new System.Drawing.Point(0, 300);
            this.learn_example_text.Margin = new System.Windows.Forms.Padding(0);
            this.learn_example_text.Name = "learn_example_text";
            this.learn_example_text.Size = new System.Drawing.Size(776, 129);
            this.learn_example_text.TabIndex = 2;
            this.learn_example_text.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.learn_book_text);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 300);
            this.panel1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookStore});
            this.menuStrip1.Location = new System.Drawing.Point(0, 274);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(776, 26);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bookStore
            // 
            this.bookStore.Name = "bookStore";
            this.bookStore.Size = new System.Drawing.Size(44, 22);
            this.bookStore.Text = "保存";
            this.bookStore.Click += new System.EventHandler(this.bookStore_Click);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.main_menu);
            this.MainMenuStrip = this.main_menu;
            this.Name = "main_form";
            this.Text = "総合管理";
            this.main_menu.ResumeLayout(false);
            this.main_menu.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.learnTab.ResumeLayout(false);
            this.learn_main_panel.ResumeLayout(false);
            this.learn_adm_panel.ResumeLayout(false);
            this.learn_example_panel.ResumeLayout(false);
            this.learn_example_panel.PerformLayout();
            this.learn_example_table_panel.ResumeLayout(false);
            this.learn_example_menu.ResumeLayout(false);
            this.learn_example_menu.PerformLayout();
            this.learn_word_panel.ResumeLayout(false);
            this.learn_word_table_panel.ResumeLayout(false);
            this.learn_word_table_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip main_menu;
        private System.Windows.Forms.ToolStripMenuItem 表示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 非表示ToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage learnTab;
        private System.Windows.Forms.TableLayoutPanel learn_adm_panel;
        private System.Windows.Forms.Panel learn_example_panel;
        private System.Windows.Forms.Panel learn_word_panel;
        private System.Windows.Forms.MenuStrip learn_example_menu;
        private System.Windows.Forms.ToolStripMenuItem learn_menu_modify;
        private System.Windows.Forms.TableLayoutPanel learn_word_table_panel;
        private System.Windows.Forms.TextBox learn_jp_word_text;
        private System.Windows.Forms.TextBox learn_jp2_word_text;
        private System.Windows.Forms.TextBox learn_ch_word_text;
        private System.Windows.Forms.ToolStripMenuItem learn_menu_add;
        private System.Windows.Forms.ToolStripMenuItem learn_menu_delete;
        private System.Windows.Forms.ToolStripMenuItem learn_menu_next;
        private System.Windows.Forms.ToolStripMenuItem learn_menu_pre;
        private System.Windows.Forms.ToolStripMenuItem learn_menu_random;
        private System.Windows.Forms.TableLayoutPanel learn_main_panel;
        private System.Windows.Forms.TreeView learn_word_list;
        private System.Windows.Forms.RichTextBox learn_book_text;
        private System.Windows.Forms.TableLayoutPanel learn_example_table_panel;
        private System.Windows.Forms.RichTextBox learn_example_text;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bookStore;
    }
}

