using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace WorkManager
{
    public class Config
    {
        private string bathPath = null;
        public string BathPath
        {
            get
            {
                return this.bathPath;
            }

            set
            {
                this.bathPath = value;
            }

        }

        private WorkInfo workInfo = null;
        public WorkInfo WorkInfo
        {
            get
            {
                return this.workInfo;
            }

            set
            {
                this.workInfo = value;
            }
        }

    }

    public class WorkInfo
    {
        private string infoName = null;
        public string InfoName
        {
            get
            {
                return this.infoName;
            }

            set
            {
                this.infoName = value;
            }

        }

        private string resultName = null;
        public string ResultName
        {
            get
            {
                return this.resultName;
            }

            set
            {
                this.resultName = value;
            }

        }

        private string workSpaceName = null;
        public string WorkSpaceName
        {
            get
            {
                return this.workSpaceName;
            }

            set
            {
                this.workSpaceName = value;
            }

        }

        private string managerName = null;
        public string ManagerName
        {
            get
            {
                return this.managerName;
            }

            set
            {
                this.managerName = value;
            }

        }
    }


    public class ConfigIO
    {
        public static void setConfig(Config config, string path)
        {
            FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate);
            XmlSerializer XmlSerializer = new XmlSerializer(config.GetType());

            XmlSerializer.Serialize(fileStream, config);

            fileStream.Close();
            fileStream.Dispose();
        }

        public static Config getConfig(string path)
        {
            FileStream fileStream = new FileStream(path, FileMode.Open);
            XmlSerializer XmlSerializer = new XmlSerializer(typeof(Config));

            Config config = (Config)XmlSerializer.Deserialize(fileStream);

            fileStream.Close();
            fileStream.Dispose();
            return config;
        }
    }
}
