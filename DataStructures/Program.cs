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
            int search = list.Search(30);
            Console.WriteLine(search);
            



        //    list.RemoveFirstNode();
        //    list.RemoveLastNode();
        //    Console.WriteLine("After removing is : ");
        //    list.InsertAtParticularPosition(2, 30);
        }
    }
}


