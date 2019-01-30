using System;
using System.Collections.Generic;
using System.Text;

namespace breadth_first_traversal.Classes
{
    public class Tree
    {
        public Node Root { get; set; }
        public Node Current { get; set; }

        /// <summary>
        /// constructs an empty tree
        /// </summary>
        public Tree()
        {
            Root = null;
            Current = Root;
        }

        /// <summary>
        /// constructs a tree on specified root
        /// </summary>
        /// <param name="node"></param>
        public Tree(Node node)
        {
            Root = node;
            Current = Root;
        }

    }
}
