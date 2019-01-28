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
                if (value == current.Value)
                {

                    return;
                }
                else if (value < current.Value)
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
            if(value < last.Value)
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
                if (current.Value == value)
                {
                    return true;
                }
                else if (value < current.Value)
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
