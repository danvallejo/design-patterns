using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chain_of_responsibility
{
    public enum MessageType
    {
        MouseMove,
        MouseUp,
        MouseDown,
        WindowMove,
        WindowResize,
    };

    public class Message
    {
        public MessageType MessageType { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public DateTime Time { get; set; }
    }
}
