using System;
using tree.Classes;
using linked_list.Classes;

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

        /// <summary>
        /// populates BinaryTree for testing
        /// </summary>
        /// <param name="tree"> tree to populate</param>
        /// <returns> populated tree </returns>
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

        /// <summary>
        /// populates BinarySearchTree for testing
        /// </summary>
        /// <param name="tree"> tree to populate</param>
        /// <returns> populated tree </returns>
        public static BinarySearchTree BuildBSTree(BinarySearchTree tree)
        {
            tree.Root = new Node(40);
            tree.Root.Left = new Node(20);
            tree.Root.Right = new Node(60);
            tree.Root.Left.Left = new Node(10);
            tree.Root.Left.Right = new Node(30);
            tree.Root.Right.Left = new Node(50);
            tree.Root.Right.Right = new Node(70);
            return tree;
        }

        /// <summary>
        /// tests BinaryTree methods
        /// </summary>
        public static void TestBinTree()
        {
            Console.WriteLine("Test Binary Tree");
            BinaryTree tree = new BinaryTree();
            Console.WriteLine("Build tree...");
            tree = BuildBinTree(tree);
            Console.Write("Check 'PreOrder': ");
            PrintTreeValues(tree.PreOrder());
            Console.Write("Check 'InOrder': ");
            PrintTreeValues(tree.InOrder());
            Console.Write("Check 'PostOrder': ");
            PrintTreeValues(tree.PostOrder());
        }

        /// <summary>
        /// tests BinarySearchTree methods
        /// </summary>
        public static void TestBSTree()
        {
            Console.WriteLine("\n- - - - - -\n");
            Console.WriteLine("Test Binary Search Tree");
            BinarySearchTree tree = new BinarySearchTree();
            tree = BuildBSTree(tree);
            Console.WriteLine("Build tree...");
            Console.Write("InOrder (original): ");
            PrintTreeValues(tree.InOrder());
            int value = 63;
            Console.WriteLine("Check 'Add'...");
            Console.WriteLine($"{value} present? {tree.Contains(value)}");
            tree.Add(value);
            Console.Write($"InOrder (added {value}): ");
            PrintTreeValues(tree.InOrder());
            Console.WriteLine("Check 'Contains'...");
            Console.WriteLine($"{value} present? {tree.Contains(value)}");
        }

        /// <summary>
        /// prints node values returned by Pre/In/PostOrder method
        /// </summary>
        /// <param name="tree"></param>
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
