﻿// File: SingletonThread.cs

using System;

namespace singleton_thread
{
    public class SingletonThread
    {
        private static SingletonThread singleton;

        private static object sync = new object();

        private SingletonThread()
        {
        }

        public static SingletonThread GetInstance()
        {
            if (singleton == null)
            {
                lock (sync)
                {
                    if (singleton == null)
                    {
                        singleton = new SingletonThread();
                    }
                }
            }
            return singleton;
        }
    }

    public class TestSingletonThread
    {
        static void Main()
        {
            SingletonThread one = SingletonThread.GetInstance();
            SingletonThread two = SingletonThread.GetInstance();
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
}