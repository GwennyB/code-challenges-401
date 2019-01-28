using System;
using System.Collections.Generic;
using System.Text;

namespace tree.Classes
{
    class Tree<T>
    {
        public Node<T> Root { get; set; }
        public Node<T> Current { get; set; }

        public Tree()
        {
            Root = null;
            Current = Root;
        }

        public Tree(Node<T> node)
        {
            Root = node;
            Current = Root;
        }

    }
}
