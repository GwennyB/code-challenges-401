using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    class Stack
    {
        public Node Top { get; set; }

        /// <summary>
        /// constructs a new stack and puts the received node at its top
        /// </summary>
        /// <param name="node"> ref to node to add to new stack </param>
        public Stack(Node node)
        {
            Top = node;
        }

        /// <summary>
        /// constructs a new empty stack
        /// </summary>
        public Stack()
        {
            Top = null;
        }

        /// <summary>
        /// constructs a new node with a specified value and puts it at the top of the stack
        /// </summary>
        /// <param name="value"> new node's value </param>
        public void Push(int value)
        {
            Node node = new Node(value);
            node.Next = Top;
            Top = node;
        }

        /// <summary>
        /// extracts the top node from a stack and resets Top to the next node down
        /// </summary>
        /// <returns> ref to the extracted node </returns>
        public Node Pop()
        {
            Node temp = Top;
            Top = Top.Next;
            temp.Next = null;
            return temp;
        }

        /// <summary>
        /// reveals the top node in a stack
        /// </summary>
        /// <returns> ref to the top node in the stack </returns>
        public Node Peek()
        {
            return Top;
        }
    }
}
