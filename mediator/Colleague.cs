using System;

namespace mediator
{
    public class Participant
    {
        public Chatroom Chatroom { get; set; }
        public string Name { get; set; }

        public void Send(string to, string message)
        {
            Chatroom.Send(Name, to, message);
        }

        public virtual void Receive(string from, string message)
        {
            Console.WriteLine("{0} to {1}: {2}", from, Name, message);
        }
    }
}
