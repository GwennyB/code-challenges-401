using System;
using System.Collections.Generic;
using FizzBuzzTree.Classes;

namespace FizzBuzzTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = BuildBinTree(new BinaryTree());
            PrintTreeValues(tree.PostOrder());
            FizzBuzzTree(tree.Root);
            PrintTreeValues(tree.PostOrder());
            Console.ReadLine();
        }

        /// <summary>
        /// RECURSIVE: Checks each node for divisibility by 15, 3, or 5, and
        /// changes value to 'FizzBuzz', 'Fizz', or 'Buzz' (respectively) if yes
        /// </summary>
        /// <param name="node"> node to check </param>
        public static void FizzBuzzTree(Node node)
        {
            if (node.Left != null)
            {
                FizzBuzzTree(node.Left);
            }
            if (node.Right != null)
            {
                FizzBuzzTree(node.Right);
            };
            int nodeValue = 0;
            try
            {
                nodeValue = Convert.ToInt32(node.Value);
            }
            catch (Exception)
            {
                return;
            }
            if(nodeValue % 15 == 0)
            {
                node.Value = "FizzBuzz";
            }
            else if (nodeValue % 3 == 0)
            {
                node.Value = "Fizz";
            }
            else if (nodeValue % 5 == 0)
            {
                node.Value = "Buzz";
            }
            else
            {
                return;
            }
        }

        /// <summary>
        /// build up tree to test
        /// </summary>
        /// <param name="tree"> empty tree to build up </param>
        /// <returns> populated tree </returns>
        public static BinaryTree BuildBinTree(BinaryTree tree)
        {
            tree.Root = new Node(5);
            tree.Root.Left = new Node(10);
            tree.Root.Right = new Node(15);
            tree.Root.Left.Left = new Node(20);
            tree.Root.Left.Right = new Node("test");
            tree.Root.Right.Left = new Node(30);
            tree.Root.Right.Right = new Node(33);
            return tree;
        }

        /// <summary>
        /// prints node values returned by Pre/In/PostOrder method
        /// </summary>
        /// <param name="tree"> tree values in an array </param>
        public static void PrintTreeValues(Object[] tree)
        {
            foreach (Object value in tree)
            {
                Console.Write($"{value}=> ");
            }
            Console.WriteLine();
        }
    }
}
