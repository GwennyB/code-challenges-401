using System;
using System.Collections.Generic;
using System.Text;

namespace tree.Classes
{
    class BinaryTree<T> : Tree<T>
    {
        public BinaryTree()
        {
            Root = null;
        }

        public BinaryTree(Node<T> node)
        {
            Root = node;
        }

        public void Add(T value)
        {

        }


        public T[] PostOrder()
        {
            List<T> values = new List<T>();
            if(Root != null)
            {
                values = PostOrderBottom(Root, values);
            }
            return values.ToArray();
        }

        public List<T> PostOrderBottom(Node<T> node, List<T> values)
        {
            if (node.Left != null)
            {
                PostOrderBottom(node.Left, values);
                if(node.Right != null)
                {
                    PostOrderBottom(node.Right, values);
                };
            }
            else
            {
                values.Add(node.Value);
            }
            return values;
        }

        public T[] InOrder()
        {
            List<T> values = new List<T>();
            if (Root != null)
            {
                InOrderBottom(Root, values);
            }
            return values.ToArray();
        }

        public List<T> InOrderBottom(Node<T> node, List<T> values)
        {
            if (node.Left != null)
            {
                InOrderBottom(node.Left, values);
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

        public T[] PreOrder()
        {
            List<T> values = new List<T>();
            if (Root != null)
            {
                PreOrderBottom(Root, values);
            }
            return values.ToArray();
        }

        public List<T> PreOrderBottom(Node<T> node, List<T> values)
        {
            if (node.Left != null)
            {
                PreOrderBottom(node.Left, values);
                if (node.Right != null)
                {
                    PreOrderBottom(node.Right, values);
                };
            }
            else
            {
                values.Add(node.Value);
            }
            return values;
        }
    }
}
