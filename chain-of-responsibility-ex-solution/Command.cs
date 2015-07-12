using System;
using System.IO;

namespace chain_of_responsibility_ex_solution
{
    public abstract class Command
    {
        public Command NextHandler { get; set; }

        public abstract void ProcessRequest(Message message);
    }

    public class ChangeDirectoryCommand : Command
    {
        public override void ProcessRequest(Message message)
        {
            if (message.CommandType == CommandType.ChangeDir)
            {
                Environment.CurrentDirectory = message.Arguments[0];
            }
            else if (NextHandler != null)
            {
                NextHandler.ProcessRequest(message);
            }
        }
    }

    public class CreateDirectoryCommand : Command
    {
        public override void ProcessRequest(Message message)
        {
            if (message.CommandType == CommandType.CreateDir)
            {
                Directory.CreateDirectory(message.Arguments[0]);
            }
            else if (NextHandler != null)
            {
                NextHandler.ProcessRequest(message);
            }
        }
    }

    public class RemoveDirectoryCommand : Command
    {
        public override void ProcessRequest(Message message)
        {
            if (message.CommandType == CommandType.RemoveDir)
            {
                Directory.Delete(message.Arguments[0]);
            }
            else if (NextHandler != null)
            {
                NextHandler.ProcessRequest(message);
            }
        }
    }

    public class CreateFileCommand : Command
    {
        public override void ProcessRequest(Message message)
        {
            if (message.CommandType == CommandType.CreateTextFile)
            {
                using (File.Create(message.Arguments[0])) { }
            }
            else if (NextHandler != null)
            {
                NextHandler.ProcessRequest(message);
            }
        }
    }

    public class WriteFileCommand : Command
    {
        public override void ProcessRequest(Message message)
        {
            if (message.CommandType == CommandType.WriteText)
            {
                using (var stream = File.Open(message.Arguments[0], FileMode.Open))
                using (var textwriter = new StreamWriter(stream))
                {
                    textwriter.WriteLine(message.Arguments[1]);
                }
            }
            else if (NextHandler != null)
            {
                NextHandler.ProcessRequest(message);
            }
        }
    }


    public class DeleteFileCommand : Command
    {
        public override void ProcessRequest(Message message)
        {
            if (message.CommandType == CommandType.DeleteFile)
            {
                File.Delete(message.Arguments[0]);
            }
            else if (NextHandler != null)
            {
                NextHandler.ProcessRequest(message);
            }
        }
    }
}