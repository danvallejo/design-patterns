using System;

namespace decorator
{
    class Program
    {
        static void Main()
        {
            var book = new Book("Inside Design Patterns", "Smith");
            var video = new Video("Jaws", "Benchley");

            var borrowableBook = new Borrowable(book);
            borrowableBook.BorrowItem("jane");
            borrowableBook.BorrowItem("mike");
            borrowableBook.Display();

            var borrowableVideo = new Borrowable(video);
            borrowableVideo.BorrowItem("steve");
            borrowableVideo.BorrowItem("lisa");
            borrowableVideo.Display();

            Console.ReadLine();
        }
    }
}
