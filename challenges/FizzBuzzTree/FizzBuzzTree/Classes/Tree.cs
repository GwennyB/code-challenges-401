using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzTree.Classes
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
        /// constructs tree with root
        /// </summary>
        /// <param name="node"> node to assign as root </param>
        public Tree(Node node)
        {
            Root = node;
            Current = Root;
        }

    }
}
