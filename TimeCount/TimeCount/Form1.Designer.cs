namespace TimeCount
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.start = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.clockTime = new System.Windows.Forms.TextBox();
            this.hour = new System.Windows.Forms.TextBox();
            this.minute = new System.Windows.Forms.TextBox();
            this.second = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.second);
            this.panel1.Controls.Add(this.minute);
            this.panel1.Controls.Add(this.hour);
            this.panel1.Controls.Add(this.clockTime);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.start);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 123);
            this.panel1.TabIndex = 0;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(45, 88);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 0;
            this.start.Text = "开始";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(187, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "结束";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // clockTime
            // 
            this.clockTime.Location = new System.Drawing.Point(100, 12);
            this.clockTime.Name = "clockTime";
            this.clockTime.Size = new System.Drawing.Size(107, 19);
            this.clockTime.TabIndex = 2;
            // 
            // hour
            // 
            this.hour.Location = new System.Drawing.Point(12, 52);
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(75, 19);
            this.hour.TabIndex = 3;
            // 
            // minute
            // 
            this.minute.Location = new System.Drawing.Point(116, 52);
            this.minute.Name = "minute";
            this.minute.Size = new System.Drawing.Size(75, 19);
            this.minute.TabIndex = 4;
            // 
            // second
            // 
            this.second.Location = new System.Drawing.Point(222, 52);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(75, 19);
            this.second.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 123);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox second;
        private System.Windows.Forms.TextBox minute;
        private System.Windows.Forms.TextBox hour;
        private System.Windows.Forms.TextBox clockTime;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button start;
    }
}

