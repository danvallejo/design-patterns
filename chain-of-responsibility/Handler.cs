using System;

namespace chain_of_responsibility
{
    public abstract class MessageHandler
    {
        public MessageHandler NextHandler { get; set; }

        public abstract void ProcessRequest(Message message);
    }

    public class MouseMoveHandler : MessageHandler
    {
        public override void ProcessRequest(Message message)
        {
            if (message.MessageType == MessageType.MouseMove)
            {
                Console.WriteLine("WM_MOUSEMOVE : X={0}, Y={1}", message.X, message.Y);
            }
            else if (NextHandler != null)
            {
                NextHandler.ProcessRequest(message);
            }
        }
    }

    public class MouseUpHandler : MessageHandler
    {
        public override void ProcessRequest(Message message)
        {
            if (message.MessageType == MessageType.MouseUp)
            {
                Console.WriteLine("WM_MOUSEUP : X={0}, Y={1}", message.X, message.Y);
            }
            else if (NextHandler != null)
            {
                NextHandler.ProcessRequest(message);
            }
        }
    }
}
