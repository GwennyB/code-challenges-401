using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzTree.Classes
{
    public class BinaryTree : Tree
    {
        /// <summary>
        /// constructs empty BinaryTree
        /// </summary>
        public BinaryTree()
        {
            Root = null;
        }

        /// <summary>
        /// constructs BinaryTree with just a root
        /// </summary>
        /// <param name="node"> node to become root of new tree </param>
        public BinaryTree(Node node)
        {
            Root = node;
        }

        /// <summary>
        /// scrapes values from all nodes in a binary tree and returns them in PostOrder
        /// </summary>
        /// <returns> array of tree values in PostOrder </returns>
        public Object[] PostOrder()
        {
            List<Object> values = new List<Object>();
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
        private List<Object> PostOrderBottom(Node node, List<Object> values)
        {
            if (node.Left != null)
            {
                PostOrderBottom(node.Left, values);
            }
            if(node.Right != null)
            {
                PostOrderBottom(node.Right, values);
            };
            values.Add(node.Value);

            return values;
        }

        /// <summary>
        /// scrapes values from all nodes in a binary tree and returns them in InOrder
        /// </summary>
        /// <returns> array of tree values in InOrder </returns>
        public Object[] InOrder()
        {
            List<Object> values = new List<Object>();
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
        private List<Object> InOrderBottom(Node node, List<Object> values)
        {
            if (node.Left != null)
            {
                InOrderBottom(node.Left, values);
            }
            values.Add(node.Value);
            if (node.Right != null)
            {
                InOrderBottom(node.Right, values);
            }
            return values;
        }

        /// <summary>
        /// scrapes values from all nodes in a binary tree and returns them in PreOrder
        /// </summary>
        /// <returns> array of tree values in PreOrder </returns>
        public Object[] PreOrder()
        {
            List<Object> values = new List<Object>();
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
        private List<Object> PreOrderBottom(Node node, List<Object> values)
        {
            values.Add(node.Value);
            if (node.Left != null)
            {
                PreOrderBottom(node.Left, values);
            }
            if (node.Right != null)
            {
                PreOrderBottom(node.Right, values);
            };
            return values;
        }
    }
}
