using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SEARCH OPERATIONS !");

            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.RemoveFirstNode();
          
            Console.WriteLine("After removing is : ");
            list.Display();

            //list.InsertAtParticularPosition(2, 30);
        }
    }
}