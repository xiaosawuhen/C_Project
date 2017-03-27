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
    public partial class WorkNameForm : Form
    {
        public WorkNameForm()
        {
            InitializeComponent();
        }

        public string getName()
        {
            return this.textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = this.textBox1.Text;

            if (name == null || name.Equals(""))
            {
                MessageBox.Show("不能为空");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
