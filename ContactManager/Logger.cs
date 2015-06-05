using System;
using System.IO;

namespace ContactManager
{
    public class Logger : IDisposable
    {
        private TextWriter textWriter;

        public Logger()
        {
            OpenFile();
        }

        private void OpenFile()
        {
            textWriter = File.CreateText("Logger.txt");
        }

        public void Dispose()
        {
            CloseFile();
        }

        private void CloseFile()
        {
            textWriter.Close();
        }

        public void WriteEntry(LoggerLevel level, string format, params object[] args)
        {
            var now = DateTime.Now.ToLongTimeString();

            var message = string.Format(format, args);

            textWriter.WriteLine("[{0}] {1} {2}", now, level, message);
            textWriter.Flush();
        }
    }
}
