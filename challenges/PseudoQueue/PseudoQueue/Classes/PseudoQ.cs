using System;
using System.Collections.Generic;
using System.Text;

namespace PseudoQueue.Classes
{
    public class PseudoQ<T>
    {
        // backing stores
        private Node<T> _garbageNode;

        // properties
        public Node<T> Front
        {
            get
            {
                Offload(Frontend, Backend);
                return Backend.Top;
            }
            set
            {
                _garbageNode = value;
            }
        }

        public Node<T> Rear
        {
            get
            {
                Offload(Backend, Frontend);
                return Frontend.Top;
            }
            set
            {
                _garbageNode = value;
            }
        }
        public Stack<T> Frontend { get; set; }
        public Stack<T> Backend { get; set; }

        /// <summary>
        /// constructs new pseudoqueue consisting of 2 empty stacks
        /// </summary>
        public PseudoQ()
        {
            Frontend = new Stack<T>();
            Backend = new Stack<T>();

        }

        /// <summary>
        /// moves all nodes from one stack to another
        /// </summary>
        /// <param name="from"> donating stack </param>
        /// <param name="to"> receiving stack </param>
        public void Offload(Stack<T> from, Stack<T> to)
        {
            try
            {
                while (from.Top != null)
                {
                    to.Push(from.Pop().Value);
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("empty stack");
            }
        }

        /// <summary>
        /// Adds a new node of specified value to the effective 'Rear' of pseudoqueue
        /// ('Rear' is bottom of 'Backend' stack)
        /// </summary>
        /// <param name="value"> value of added node </param>
        public void Enqueue(T value)
        {
            Offload(Backend, Frontend);
            Frontend.Push(value);
        }

        /// <summary>
        /// Removes the effective 'Front' of pseudoqueue
        /// ('Front' is bottom of 'Frontend' stack)
        /// </summary>
        /// <returns> removed node </returns>
        public Node<T> Dequeue()
        {
            Offload(Frontend, Backend);
            return Backend.Pop();
        }

        /// <summary>
        /// Prints pseudoqueue to console
        /// </summary>
        public void Print()
        {
            Offload(Backend, Frontend);
            Console.Write("Rear => ");
            try
            {
                while (Frontend.Top != null)
                {
                    Console.Write($"{Frontend.Top.Value} => ");
                    Backend.Push(Frontend.Pop().Value);
                }
            }
            catch (NullReferenceException)
            {
                Console.Write(" (no nodes to print) => ");
            }
            finally
            {
                Console.WriteLine("Front");
            }
        }
    }
}
