using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace visitor_ex_solution
{
    /// <summary>
    /// ObjectStructure
    /// </summary>
    public class FileSystem
    {
        private List<FileSystemElement> fileSystemElements = new List<FileSystemElement>();

        public void Attach(FileSystemElement element)
        {
            fileSystemElements.Add(element);
        }

        public void Detach(FileSystemElement element)
        {
            fileSystemElements.Remove(element);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (var e in fileSystemElements)
            {
                e.Accept(visitor);
            }
        }
    }
}
