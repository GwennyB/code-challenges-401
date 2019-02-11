using BinaryTreeHeight.Classes;
using System;

namespace BinaryTreeHeight
{
    public class Program
    {

        //Calculate the height of a binary tree(4 Points)
        //Implement a method with the following signature int CalculateBinaryTreeHeight(Node root) that calculates the height of a binary tree.

        //Hint: The height of a binary tree is the height of its root

        //Stretch Goal (1 Additional Point)
        //Once you calculate the height of a tree, write a similar function to calculate the number of levels for a tree.


        static void Main(string[] args)
        {
            // build a tree to check
            BinaryTree tree = BuildBinTree();
            // check the tree
            Console.WriteLine($"tree has {CalculateBinaryTreeHeight(tree.Root)} edges");
            Console.WriteLine($"tree has {CalculateBinTreeLevels(tree.Root)} levels");

            Console.ReadLine();
        }

        /// <summary>
        /// calculates the number of levels of a binary tree by finding its height (# edges - or parent nodes - on longest path) and adding 1 for lowest leaf (which has no chidren
        /// </summary>
        /// <param name="root"> root of tree to check </param>
        /// <returns> number of levels in tree </returns>
        public static int CalculateBinTreeLevels(Node root)
        {
            // set a payload to carry edge count
            int height = 0;

            // initiate recursive search
            height = FindEdges(root, height);

            // add lowest leaf level:
            height++;

            return height;
        }

        /// <summary>
        /// accepts a tree root and initiates a recursive search for edges
        /// </summary>
        /// <param name="root"> root of tree to search </param>
        /// <returns> height of tree (# edges along longest path) </returns>
        public static int CalculateBinaryTreeHeight(Node root)
        {

            // set a payload to carry edge count
            int height = 0;

            // initiate recursive search
            height = FindEdges(root, height);
            return height;
        }

        /// <summary>
        /// HELPER: finds path lengths (in edge count) and returns longest path length
        /// </summary>
        /// <param name="node"> root of tree to check </param>
        /// <param name="height"> height of tree (# edges along longest path) </param>
        /// <returns></returns>
        private static int FindEdges(Node node, int height)
        {
            int a = 0;
            int b = 0;
            if (node.Left != null)
            {
                a = FindEdges(node.Left, height)+1;
            }
            if (node.Right != null)
            { 
                b = FindEdges(node.Right, height)+1;
            }
            height = a>b ? height+a : height+b;
            return height;
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
            tree.Root.Right.Left.Left = new Node(6);
            tree.Root.Right.Left.Right = new Node(6);
            tree.Root.Right.Right = new Node(7);
            tree.Root.Right.Right.Left = new Node(7);
            tree.Root.Right.Right.Right = new Node(7);
            tree.Root.Right.Right.Right.Left = new Node(7);
            tree.Root.Right.Right.Right.Right = new Node(7);
            tree.Root.Right.Right.Right.Right.Left = new Node(7);
            tree.Root.Right.Right.Right.Right.Right = new Node(7);
            tree.Root.Right.Right.Right.Right.Right = new Node(7);
            tree.Root.Right.Right.Right.Right.Right.Left = new Node(7);
            tree.Root.Right.Right.Right.Right.Right.Left.Right = new Node(7);
            return tree;
        }


    }
}
