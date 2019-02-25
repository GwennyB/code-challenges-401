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
        public void Insert(Object value)
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
        public bool Includes(Object value)
        {
            if (Head != null)
            {
                Current = Head;

                while (Current.Next != null)
                {
                    if (Current.Value.Equals(value))
                    {
                        return true;
                    }
                    Current = Current.Next;
                }
                if (Current.Value.Equals(value))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Finds a value in a linked list in a hashtable.
        /// </summary>
        /// <param name="value"> key of node to locate </param>
        /// <returns> value of matching node (or null if not found) </returns>
        public Object Find(Object key)
        {
            Current = Head;
            while(Current != null)
            {
                if (Current.Key.Equals(key))
                {
                    return Current.Value;
                }
                else
                {
                    Current = Current.Next;
                }
            }
            return null;
        }

        /// <summary>
        /// Finds a value in a linked list.
        /// Caller-facing: Calls FindRec to complete the heavy lifting. Sends Head as start point.
        /// </summary>
        /// <param name="value"> value to look for </param>
        /// <returns> matching node (or null if not found) </returns>
        public Node Find(int value)
        {
            return FindRec(value, Head);
        }

        /// <summary>
        /// Finds a value in a linked list using recursion.
        /// Back-facing: Accessible only to local methods. Does the heavy lifting for 'Find(value)'.
        /// </summary>
        /// <param name="value"> value to look for </param>
        /// <param name="node"> node at which to start search </param>
        /// <returns> matching node (or null if not found) </returns>
        private Node FindRec(Object value, Node node)
        {
            if(node.Value.Equals(value))
            {
                return node;
            }
            if(node.Next == null)
            {
                return node.Next;
            }

            return FindRec(value, node.Next);
        }

        /// <summary>
        /// Prints the values of all nodes in a linked list
        /// </summary>
        public void Print()
        {
            if (Head != null)
            {
                Current = Head;
                Console.Write($"Head => {Current.Value} => ");
                while (Current.Next != null)
                {
                    Current = Current.Next;
                    Console.Write($"{ Current.Value } => ");
                }
                Console.Write("Null");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("List is empty");
                Console.ReadLine();
            }
        }

        /// <summary>
        /// Prints the values of all nodes in a linked list
        /// Uses recursion
        /// </summary>
        /// <param name="node"></param>
        public void PrintRec(Node node)
        {
            if(node.Next == null)
            {
                Console.WriteLine(node.Value);
                return;
            }
            Console.Write($"{node.Value} => ");
            PrintRec(node.Next);
        }

        /// <summary>
        /// Creates a new node with specified value and inserts it at the end of a linked list
        /// </summary>
        /// <param name="value"> value of new node </param>
        public void Append(int value)
        {
            if (Head == null)
            {
                Node node = new Node(value);
                Head = node;
            }
            else
            {
                Current = Head;

                while (Current.Next != null)
                {
                    Current = Current.Next;
                }

                Node node = new Node(value);

                Current.Next = node;
            }
        }

        /// <summary>
        /// Creates a new node with specified value and inserts it at the end of a linked list
        /// </summary>
        /// <param name="value"> value of new node </param>
        public void Append(Object value)
        {
            if(Head == null)
            {
                Node node = new Node(value);
                Head = node;
            }
            else
            {
                Current = Head;
            
                while (Current.Next != null)
                {
                    Current = Current.Next;
                }

                Node node = new Node(value);

                Current.Next = node;
            }
        }

        /// <summary>
        /// Creates a new node with specified value and inserts it at the end of a linked list
        /// </summary>
        /// <param name="value"> value of new node </param>
        public void Append(Object key, Object value)
        {
            if (Head == null)
            {
                Node node = new Node(key,value);
                Head = node;
            }
            else
            {
                Current = Head;

                while (Current.Next != null)
                {
                    Current = Current.Next;
                }

                Node node = new Node(key,value);

                Current.Next = node;
            }
        }

        /// <summary>
        /// Creates a new node with specified value (newValue) and inserts it into a linked list before the first existing node that matches specified value (value)
        /// </summary>
        /// <param name="value"> value of existing node to park new node in front of </param>
        /// <param name="newValue"> value of new node to be created and inserted into list </param>
        public void InsertBefore(Object value, Object newValue)
        {
            Current = Head;

            if (Current.Value.Equals(value))
            {
                Insert(newValue);
                return;
            }

            while (Current.Next != null)
            {
                if (Current.Next.Value.Equals(value))
                {
                    Node node = new Node(newValue);
                    node.Next = Current.Next;
                    Current.Next = node;
                    return;
                }

                Current = Current.Next;
            }
        }

        /// <summary>
        /// Creates a new node with specified value (newValue) and inserts it into a linked list before the first existing node that matches specified value (value)
        /// </summary>
        /// <param name="value"> value of existing node to park new node in front of </param>
        /// <param name="newValue"> value of new node to be created and inserted into list </param>
        public void InsertAfter(Object value, Object newValue)
        {
            Current = Head;

            while (Current.Next != null)
            {
                if (Current.Value.Equals(value))
                {
                    Node node = new Node(newValue);
                    node.Next = Current.Next;
                    Current.Next = node;
                    return;
                }

                else
                {
                    Current = Current.Next;
                }
            }
            if (Current.Value.Equals(value))
            {
                Node node = new Node(newValue);
                Current.Next = node;
                return;
            }
        }

        /// <summary>
        /// Finds the k-th node from the end of a list and returns the value of its predecessor
        /// </summary>
        /// <param name="k"> number of nodes to count back from end </param>
        /// <returns> value of node preceding k-th from end </returns>
        public Object FindFromEnd(int k)
        {
            // count nodes in list
            int counter = 1;
            Current = Head;
            while(Current.Next != null)
            {
                Current = Current.Next;
                counter++;
            }

            // check whether list contains more than k elements
            if (k >= counter)
            { return null; }

            // set target node #
            counter -= k;

            // traverse from beginning to target node
            Current = Head;
            while(counter > 1)
            {
                Current = Current.Next;
                counter--;
            }
            
            return Current.Value;
        }
    }
}
