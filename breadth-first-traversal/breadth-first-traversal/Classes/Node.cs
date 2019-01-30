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

        public Node(int value)
        {
            Value = value;
            Left = null;
            Right = null;
            Next = null;
        }
    }
}
