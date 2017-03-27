using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace AllControl
{
    public class LibraryControl
    {
        private string libraryPath = null;

        private Hashtable libTable = new Hashtable();

        public LibraryControl(string path)
        {
            this.libraryPath = path;
        }

        public Hashtable getLibrarys()
        {
            bool pathExist = Directory.Exists(this.libraryPath);
            if (!pathExist)
            {
                return null;
            }

            string[] files = Directory.GetFiles(this.libraryPath);
            foreach (string filePath in files)
            {
                string fileType = Path.GetExtension(filePath);

                if (fileType.Equals(".dll"))
                {
                    Assembly assembly = Assembly.LoadFile(Path.GetFullPath(filePath));
                    Type type = assembly.GetType(Path.GetFileNameWithoutExtension(filePath) + ".main_form");
                    Type[] paramater = { };
                    MethodInfo info = type.GetRuntimeMethod("getTabPage", paramater);
                    object obj = assembly.CreateInstance(Path.GetFileNameWithoutExtension(filePath) + ".main_form");
                    TabPage tab = (TabPage)info.Invoke(obj, paramater);
                    libTable.Add(tab.Text, tab);
                }

            }
            return libTable;
        }
    }
}
