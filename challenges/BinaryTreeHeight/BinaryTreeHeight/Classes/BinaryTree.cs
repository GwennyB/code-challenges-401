using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeHeight.Classes
{
    public class BinaryTree : Tree
    {
        public BinaryTree()
        {
            Root = null;
        }

        public BinaryTree(Node node)
        {
            Root = node;
        }

    }


}
