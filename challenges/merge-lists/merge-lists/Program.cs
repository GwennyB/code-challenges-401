using System;
using linked_list.Classes;

namespace merge_lists
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkedList mergedList = Merge(BuildList(4), BuildList(7));

            mergedList.Print();

            Console.ReadLine();
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

        static LinkedList Merge(LinkedList one, LinkedList two)
        {


        }


    }
}
