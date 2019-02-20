using System;
using System.Collections.Generic;
using System.Text;
using linked_list.Classes;

namespace StacksAndQueues.Classes
{
    public class Queue
    {
        public Node Front { get; set; }
        public Node Rear { get; set; }

        /// <summary>
        /// creates new empty queue and points Front and Rear into the ether
        /// </summary>
        public Queue()
        {
            Front = null;
            Rear = null;
        }
        
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
        public Node Enqueue(Object value)
        {
            Node node = new Node(value);
            if(Front == null)
            {
                Front = node;
                Rear = node;
            }
            else
            {
                Rear.Next = node;
                Rear = node;
            }
            return node;
        }

        /// <summary>
        /// extracts the node at the front of a queue, assigns Front to next in line,
        /// and returns the extracted node's value
        /// </summary>
        /// <returns> value of node extracted from front of queue </returns>
        public Object Dequeue()
        {
            Node temp = Front;
            Front = Front.Next;
            temp.Next = null;
            return temp.Value;
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
