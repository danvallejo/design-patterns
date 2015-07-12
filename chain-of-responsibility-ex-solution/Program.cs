using System;
using System.IO;

namespace chain_of_responsibility_ex_solution
{
    class Program
    {
        static void Main()
        {
            var xcommands = new[] {
                "cd \\",
                "md test",
                "cd test",
                "create test.txt",
                "write test.txt 1234",
                "delete test.txt",
                "cd \\",
                "rd test"
            };

            var commandMessages = new Message[]
            {
                new Message{CommandType = CommandType.ChangeDir, Arguments=new []{"\\"}},
                new Message{CommandType = CommandType.CreateDir, Arguments=new []{"test"}},
                new Message{CommandType = CommandType.ChangeDir, Arguments=new []{"test"}},
                new Message{CommandType = CommandType.CreateTextFile, Arguments=new []{"test.txt"}},
                new Message{CommandType = CommandType.WriteText, Arguments=new []{"test.txt", "1234"}},
                new Message{CommandType = CommandType.DeleteFile, Arguments=new []{"test.txt"}},
                new Message{CommandType = CommandType.ChangeDir, Arguments=new []{"\\"}},
                new Message{CommandType = CommandType.RemoveDir, Arguments=new []{"test"}},
            };

            var commandChain = new CreateDirectoryCommand
            {
                NextHandler = new ChangeDirectoryCommand
                {
                    NextHandler = new RemoveDirectoryCommand
                    {
                        NextHandler = new CreateFileCommand
                        {
                            NextHandler = new WriteFileCommand
                            {
                                NextHandler = new DeleteFileCommand()
                            }
                        }
                    }
                }
            };

            foreach (var message in commandMessages)
            {
                commandChain.ProcessRequest(message);
            }
        }
    }
}

