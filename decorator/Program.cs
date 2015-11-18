using System;

namespace decorator
{
    class Program
    {
        static void Main()
        {
            var book = new Book("Inside Design Patterns", "Smith");
            var video = new Video("Jaws", "Spielberg");

            var borrowableBook = new Borrowable(book);
            borrowableBook.BorrowItem("jane");
            borrowableBook.BorrowItem("mike");
            borrowableBook.Display();

            borrowableBook.ReturnItem("jane");
            borrowableBook.Display();


            var borrowableVideo = new Borrowable(video);
            borrowableVideo.BorrowItem("steve");
            borrowableVideo.BorrowItem("lisa");
            borrowableVideo.Display();

            // Alternative method for decorators
            var aDifferentBorrowableBook = book.WithBorrowable();
            aDifferentBorrowableBook.BorrowItem("steve");

            Console.ReadLine();
        }
    }
}
