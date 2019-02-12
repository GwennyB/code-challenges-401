using System;
using tree.Classes;

namespace FindAncestry
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool ancestor = IsAncestor(BuildBinTree(), 6, 1);
            Console.WriteLine($"This should be TRUE: {ancestor}");

            ancestor = IsAncestor(BuildBinTree(), 5, 15);
            Console.WriteLine($"This should be FALSE: {ancestor}");

            Console.ReadLine();
        }

        public static bool IsAncestor(BinaryTree tree, int one, int two)
        {
            return FindA(tree.Root, one, two);
        }

        public static bool FindA(Node node, int one, int two)
        {
            if (node.Value == one)
            {
                if (node.Left != null)
                {
                    FindB(node.Left, two);
                }
                if (node.Right != null)
                {
                    FindB(node.Right, two);
                }
            }
            else
            {
                if (node.Left != null)
                {
                    FindA(node.Left, one, two);
                }
                if (node.Right != null)
                {
                    FindA(node.Right, one, two);
                }
            }
            return false;
        }

        public static bool FindB(Node node, int two)
        {
            if (node.Value == two)
            {
                return true;
            }
            else
            {
                if (node.Left != null)
                {
                    FindB(node.Left, two);
                }
                if (node.Right != null)
                {
                    FindB(node.Right, two);
                }
            }
            return false;
        }

        /// <summary>
        /// populates BinaryTree of height=7 for testing
        /// </summary>
        /// <param name="tree"> tree to populate</param>
        /// <returns> populated tree </returns>
        public static BinaryTree BuildBinTree()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);
            tree.Root.Left.Left = new Node(4);
            tree.Root.Left.Right = new Node(5);
            tree.Root.Right.Left = new Node(6);
            tree.Root.Right.Left.Left = new Node(7);
            tree.Root.Right.Left.Right = new Node(8);
            tree.Root.Right.Right = new Node(9);
            tree.Root.Right.Right.Left = new Node(10);
            tree.Root.Right.Right.Right = new Node(11);
            tree.Root.Right.Right.Right.Left = new Node(12);
            tree.Root.Right.Right.Right.Right = new Node(13);
            tree.Root.Right.Right.Right.Right.Left = new Node(14);
            tree.Root.Right.Right.Right.Right.Right = new Node(15);
            tree.Root.Right.Right.Right.Right.Right = new Node(16);
            tree.Root.Right.Right.Right.Right.Right.Left = new Node(17);
            tree.Root.Right.Right.Right.Right.Right.Left.Right = new Node(18);
            return tree;
        }
    }
}
