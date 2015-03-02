using System;

namespace mediator
{
    class Program
    {
        static void Main()
        {
            var chatroom = new Chatroom();

            var dave = new Participant { Name = "dave" };
            var lisa = new Participant { Name = "lisa" };
            var mike = new Participant { Name = "mike" };

            chatroom.Register(dave);
            chatroom.Register(lisa);
            chatroom.Register(mike);

            dave.Send("lisa", "hello lisa");
            lisa.Send("dave", "hi");

            mike.Send("dave", "can we meet?");

            Console.ReadLine();
        }
    }
}
