using System;
using System.Collections.Generic;

namespace decorator
{
    public abstract class Decorator :LibraryItem
    {
        protected LibraryItem libraryItem;

        public Decorator(LibraryItem libraryItem)
        {
            this.libraryItem = libraryItem;
        }

        public override void Display()
        {
            libraryItem.Display();
        }
    }

    public class Borrowable : Decorator
    {
        protected List<string> borrowers = new List<string>();

        public Borrowable(LibraryItem libraryItem) : base(libraryItem)
        {
        }

        public void BorrowItem(string name)
        {
            borrowers.Add(name);
        }

        public void ReturnItem(string name)
        {
            borrowers.Remove(name);
        }

        public override void Display()
        {
            base.Display();

            foreach (string borrower in borrowers)
            {
                Console.WriteLine(" Borrower: " + borrower);
            }
        }
    }
}
