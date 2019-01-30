using System;
using System.Collections.Generic;
using System.Text;

namespace breadth_first_traversal.Classes
{
    public class Node
    {
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public Node Next { get; set; }

        /// <summary>
        /// constructs a node that can act as both Queue and Tree node
        /// </summary>
        /// <param name="value"></param>
        public Node(int value)
        {
            Value = value;
            Left = null;
            Right = null;
            Next = null;
        }
    }
}
