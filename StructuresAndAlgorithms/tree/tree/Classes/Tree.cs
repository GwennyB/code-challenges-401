using System;
using System.Collections.Generic;
using System.Text;

namespace tree.Classes
{
    class Tree
    {
        public Node Root { get; set; }
        public Node Current { get; set; }

        public Tree()
        {
            Root = null;
            Current = Root;
        }

        public Tree(Node node)
        {
            Root = node;
            Current = Root;
        }

    }
}
