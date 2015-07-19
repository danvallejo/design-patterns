using System;

namespace visitor_ex_solution
{
    class Program
    {
        static void Main()
        {
            var fs = new FileSystem();

            fs.Attach(new FileElement("c:\\testOne.txt"));
            fs.Attach(new FileElement("c:\\testTwo.txt"));

            fs.Accept(new ArchiveVisitor()); // archives the file
            fs.Accept(new DeleteVisitor());  // deletes the file

            Console.ReadLine();
        }
    }
}
