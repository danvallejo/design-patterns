using System;

namespace observer_ex_solution
{
    /// <summary>
    /// Observer
    /// </summary>
    public interface IEmailUser
    {
        void Notify(MailServer email);
    }

    public class EmailUser : IEmailUser
    {
        private readonly string name;

        public EmailUser(string name)
        {
            this.name = name;
        }

        public void Notify(MailServer email)
        {
            Console.WriteLine("You've got mail {0}", name);
        }
    }
}