using linked_list.Classes;
using System;

namespace linked_list
{
    class Program
    {
        static void Main(string[] args)
        {
            TestTheList();
        }

        static void TestTheList()
        {
            LinkedList list = new LinkedList();
            list.Insert(8);
            list.Insert(4);
            list.Insert(5);
            list.InsertAfter(5, 99);
            //list.InsertBefore(2, 888);
            list.Print();
            //testList.Append(88);

            //LinkedList testList = new LinkedList();
            //int[] testPoints = new int[] { 5, 4, 3, 2, 1 };
            //foreach (int point in testPoints)
            //{
            //    testList.Insert(point);
            //}

            //testList.Print();

            //int kthFromEndValue = testList.FindFromEnd(2);
            //Console.WriteLine($"2 nodes from end: {kthFromEndValue}");

            //kthFromEndValue = testList.FindFromEnd(4);
            //Console.WriteLine($"4 nodes from end: {kthFromEndValue}");

            //kthFromEndValue = testList.FindFromEnd(5);
            //Console.WriteLine($"5 nodes from end: {kthFromEndValue}");

            //kthFromEndValue = testList.FindFromEnd(6);
            //Console.WriteLine($"6 nodes from end: {kthFromEndValue}");

            Console.ReadLine();
        }
    }
}
