// File: Singleton.cs
using System;

public class Singleton
{
    private static Singleton singleton;

    private Singleton()
    {
    }

    public static Singleton Instance
    {
        get
        {
            if (singleton == null)
            {
                singleton = new Singleton();
            }

            return singleton;
        }
    }
}

public class TestSingleton
{
    static void Main()
    {
        Singleton one = Singleton.Instance;

        Singleton two = Singleton.Instance;

        if (one == two)
        {
            Console.WriteLine("Singleton's are the same");
        }
        else
        {
            Console.WriteLine("ERROR: Created two different Singleton's");
        }

        Console.ReadLine();
    }
}