using System;

namespace mediator_ex_solution
{
    class Program
    {
        static void Main()
        {
            var outlookServer = new OutlookServer();

            var dave = new MailClient { Address = "dave@dave.com" };
            var lisa = new MailClient { Address = "lisa@lisa.com" };
            var mike = new MailClient { Address = "mike@mike.com" };

            outlookServer.Register(dave);
            outlookServer.Register(lisa);
            outlookServer.Register(mike);

            dave.Send("lisa@lisa.com", new MailMessage { Body = "hello lisa" });
            lisa.Send("dave@dave.com", new MailMessage { Body = "hi" });

            mike.Send("steve@steve.com", new MailMessage { Body = "can we meet?" });

            Console.ReadLine();
        }
    }
}
