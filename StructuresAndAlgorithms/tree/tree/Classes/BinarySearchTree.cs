using System;
using System.Collections.Generic;
using System.Text;

namespace tree.Classes
{
    class BinarySearchTree<T> : Tree<T>
    {
        public BinarySearchTree()
        {
            Root = null;
        }

        public BinarySearchTree(Node<T> node)
        {
            Root = node;
        }

        public void Add(T value)
        {

        }
        
        public bool Contains(T value)
        {

        }
    }
}
