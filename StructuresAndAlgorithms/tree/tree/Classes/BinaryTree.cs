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

        //public void FindHoleBreadthFirst()
        //{
        //    Queue<T> queue = new Queue<T>();
        //    if (Root != null)
        //    {
        //        queue = FillTreeQueue(Root, queue);
        //    }
        //    return queue;
        //}

        //private Queue<T> FillTreeQueue(Node<T> node, Queue<T> queue)
        //{
        //    queue.Enqueue(node.Value);
        //    if (node.Left != null)
        //    {
        //        FillTreeQueue(node.Left);
        //    }
        //}

        //public void Add(T value)
        //{

        //}

        //public void Remove(T value)
        //{

        //}

        public T[] PostOrder()
        {
            List<T> values = new List<T>();
            if(Root != null)
            {
                values = PostOrderBottom(Root, values);
            }
            return values.ToArray();
        }

        private List<T> PostOrderBottom(Node<T> node, List<T> values)
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

        private List<T> InOrderBottom(Node<T> node, List<T> values)
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

        public T[] PreOrder()
        {
            List<T> values = new List<T>();
            if (Root != null)
            {
                PreOrderBottom(Root, values);
            }
            return values.ToArray();
        }

        private List<T> PreOrderBottom(Node<T> node, List<T> values)
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
