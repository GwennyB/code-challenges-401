using System;
using linked_list.Classes;

namespace merge_lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("\nLists are same length:\n");
            Console.ReadLine();
            DemoCase(4, 4);
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("\nList A longer than List B:\n");
            Console.ReadLine();
            DemoCase(5, 3);
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("\nList A shorter than List B:\n");
            Console.ReadLine();
            DemoCase(3, 5);
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("\nList A empty:\n");
            Console.ReadLine();
            DemoCase(0, 4);
            Console.ReadLine();

            Console.Clear();
            Console.ReadLine();
            Console.WriteLine("\nList B empty:\n");
            DemoCase(4, 0);
            Console.ReadLine();

            Console.Clear();
            Console.ReadLine();
            Console.WriteLine("\nBoth lists empty:\n");
            DemoCase(0, 0);
            Console.ReadLine();
        }

        static LinkedList Merge(LinkedList one, LinkedList two)
        {
            // edge cases: at least one list is empty
            if (one.Head == null)
            {
                one = two;
                return one;
            }
            if (two.Head == null)
            {
                return one;
            }

            // reset currents
            one.Current = one.Head;
            two.Current = two.Head;

            // move nodes until last node is reached on one list
            while (one.Current.Next != null && two.Current.Next != null)
            {
                two.Head = two.Head.Next;
                two.Current.Next = one.Current.Next;
                one.Current.Next = two.Current;
                two.Current = two.Head;
                one.Current = one.Current.Next.Next;
            }

            // move last node
            // if 'one' was shorter than 'two':
            if (one.Current.Next == null)
            {
                one.Current.Next = two.Head;
                return one;
            }
            //if 'two' was shorter than 'one'
            two.Current.Next = one.Current.Next;
            one.Current.Next = two.Head;
            two.Head = null;
            return one;
        }

        static LinkedList BuildList(int numNodes)
        {
            LinkedList list = new LinkedList();
            Random rnd = new Random();
            for (int i = 0; i < numNodes; i++)
            {
                list.Insert(rnd.Next(-100, 100));
            }
            return list;
        }

        static void DemoCase(int oneLength, int twoLength)
        {
            LinkedList one = BuildList(oneLength);
            LinkedList two = BuildList(twoLength);
            Console.Write("List A: ");
            one.Print();
            Console.Write("List B: ");
            two.Print();
            Console.Write("Merged: ");
            Merge(one, two).Print();
        }


    }
}
