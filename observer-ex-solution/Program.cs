using System;

namespace observer_ex_solution
{
    class Program
    {
        static void Main()
        {
            var mailServer = new Outlook();

            var dan = new EmailUser("dan");
            var mike = new EmailUser("mike");

            mailServer.Attach(dan);
            mailServer.Attach(mike);

            mailServer.CheckForEmail();
            mailServer.CheckForEmail();

            mailServer.Detach(dan);

            mailServer.CheckForEmail();

            Console.ReadLine();
        }
    }
}
