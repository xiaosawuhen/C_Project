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

namespace WordControl
{
    class WordListMenuControl
    {
        private MenuStrip wordListMenu = null;

        public MenuStrip createMenuStrip(string name, string text)
        {
            wordListMenu = new MenuStrip();
            wordListMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            wordListMenu.Location = new System.Drawing.Point(0, 0);
            wordListMenu.Name = name;
            wordListMenu.Size = new System.Drawing.Size(44, 22);
            wordListMenu.TabIndex = 0;
            wordListMenu.Text = text;

            return wordListMenu;
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

        public ContextMenuStrip createContextMenuStrip()
        {
            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
            contextMenuStrip.BackColor = System.Drawing.Color.WhiteSmoke;
            contextMenuStrip.Size = new System.Drawing.Size(44, 22);

            contextMenuStrip.Items.Add(createToolItem("123","2345"));
            return contextMenuStrip;
        }

        public ToolStripItem createToolStripItem(string name, string text)
        {
            ToolStripItem item = new ToolStripMenuItem();
            item.BackColor = System.Drawing.Color.WhiteSmoke;
            item.Name = name;
            item.Size = new System.Drawing.Size(44, 22);
            item.Text = text;
            return item;
        }


        public MenuItem createItem(string name, string text)
        {
            MenuItem item = new MenuItem();
            item.Name = name;
            item.Text = text;
            return item;
        }

    }
}
