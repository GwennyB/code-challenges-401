using System;
using linked_list.Classes;

namespace DedupeLinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("original list: ");
            LinkedList testOne = BuildList(new int[] { 1, 3, 4, 1, 2, 5, 6 });
            Console.WriteLine("de-duped list: ");
            LLRemoveDupes(testOne).Print();

            Console.WriteLine("\noriginal list: (single node)");
            LinkedList testTwo = BuildList(new int[] { 1 });
            Console.WriteLine("de-duped list: ");
            LLRemoveDupes(testTwo).Print();

            Console.WriteLine("\noriginal list: (all dupes)");
            LinkedList testThree = BuildList(new int[] { 1,1,1,1,1 });
            Console.WriteLine("de-duped list: ");
            LLRemoveDupes(testThree).Print();

            Console.WriteLine("\noriginal list: (null)");
            LinkedList testFour = new LinkedList();
            Console.WriteLine("de-duped list: ");
            LLRemoveDupes(testFour).Print();

            Console.WriteLine("\nEND TESTS");
            Console.ReadLine();
        }

        /// <summary>
        /// locates and removes duplicate nodes from unsorted linked list
        /// </summary>
        /// <param name="list"> list to de-dupe </param>
        /// <returns> de-duped list </returns>
        public static LinkedList LLRemoveDupes (LinkedList list)
        {
            if (list.Head == null || list.Head.Next == null)
            {
                return list;
            }
            list.Current = list.Head;

            Node tempHead = new Node(0);
            tempHead.Next = list.Head;

            Node trailer = tempHead;

            Node temp = list.Current.Next;

            while (list.Current.Next != null)
            {
                while (temp != null)
                {
                    if (temp.Value != list.Current.Value)
                    {
                        temp = temp.Next;
                    }
                    else
                    {
                        if (list.Current == list.Head)
                        {
                            list.Head = list.Head.Next;
                        }
                        trailer.Next = list.Current.Next;
                        list.Current.Next = null;
                        list.Current = trailer.Next;
                        temp = list.Current.Next;
                    }
                }
                if (list.Current.Next != null)
                {
                    list.Current = list.Current.Next;
                    trailer = trailer.Next;
                    temp = list.Current.Next;
                }
            }

            return list;
        }

        /// <summary>
        /// builds test list from array of values
        /// </summary>
        /// <param name="vals"> values to place in list </param>
        /// <returns> linked list made of passed-in values </returns>
        private static LinkedList BuildList(int[] vals)
        {
            LinkedList list = new LinkedList();
            foreach (int val in vals)
            {
                list.Append(val);
            }
            list.Print();
            return list;
        }

    }
}
