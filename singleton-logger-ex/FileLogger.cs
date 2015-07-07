using System.IO;

namespace singleton_logger_ex
{
    public class FileLogger
    {
        public static FileLogger Instance
        {
            get
            {
                return new FileLogger();
            }
        }

        public static string FileName
        {
            get { return @".\filelogger.txt"; }
        }

        public void Log(string fmt, params object[] args)
        {
            File.AppendAllText(FileName, string.Format(fmt, args) + "\n");
        }
    }
}
