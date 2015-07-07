using System.IO;

namespace singleton_logger_ex_solution
{
    public class FileLogger
    {
        private static object sync = new object();
        private static FileLogger fileLogger = new FileLogger();

        private FileLogger()
        {
        }

        public static FileLogger Instance
        {
            get { return fileLogger; }
        }

        public static string FileName
        {
            get { return @".\filelogger.txt"; }
        }

        public void Log(string fmt, params object[] args)
        {
            lock (sync)
            {
                File.AppendAllText(FileName, string.Format(fmt, args) + "\n");
            }
        }
    }
}
