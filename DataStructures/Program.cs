using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World !");

            LinkedList list = new LinkedList();
            list.Appending(56);
            list.Appending(30);
            list.Appending(70);
            list.Display();
        }
    }
}