using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace AllControl
{
    public class WelcomeControl
    {
        //private MenuStrip welcome_file_menu = null;
        //private TextBox welcome_file_text = null;
        //private WeclomeMenuControl WeclomeMenuControl = null;

        //public WelcomeControl(MenuStrip menuStrip, TextBox textBox)
        //{
           // this.welcome_file_menu = menuStrip;
            //this.welcome_file_text = textBox;
        //}

        public void load_welcome_menu(string filePath)
        {
            //WeclomeMenuControl = new WeclomeMenuControl(filePath);
            //foreach (ToolStripMenuItem menuItem in WeclomeMenuControl.get_welcome_menu_list(welcome_file_text))
            //{
             //   this.welcome_file_menu.Items.Add(menuItem);
            //}
        }
    }

    public class WeclomeMenuControl
    {
        private string filePath = null;
        private Hashtable nameTable = new Hashtable();
        private TextBox welcome_file_text = null;

        public WeclomeMenuControl(string path)
        {
            filePath = path;
        }

        public List<ToolStripMenuItem> get_welcome_menu_list(TextBox welcome_file_text)
        {
            this.welcome_file_text = welcome_file_text;
            List<ToolStripMenuItem> itemList = new List<ToolStripMenuItem>();

            string[] files = Directory.GetFiles(filePath);
            foreach (string file in files)
            {
                string name = Path.GetFileNameWithoutExtension(file);
                itemList.Add(create_welcome_menu_group(name));
                nameTable.Add(name, file);
            }

            return itemList;
        }

        private ToolStripMenuItem create_welcome_menu_group(string name)
        {
            ToolStripMenuItem mainMenu = create_welcome_menu(name,null);

            ToolStripMenuItem writeMenu = create_welcome_menu(name, "write");
            writeMenu.Click += new EventHandler(write_menu_click);



            ToolStripMenuItem readMenu = create_welcome_menu(name, "read");
            readMenu.Click += new EventHandler(read_menu_click);

            mainMenu.DropDownItems.Add(writeMenu);
            mainMenu.DropDownItems.Add(readMenu);

            return mainMenu;
        }

        private string currentMenuItem = null;
        private void write_menu_click(object sender, EventArgs e)
        {
            ToolStripMenuItem obj = (ToolStripMenuItem)sender;
            string itemName = obj.Name.Substring(0, obj.Name.Length - 13);
            if (currentMenuItem != null && itemName.Equals(currentMenuItem))
            {
                string file = (string)nameTable[currentMenuItem];

                string fileText = welcome_file_text.Text;
                File.WriteAllText(file,fileText);
            }
        }

        private void read_menu_click(object sender, EventArgs e)
        {
            ToolStripMenuItem obj = (ToolStripMenuItem)sender;
            currentMenuItem = obj.Name.Substring(0, obj.Name.Length-12);

            string file = (string)nameTable[currentMenuItem];

            string fileText = File.ReadAllText(file);
            welcome_file_text.Text = fileText;
        }

        private ToolStripMenuItem create_welcome_menu(string name,string type)
        {
            ToolStripMenuItem menuItem = new ToolStripMenuItem();

            // MainMenuItem
            if (type != null)
            {
                menuItem.Name = name + type + "MenuItem";
                menuItem.Text = type;
            }
            else
            {
                menuItem.Name = name + "MenuItem";
                menuItem.Text = name;
            }

            return menuItem;
        }
    }
}
