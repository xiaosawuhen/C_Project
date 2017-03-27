namespace RichTextBoxScollerApplication
{
    partial class RichTextBoxScrollerTestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btAdd = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.chkAutomaticallScrollToBottom = new System.Windows.Forms.CheckBox();
            this.lblCurrentLines = new System.Windows.Forms.Label();
            this.lblMaxLines = new System.Windows.Forms.Label();
            this.richTest = new Controls.RichTextBoxScroller();
            this.SuspendLayout();
            // 
            // btAdd
            // 
            this.btAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAdd.Location = new System.Drawing.Point(168, 12);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(106, 23);
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "&Add lines";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btStart
            // 
            this.btStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btStart.Location = new System.Drawing.Point(168, 41);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(106, 23);
            this.btStart.TabIndex = 2;
            this.btStart.Text = "&Start random adds";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btClear
            // 
            this.btClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btClear.Location = new System.Drawing.Point(168, 70);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(106, 23);
            this.btClear.TabIndex = 3;
            this.btClear.Text = "&Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // chkAutomaticallScrollToBottom
            // 
            this.chkAutomaticallScrollToBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAutomaticallScrollToBottom.AutoSize = true;
            this.chkAutomaticallScrollToBottom.Location = new System.Drawing.Point(168, 99);
            this.chkAutomaticallScrollToBottom.Name = "chkAutomaticallScrollToBottom";
            this.chkAutomaticallScrollToBottom.Size = new System.Drawing.Size(162, 17);
            this.chkAutomaticallScrollToBottom.TabIndex = 4;
            this.chkAutomaticallScrollToBottom.Text = "Automatically scroll to bottom";
            this.chkAutomaticallScrollToBottom.UseVisualStyleBackColor = true;
            this.chkAutomaticallScrollToBottom.CheckedChanged += new System.EventHandler(this.chkAutomaticallScrollToBottom_CheckedChanged);
            // 
            // lblCurrentLines
            // 
            this.lblCurrentLines.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentLines.AutoSize = true;
            this.lblCurrentLines.Location = new System.Drawing.Point(165, 152);
            this.lblCurrentLines.Name = "lblCurrentLines";
            this.lblCurrentLines.Size = new System.Drawing.Size(127, 13);
            this.lblCurrentLines.TabIndex = 6;
            this.lblCurrentLines.Text = "Current number of lines: 0";
            // 
            // lblMaxLines
            // 
            this.lblMaxLines.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaxLines.AutoSize = true;
            this.lblMaxLines.Location = new System.Drawing.Point(165, 129);
            this.lblMaxLines.Name = "lblMaxLines";
            this.lblMaxLines.Size = new System.Drawing.Size(125, 13);
            this.lblMaxLines.TabIndex = 7;
            this.lblMaxLines.Text = "Max number of lines: 150";
            // 
            // richTest
            // 
            this.richTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTest.Location = new System.Drawing.Point(12, 12);
            this.richTest.Name = "richTest";
            this.richTest.Size = new System.Drawing.Size(150, 370);
            this.richTest.TabIndex = 5;
            this.richTest.Text = "";
            this.richTest.TextChanged += new System.EventHandler(this.richTest_TextChanged);
            // 
            // RichTextBoxScrollerTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 394);
            this.Controls.Add(this.lblMaxLines);
            this.Controls.Add(this.lblCurrentLines);
            this.Controls.Add(this.richTest);
            this.Controls.Add(this.chkAutomaticallScrollToBottom);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.btAdd);
            this.Name = "RichTextBoxScrollerTestForm";
            this.Text = "RichTextBoxScroller test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RichTextBoxScrollerTestForm_FormClosing);
            this.Load += new System.EventHandler(this.RichTextBoxScrollerTestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.CheckBox chkAutomaticallScrollToBottom;
        private Controls.RichTextBoxScroller richTest;
        private System.Windows.Forms.Label lblCurrentLines;
        private System.Windows.Forms.Label lblMaxLines;
    }
}

