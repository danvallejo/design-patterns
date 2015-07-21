using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decorator
{
    public static class Extensions
    {
        public static Borrowable WithBorrowable(this LibraryItem libraryItem)
        {
            return new Borrowable(libraryItem);
        }
    }
}
