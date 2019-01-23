using System;
using PseudoQueue.Classes;

namespace PseudoQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            PseudoQ<int> qu = new PseudoQ<int>();
            qu.Print();
            Console.ReadLine();
            qu.Enqueue(5);
            qu.Enqueue(4);
            qu.Enqueue(3);
            qu.Enqueue(2);
            qu.Enqueue(1);
            qu.Print();
            Console.ReadLine();

            qu.Dequeue();
            qu.Dequeue();
            qu.Print();
            Console.ReadLine();
        }
    }
}
