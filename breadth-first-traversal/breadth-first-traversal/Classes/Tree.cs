﻿using System;
using System.Collections.Generic;
using System.Text;

namespace breadth_first_traversal.Classes
{
    public class Tree
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