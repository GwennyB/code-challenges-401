using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzTree.Classes
{
    public class Node
    {
        public Object Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        /// <summary>
        /// constructs node of specified value
        /// </summary>
        /// <param name="value"> value to assign to new node </param>
        public Node(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }
}
