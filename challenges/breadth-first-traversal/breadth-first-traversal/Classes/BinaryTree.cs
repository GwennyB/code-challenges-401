using System;
using System.Collections.Generic;
using System.Text;

namespace breadth_first_traversal.Classes
{
    public class BinaryTree : Tree
    {
        /// <summary>
        /// constructs an empty Binary Tree
        /// </summary>
        public BinaryTree()
        {
            Root = null;
        }

        /// <summary>
        /// constructs a Binary Tree with specified node as root
        /// </summary>
        /// <param name="node"></param>
        public BinaryTree(Node node)
        {
            Root = node;
        }
        

    }
}
