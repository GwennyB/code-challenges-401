using System;
using tree.Classes;

namespace tree
{
    class Program
    {
        static void Main(string[] args)
        {

            TestBinTree();

            TestBSTree();

            Console.ReadLine();

        }

        public static BinaryTree BuildBinTree(BinaryTree tree)
        {
            tree.Root = new Node(1);
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);
            tree.Root.Left.Left = new Node(4);
            tree.Root.Left.Right = new Node(5);
            tree.Root.Right.Left = new Node(6);
            tree.Root.Right.Right = new Node(7);
            return tree;
        }

        public static BinarySearchTree BuildBSTree(BinarySearchTree tree)
        {
            tree.Root = new Node(40);
            tree.Root.Left = new Node(30);
            tree.Root.Right = new Node(60);
            tree.Root.Left.Left = new Node(10);
            tree.Root.Left.Right = new Node(30);
            tree.Root.Right.Left = new Node(50);
            tree.Root.Right.Right = new Node(70);
            return tree;
        }

        public static void TestBinTree()
        {
            BinaryTree tree = new BinaryTree();
            tree = BuildBinTree(tree);
            Console.Write("PreOrder: ");
            PrintTreeValues(tree.PreOrder());
            Console.Write("InOrder: ");
            PrintTreeValues(tree.InOrder());
            Console.Write("PostOrder: ");
            PrintTreeValues(tree.PostOrder());
        }

        public static void TestBSTree()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree = BuildBSTree(tree);
            Console.Write("PreOrder (original): ");
            PrintTreeValues(tree.PreOrder());
            int value = 15;
            Console.WriteLine($"15 present? {tree.Contains(value)}");
            tree.Add(value);
            Console.Write($"PreOrder (added {value}): ");
            PrintTreeValues(tree.PreOrder());
            Console.WriteLine($"{value} present? {tree.Contains(value)}");
        }

        public static void PrintTreeValues(int[] tree)
        {
            foreach (int value in tree)
            {
                Console.Write($"{value}=> ");
            }
            Console.WriteLine();
        }
    }
}
