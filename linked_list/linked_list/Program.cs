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
            //LinkedList list = new LinkedList();
            //list.Insert(1);
            //list.Insert(2);
            //list.Insert(3);
            //list.InsertAfter(2, 999);
            //list.InsertBefore(2, 888);
            //list.Print();

            LinkedList testList = new LinkedList();
            int[] testPoints = new int[] { 0, 1, 100, -1, -100 };
            foreach (int point in testPoints)
            {
                testList.Insert(point);
            }
            testList.Append(88);
            while (testList.Current.Next != null)
            {
                testList.Current = testList.Current.Next;
            }
            testList.Print();

            int kthFromEndValue = testList.FindFromEnd(3);
            Console.WriteLine($"3 nodes from end: {kthFromEndValue}");
            Console.ReadLine();
        }
    }
}
