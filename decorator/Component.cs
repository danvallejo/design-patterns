using System;

namespace decorator
{
    public abstract class LibraryItem
    {
        public string Name { get; set; }
        public abstract void Display();
    }

    public class Book : LibraryItem
    {
        public string Author { get; set; }

        public Book(string name, string author)
        {
            Name = name;
            Author = author;
        }

        public override void Display()
        {
            Console.WriteLine("Book---");
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Author: {0}", Author);
        }
    }

    public class Video : LibraryItem
    {
        public string Director { get; set; }

        public Video(string name, string director)
        {
            Name = name;
            Director = director;
        }

        public override void Display()
        {
            Console.WriteLine("Video---");
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Director: {0}", Director);
        }
    }
}
