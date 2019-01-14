using System;
using System.Collections.Generic;
using System.Text;

namespace linked_list.Classes
{
    class LinkedList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }

        public void Insert(int value)
        {
            Node node = new Node(value);
            node.Next = Head;
            Head = node;
        }

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

        public void Print(Node node)
        {
            Console.Write($"{node.Value} => ");
        }

    }
}
