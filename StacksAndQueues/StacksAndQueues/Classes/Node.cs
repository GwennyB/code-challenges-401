using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    class Node
    {
        public int Value { get; set; }

        public Node Next { get; set; }

        /// <summary>
        /// constructs new node of specified value, and points it into the ether
        /// </summary>
        /// <param name="value"> value to assign to the new node </param>
        public Node(int value)
        {
            Value = value;
            Next = null;
        }
    }
}
