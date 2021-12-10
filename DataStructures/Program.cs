using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World !");

            LinkedList list = new LinkedList();
            //list.Add(56);
            //list.Add(30);
            //list.Add(70);

            list.AddReverse(70);
            list.AddReverse(30);
            list.AddReverse(56); 
            list.Display();
        }
    }
}