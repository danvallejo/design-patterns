using System;

namespace visitor_ex_solution
{
    /// The 'Visitor' interface
   public interface IVisitor
    {
        void Visit(FileSystemElement element);
    }

   public class ArchiveVisitor : IVisitor
    {
        public void Visit(FileSystemElement element)
        {
            Console.WriteLine("{0} archived", element.FileName);
        }
    }

   public class DeleteVisitor : IVisitor
    {
        public void Visit(FileSystemElement element)
        {
            Console.WriteLine("{0} deleted", element.FileName);
        }
    }
}
