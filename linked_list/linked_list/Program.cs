using linked_list.Classes;
using System;

namespace linked_list
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Insert(1);
            list.Print(list.Head);
            list.Insert(2);
            list.Print(list.Head);
            list.Insert(3);
            list.Print(list.Head);
            Console.ReadLine();
        }
    }
}
