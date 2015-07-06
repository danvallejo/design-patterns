using System;
using System.IO;

namespace ContactManager
{
    class Program
    {
        static void Main()
        {
            using (var logger = new Logger())
            {
                logger.WriteEntry(LoggerLevel.Informational, "Entering Main()");
            }

            var commands = new[] {
                "cd \\",
                "md test",
                "cd test",
                "create test.txt",
                "write test.txt 1234",
                "delete test.txt",
                "cd \\",
                "rd test"
            };

            foreach (var command in commands)
            {
                var pieces = command.Split(' ');

                if (command.StartsWith("cd"))
                {
                    Environment.CurrentDirectory = pieces[1];
                }
                else if (command.StartsWith("md"))
                {
                    Directory.CreateDirectory(pieces[1]);
                }
                else if (command.StartsWith("rd"))
                {
                    Directory.Delete(pieces[1]);
                }
                else if (command.StartsWith("create"))
                {
                    using (File.Create(pieces[1])) { }
                }
                else if (command.StartsWith("write"))
                {
                    using (var stream = File.Open(pieces[1], FileMode.Open))
                    using (var textwriter = new StreamWriter(stream))
                    {
                        textwriter.WriteLine(pieces[2]);
                    }
                }
                else if (command.StartsWith("delete"))
                {
                    File.Delete(pieces[1]);
                }
            }

            using (var logger = new Logger())
            {
                logger.WriteEntry(LoggerLevel.Informational, "Exiting Main()");
            }
        }
    }
}
