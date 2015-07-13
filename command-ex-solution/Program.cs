using System;
using System.Collections.Generic;

namespace command_ex_solution
{
    class Program
    {
        static void Main()
        {
            var receiver = new PrintServer();

            var command = new PrintWordDocJob(receiver, "Word.doc");

            var invoker = new Client();
            invoker.AddJob(command);

            invoker.Print();

            Console.ReadLine();
        }
    }

    /// <summary>
    /// The 'Receiver' class
    /// </summary>
    class PrintServer
    {
        public void Action(string fileName)
        {
            Console.WriteLine("Called Receiver.Action({0})", fileName);
        }
    }

    /// <summary>
    /// The 'Command' abstract class
    /// </summary>
    abstract class Job
    {
        protected PrintServer receiver;

        // Constructor
        protected Job(PrintServer receiver)
        {
            this.receiver = receiver;
        }

        public abstract void Execute();
    }

    /// <summary>
    /// The 'ConcreteCommand' class
    /// </summary>
    class PrintWordDocJob : Job
    {
        private readonly string fileName;
        
        public PrintWordDocJob(PrintServer receiver, string fileName) :
            base(receiver)
        {
            this.fileName = fileName;
        }

        public override void Execute()
        {
            receiver.Action(fileName);
        }
    }

    /// <summary>
    /// The 'Invoker' class
    /// </summary>
    class Client
    {
        private readonly List<Job> jobs;

        public void AddJob(Job job)
        {
            jobs.Add(job);
        }

        public void Print()
        {
            foreach (var job in jobs)
            {
                job.Execute();
            }
        }
    }
}
