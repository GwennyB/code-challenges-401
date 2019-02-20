using System;
using System.Collections.Generic;
using System.Text;

namespace tree.Classes
{
    public class BinarySearchTree : BinaryTree
    {
        public BinarySearchTree()
        {
            Root = null;
        }

        public BinarySearchTree(Node node)
        {
            Root = node;
        }

        /// <summary>
        /// inserts a new node of specified value into a binary search tree
        /// </summary>
        /// <param name="value"> value of new node to insert </param>
        public void Add(int value)
        {
            Node newNode = new Node(value);
            Node current = Root;
            Node last = null;
            while (current != null)
            {
                if ((int)value == (int)current.Value)
                {

                    return;
                }
                else if ((int)value < (int)current.Value)
                {
                    last = current;
                    current = current.Left;
                }
                else
                {
                    last = current;
                    current = current.Right;
                }
            }
            if((int)value < (int)last.Value)
            {
                last.Left = newNode;
            }
            else
            {
                last.Right = newNode;
            }
        }
        
        /// <summary>
        /// determines whether a node of specified value exists in a binary search tree
        /// </summary>
        /// <param name="value"> true if present, false if not present </param>
        /// <returns></returns>
        public bool Contains(int value)
        {
            Node current = Root;
            while (current != null)
            {
                if ((int)current.Value == (int)value)
                {
                    return true;
                }
                else if ((int)value < (int)current.Value)
                {
                    current = current.Left;
                }
                else
                {
                    current = current.Right;
                }
            }
            return false;
        }

    }
}
