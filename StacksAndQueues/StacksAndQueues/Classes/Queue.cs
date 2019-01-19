using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    class Queue
    {
        public Node Front { get; set; }
        public Node Rear { get; set; }

        /// <summary>
        /// creates new queue and assigns the specified node as its only member (Front and Rear)
        /// </summary>
        /// <param name="node"> ref to the node to add to new queue </param>
        public Queue(Node node)
        {
            Front = node;
            Rear = node;
        }

        /// <summary>
        /// attaches a new node of specified value to the back of a queue, and assigns it as Rear
        /// </summary>
        /// <param name="value"> ref to the node to add to rear of queue </param>
        public void Enqueue(int value)
        {
            Node node = new Node(value);
            Rear.Next = node;
            Rear = node;
        }

        /// <summary>
        /// extracts/returns the node at the front of a queue, and assigns Front to next in line
        /// </summary>
        /// <returns> ref to the node extracted from front of queue </returns>
        public Node Dequeue()
        {
            Node temp = Front;
            Front = Front.Next;
            temp.Next = null;
            return temp;
        }

        /// <summary>
        /// reveals the front node in a queue
        /// </summary>
        /// <returns> ref to the front node in the queue </returns>
        public Node Peek()
        {
            return Front;
        }
    }
}
