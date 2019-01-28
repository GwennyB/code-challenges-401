using System;
using System.Collections.Generic;
using System.Text;

namespace tree.Classes
{
    class BinaryTree : Tree
    {
        public BinaryTree()
        {
            Root = null;
        }

        public BinaryTree(Node node)
        {
            Root = node;
        }

        /// <summary>
        /// scrapes values from all nodes in a binary tree and returns them in PostOrder
        /// </summary>
        /// <returns> array of tree values in PostOrder </returns>
        public int[] PostOrder()
        {
            List<int> values = new List<int>();
            if(Root != null)
            {
                values = PostOrderBottom(Root, values);
            }
            return values.ToArray();
        }

        /// <summary>
        /// RECURSIVE HELPER: scrapes values from all nodes in a binary tree and returns them in PostOrder
        /// </summary>
        /// <returns> array of tree values in PostOrder </returns>
        private List<int> PostOrderBottom(Node node, List<int> values)
        {
            if (node.Left != null)
            {
                PostOrderBottom(node.Left, values);
                if(node.Right != null)
                {
                    PostOrderBottom(node.Right, values);
                };
            }
            values.Add(node.Value);

            return values;
        }

        /// <summary>
        /// scrapes values from all nodes in a binary tree and returns them in InOrder
        /// </summary>
        /// <returns> array of tree values in InOrder </returns>
        public int[] InOrder()
        {
            List<int> values = new List<int>();
            if (Root != null)
            {
                InOrderBottom(Root, values);
            }
            return values.ToArray();
        }

        /// <summary>
        /// RECURSIVE HELPER: scrapes values from all nodes in a binary tree and returns them in InOrder
        /// </summary>
        /// <returns> array of tree values in InOrder </returns>
        private List<int> InOrderBottom(Node node, List<int> values)
        {
            if (node.Left != null)
            {
                InOrderBottom(node.Left, values);
                values.Add(node.Value);
                if (node.Right != null)
                {
                    InOrderBottom(node.Right, values);
                };
            }
            else
            {
                values.Add(node.Value);
            }
            return values;
        }

        /// <summary>
        /// scrapes values from all nodes in a binary tree and returns them in PreOrder
        /// </summary>
        /// <returns> array of tree values in PreOrder </returns>
        public int[] PreOrder()
        {
            List<int> values = new List<int>();
            if (Root != null)
            {
                PreOrderBottom(Root, values);
            }
            return values.ToArray();
        }

        /// <summary>
        /// RECURSIVE HELPER: scrapes values from all nodes in a binary tree and returns them in PreOrder
        /// </summary>
        /// <returns> array of tree values in PreOrder </returns>
        private List<int> PreOrderBottom(Node node, List<int> values)
        {
            values.Add(node.Value);
            if (node.Left != null)
            {
                PreOrderBottom(node.Left, values);
                if (node.Right != null)
                {
                    PreOrderBottom(node.Right, values);
                };
            }
            return values;
        }
    }
}
