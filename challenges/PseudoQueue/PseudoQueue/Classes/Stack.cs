using System;
using System.Collections.Generic;
using System.Text;

namespace PseudoQueue.Classes
{
    class Stack<T>
    {
        public Node<T> Top { get; set; }

        /// <summary>
        /// constructs new empty Stack
        /// </summary>
        public Stack()
        {
            Top = null;
        }

        /// <summary>
        /// Adds a new node of specified value to the top of the stack, and
        /// reassigns Top to the new node
        /// </summary>
        /// <param name="value"> value of new node </param>
        public void Push(T value)
        {
            Node<T> node = new Node<T>(value);
            node.Next = Top;
            Top = node;
        }

        /// <summary>
        /// Removes the top node from the stack,
        /// reassigns Top to the next in line, and
        /// returns the removed node
        /// </summary>
        /// <returns> removed node </returns>
        public Node<T> Pop()
        {
            Node<T> node = Top;
            try
            {
                Top = Top.Next;
            }
            catch (Exception)
            {
                Console.WriteLine("Exception: Queue is empty.");
            }
            node.Next = null;
            return node;
        }

        /// <summary>
        /// Returns ref to Top node in stack
        /// </summary>
        /// <returns> ref to Top of stack </returns>
        public Node<T> Peek()
        {
            try
            {
                return Top;
            }
            catch
            {
                Console.WriteLine("Exception: Queue is empty.");
                throw;
            }
        }

    }
}
