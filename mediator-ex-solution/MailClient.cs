using System;

namespace mediator_ex_solution
{
   public class MailClient
    {
        public string Address { get; set; }
        public OutlookServer MailServer { get; set; }

        public void Send(string address, MailMessage mailMessage)
        {
            MailServer.Send(Address, address, mailMessage);
        }

        public virtual void Receive(string from, MailMessage mailMessage)
        {
            Console.WriteLine("{0} to {1}: {2}", from, Address, mailMessage.Body);
        }
    }
}
