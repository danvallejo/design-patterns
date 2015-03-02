using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chain_of_responsibility
{
    class Program
    {
        static void Main()
        {
            var mouseMoveHandler = new MouseMoveHandler();
            var mouseUpHandler = new MouseUpHandler();

            mouseMoveHandler.NextHandler = mouseUpHandler;

            mouseMoveHandler.ProcessRequest(new Message
            {
                MessageType = MessageType.MouseUp,
                X = 1,
                Y = 2,
            });

            mouseMoveHandler.ProcessRequest(new Message
            {
                MessageType = MessageType.MouseMove,
                X = 2,
                Y = 3,
            });
        }
    }
}
