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
using System.Collections;

namespace AllControl
{
    public partial class main_form : Form
    {
        Config config = null;
        private string basePath = "config\\base.xml";

        private WelcomeControl welcomeControl = null;
        private LibraryControl libraryControl = null;
        private FileViewControl fileViewControl = null;

        public main_form()
        {
            InitializeComponent();

            config = ConfigIO.getConfig(basePath);

            welcomeControl = new WelcomeControl();
            //welcomeControl.load_welcome_menu(config.WelcomePath);

            libraryControl = new LibraryControl("config\\lib");
            Hashtable libTable = libraryControl.getLibrarys();
            ICollection keys =  libTable.Keys;
            foreach (string key in keys)
            {
                this.tabControl.TabPages.Add((TabPage)libTable[key]);
            }

            fileViewControl = new FileViewControl(this.fileView);
            fileViewControl.initialize();

            //config = new Config();
            //config.WelcomePath = "config\\welcome\\";
            //config.WordPath = "config\\word\\";
            //ConfigIO.setConfig(config, basePath);
        }
    }
}
