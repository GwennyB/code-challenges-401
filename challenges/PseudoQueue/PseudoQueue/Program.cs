using System;
using PseudoQueue.Classes;

namespace PseudoQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nBuild queue to challenge example.");
            PseudoQ<int> qu = new PseudoQ<int>();
            qu.Enqueue(20);
            qu.Enqueue(15);
            qu.Enqueue(10);
            qu.Print();
            Console.ReadLine();
            Console.Write("Adding 5 to the rear of the queue: ");
            qu.Enqueue(5);
            qu.Print();
            Console.ReadLine();
            qu.Dequeue();
            qu.Dequeue();
            qu.Dequeue();
            qu.Dequeue();

            Console.WriteLine("\nQueue reset.");
            qu.Enqueue(20);
            qu.Enqueue(15);
            qu.Enqueue(10);
            qu.Enqueue(5);
            qu.Print();
            Console.ReadLine();
            Console.Write($"Removed: {qu.Dequeue().Value}; New queue: ");
            qu.Print();
            Console.ReadLine();

        }
    }
}
