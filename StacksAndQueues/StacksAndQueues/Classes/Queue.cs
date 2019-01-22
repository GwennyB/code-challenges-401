using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Queue<T>
    {
        public Node<T> Front { get; set; }
        public Node<T> Rear { get; set; }

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
        public Queue(Node<T> node)
        {
            Front = node;
            Rear = node;
        }

        /// <summary>
        /// attaches a new node of specified value to the back of a queue, and assigns it as Rear
        /// </summary>
        /// <param name="value"> ref to the node to add to rear of queue </param>
        public Node<T> Enqueue(T value)
        {
            Node<T> node = new Node<T>(value);
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
        public T Dequeue()
        {
            Node<T> temp = Front;
            Front = Front.Next;
            temp.Next = null;
            return temp.Value;
        }

        /// <summary>
        /// reveals the front node in a queue
        /// </summary>
        /// <returns> ref to the front node in the queue </returns>
        public Node<T> Peek()
        {
            return Front;
        }
    }
}
