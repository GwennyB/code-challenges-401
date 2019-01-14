using System;
using System.Collections.Generic;
using System.Text;

namespace linked_list.Classes
{
    class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        /// <summary>
        /// Constructor - require value at node 
        /// </summary>
        /// <param name="value"></param>
        public Node(int value)
        {
            Value = value;
        }
    }
}
