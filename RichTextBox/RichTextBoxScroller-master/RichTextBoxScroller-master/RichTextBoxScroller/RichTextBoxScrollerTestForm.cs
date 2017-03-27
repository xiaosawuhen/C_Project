using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace RichTextBoxScollerApplication
{
    public partial class RichTextBoxScrollerTestForm : Form
    {
        public RichTextBoxScrollerTestForm()
        {
            InitializeComponent();
            
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            richTest.Text = "";
        }

        private int _iCounter = 1;

        private void btAdd_Click(object sender, EventArgs e)
        {
            List<string> lstNewLines = new List<string>();
            for(int i = 1; i <= 25; i++)
            {
                lstNewLines.Add(_iCounter.ToString());
                _iCounter++;
            }
            richTest.AppendLines(lstNewLines);
        }

        const int _iMaxLines = 150;

        private void RichTextBoxScrollerTestForm_Load(object sender, EventArgs e)
        {
            richTest.SetMaxLines(_iMaxLines);
            lblMaxLines.Text = "Max number of lines: " + _iMaxLines;
            chkAutomaticallScrollToBottom.Checked = true;
        }

        private void chkAutomaticallScrollToBottom_CheckedChanged(object sender, EventArgs e)
        {
            richTest.SetAutomaticScrollToBottom(chkAutomaticallScrollToBottom.Checked);
        }

        private Thread _thread = null;

        private void btStart_Click(object sender, EventArgs e)
        {
            btStart.Enabled = false;
            Worker w = new Worker(richTest);
            _thread = new Thread(new ThreadStart(w.Run));
            _thread.Start();
        }

        private class Worker
        {
            private Controls.RichTextBoxScroller _r;
            public Worker(Controls.RichTextBoxScroller r)
            {
                _r = r;
            }

            public void Run()
            {
                Random random = new Random();
                while(true)
                {
                    int iNofItems = random.Next(0, 10);
                    List<string> lstLines = new List<string>();
                    for (int i = 0; i < iNofItems; i++)
                    {
                        lstLines.Add(random.Next(100, 1000).ToString());
                    }
                    _r.BeginInvoke((MethodInvoker)delegate { _r.AppendLines(lstLines); });
                    Thread.Sleep(1000);
                }
            }
        }

        private void RichTextBoxScrollerTestForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_thread != null)
            {
                _thread.Abort(); // Generally a bad idea, doesn't matter for this example program.
            }
        }

        private void richTest_TextChanged(object sender, EventArgs e)
        {
            lblCurrentLines.Text = "Current number of of lines: " + richTest.Lines.Length;
        }
    }
}
