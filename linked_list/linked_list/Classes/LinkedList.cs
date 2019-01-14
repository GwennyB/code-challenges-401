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
            Current = Head;
 
            while (Current.Next != null)
            {
                Print(Current);
                if (Current.Value == value)
                {
                    return true;
                }
                Current = Current.Next;
            }
            Print(Current);
            if (Current.Value == value)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Prints the value of a specified node
        /// </summary>
        /// <param name="node"> node whose value is to be printed </param>
        public void Print(Node node)
        {
            Console.Write($"{node.Value} => ");
        }

    }
}
