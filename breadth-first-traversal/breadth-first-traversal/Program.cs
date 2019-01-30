using System;
using System.Collections.Generic;
using breadth_first_traversal.Classes;

namespace breadth_first_traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            BreadthFirst(BuildBinTree());
            Console.ReadLine();
        }

        public static void BreadthFirst(BinaryTree tree)
        {
            Queue queue = new Queue();
            queue.Enqueue(tree.Root);
            while(queue.Front != null)
            {
                if (queue.Front.Left != null)
                {
                    queue.Enqueue(queue.Front.Left);
                }
                if (queue.Front.Right != null)
                {
                    queue.Enqueue(queue.Front.Right);
                }
                Console.WriteLine($"{queue.Dequeue()}");
            }
        }


        private static BinaryTree BuildBinTree()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);
            tree.Root.Left.Left = new Node(4);
            tree.Root.Left.Right = new Node(5);
            tree.Root.Right.Left = new Node(6);
            tree.Root.Right.Right = new Node(7);
            return tree;
        }


    }
}
