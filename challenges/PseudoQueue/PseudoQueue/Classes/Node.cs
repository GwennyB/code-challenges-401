using System;
using System.Collections.Generic;
using System.Text;

namespace PseudoQueue.Classes
{
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }

        /// <summary>
        /// Creates new node with specified
        /// </summary>
        /// <param name="value"></param>
        public Node(T value)
        {
            Value = value;
        }
    }
}
