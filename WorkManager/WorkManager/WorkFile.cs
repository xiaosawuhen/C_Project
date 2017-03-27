using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WorkManager
{
    class WorkFile
    {
        public static string newProject(string name)
        {
            string directory = Info.config.BathPath + "\\" + name;

            Directory.CreateDirectory(directory);

            return directory;
        }
    }
}
