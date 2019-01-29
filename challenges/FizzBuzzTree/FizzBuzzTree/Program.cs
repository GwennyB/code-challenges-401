using System;
using System.Collections.Generic;
using FizzBuzzTree.Classes;

namespace FizzBuzzTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = BuildBinTree(new BinaryTree());
            PrintTreeValues(tree.PostOrder());
            FizzBuzzTree(tree.Root);
            PrintTreeValues(tree.PostOrder());
            Console.ReadLine();
        }

        static void FizzBuzzTree(Node node)
        {

            if (node.Left != null)
            {
                FizzBuzzTree(node.Left);
            }
            if (node.Right != null)
            {
                FizzBuzzTree(node.Right);
            };
            if(Convert.ToInt32(node.Value) % 15 == 0)
            {
                node.Value = "FizzBuzz";
            }
            else if (Convert.ToInt32(node.Value) % 3 == 0)
            {
                node.Value = "Fizz";
            }
            else if (Convert.ToInt32(node.Value) % 5 == 0)
            {
                node.Value = "Buzz";
            }
            else
            {
                return;
            }
        }

        static BinaryTree BuildBinTree(BinaryTree tree)
        {
            tree.Root = new Node(5);
            tree.Root.Left = new Node(10);
            tree.Root.Right = new Node(15);
            tree.Root.Left.Left = new Node(20);
            tree.Root.Left.Right = new Node(25);
            tree.Root.Right.Left = new Node(30);
            tree.Root.Right.Right = new Node(33);
            return tree;
        }

        /// <summary>
        /// prints node values returned by Pre/In/PostOrder method
        /// </summary>
        /// <param name="tree"></param>
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
