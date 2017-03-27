using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace WordControl
{
    public class Config
    {

        // 
        private string welcomePath = null;
        public string WelcomePath
        {
            get
            {
                return welcomePath;
            }
            set
            {
                this.welcomePath = value;
            }
        }

        private string wordPath = null;
        public string WordPath
        {
            get
            {
                return wordPath;
            }
            set
            {
                this.wordPath = value;
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
