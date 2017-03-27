using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleLogs
{
    public partial class Form1 : Form, ILog
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region ILog interfeice
        
        public void WriteLine(string entry)
        {
            richTextBox1.Invoke((Action)(() =>
                {
                    richTextBox1.AppendText(entry + Environment.NewLine);
                    richTextBox1.ScrollToCaret();
                }
                ));
        }

        #endregion

        private void button_execute_Click(object sender, EventArgs e)
        {
            Log.WriteLine("Ты нажал на кнопку!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Log.AddReader(this);
            Log.WriteLine("Log loaded");
        }
    }
}
