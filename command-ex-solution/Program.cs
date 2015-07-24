using System;
using System.Collections.Generic;

namespace command_ex_solution
{
    class Program
    {
        static void Main()
        {
            var receiver = new PrintServer();
            var mailer = new MailServer();

            var command = new DocJob(receiver, "Word.doc");
            var command2 = new DocJob(mailer, "Word.doc");

            var invoker = new ActionQueue();
            invoker.AddJob(command);
            invoker.AddJob(command2);

            invoker.PerformJobs();

            Console.ReadLine();
        }
    }

    public interface IActionable
    {
        void DoAction(string fileName);
    }

    /// <summary>
    /// The 'Receiver' class
    /// </summary>
    class PrintServer : IActionable
    {
        public void DoAction(string fileName)
        {
            Console.WriteLine("Called PrintServer.Action({0})", fileName);
        }
    }

    class MailServer : IActionable
    {
        public void DoAction(string fileName)
        {
            Console.WriteLine("Called MailServer.Action({0})", fileName);

        }
    }

    /// <summary>
    /// The 'Command' abstract class
    /// </summary>
    abstract class Job
    {
        protected IActionable receiver;

        // Constructor
        protected Job(IActionable receiver)
        {
            this.receiver = receiver;
        }

        public abstract void Execute();
    }

    /// <summary>
    /// The 'ConcreteCommand' class
    /// </summary>
    class DocJob : Job
    {
        private readonly string fileName;

        public DocJob(IActionable receiver, string fileName) :
            base(receiver)
        {
            this.fileName = fileName;
        }

        public override void Execute()
        {
            receiver.DoAction(fileName);
        }
    }

    /// <summary>
    /// The 'Invoker' class
    /// </summary>
    class ActionQueue
    {
        private readonly List<Job> jobs = new List<Job>();

        public void AddJob(Job job)
        {
            jobs.Add(job);
        }

        public void PerformJobs()
        {
            foreach (var job in jobs)
            {
                job.Execute();
            }
        }
    }
}
