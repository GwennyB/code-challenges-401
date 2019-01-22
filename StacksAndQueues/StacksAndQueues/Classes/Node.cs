using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Node<T>
    {
        public T Value { get; set; }

        public Node<T> Next { get; set; }

        /// <summary>
        /// constructs new node of specified value, and points it into the ether
        /// </summary>
        /// <param name="value"> value to assign to the new node </param>
        public Node(T value)
        {
            Value = value;
            Next = null;
        }
    }
}
