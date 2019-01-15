using System;
using System.Collections.Generic;
using System.Text;

namespace linked_list.Classes
{
    public class LinkedList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }

        /// <summary>
        /// Instantiates and inserts a new node into an existing linked list.
        /// New node becomes 'head'.
        /// </summary>
        /// <param name="value"> value assigned to the new node </param>
        public void Insert(int value)
        {
            Node node = new Node(value);
            node.Next = Head;
            Head = node;
        }

        /// <summary>
        /// Checks whether a specified value matches any node in an existing linked list.
        /// Prints the value of each node as it's checked.
        /// </summary>
        /// <param name="value"> value to find in linked list </param>
        /// <returns></returns>
        public bool Includes(int value)
        {
            if (Head != null)
            {
                Current = Head;

                while (Current.Next != null)
                {
                    if (Current.Value == value)
                    {
                        Print();
                        return true;
                    }
                    Current = Current.Next;
                }
                if (Current.Value == value)
                {
                    return true;
                }
                Print();
            }
            return false;
        }

        /// <summary>
        /// Prints the values of all nodes in a linked list
        /// </summary>
        public void Print()
        {
            if (Head != null)
            {
                Current = Head;
                Console.Write($"{ Current.Value } => ");
                while (Current.Next != null)
                {
                    Current = Current.Next;
                    Console.Write($"{ Current.Value } => ");
                }
                Console.Write("Null");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("List is empty");
                Console.ReadLine();
            }
        }

    }
}
