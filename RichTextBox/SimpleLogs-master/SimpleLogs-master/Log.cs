using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLogs
{
    public static class Log
    {
        private static LinkedList<ILog> LogReaders = new LinkedList<ILog>();
        private static LinkedList<string> LogContent = new LinkedList<string>();

        public static void WriteLine(string text, params object[] arg)
        {
            var entry = string.Format("[{0}] {1}", DateTime.Now.ToString("HH:mm:ss"), string.Format(text, arg));
            LogContent.AddLast(entry);

            foreach (var LogReader in LogReaders)
                LogReader.WriteLine(entry);
        }

        public static void AddReader(ILog LogReader)
        {
            LogReaders.AddLast(LogReader);
        }
    }

    public interface ILog
    {
        void WriteLine(string line);
    }
}
