using System.Collections.Generic;

namespace observer_ex_solution
{
    /// <summary>
    /// Subject class
    /// </summary>
    public class MailServer
    {
        private readonly List<IEmailUser> emailUsers = new List<IEmailUser>();

        public void Attach(IEmailUser emailUser)
        {
            emailUsers.Add(emailUser);
        }

        public void Detach(IEmailUser emailUser)
        {
            emailUsers.Remove(emailUser);
        }

        public void Notify()
        {
            foreach (var user in emailUsers)
            {
                user.Notify(this);
            }
        }

        public void CheckForEmail()
        {
            Notify();
        }
    }

    public class Outlook : MailServer
    {

    }
}