using System;
using tree.Classes;

namespace tree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> binTree = new BinaryTree<int>();
            binTree = BuildBinTree(binTree);

            BinarySearchTree<int> bsTree = new BinarySearchTree<int>();
            bsTree = BuildBSTree(bsTree);

        }

        public static BinaryTree<int> BuildBinTree(BinaryTree<int> tree)
        {
            tree.Root = new Node<int>(1);
            tree.Root.Left = new Node<int>(2);
            tree.Root.Right = new Node<int>(3);
            tree.Root.Left.Left = new Node<int>(4);
            tree.Root.Left.Right = new Node<int>(5);
            tree.Root.Right.Left = new Node<int>(4);
            tree.Root.Right.Right = new Node<int>(5);
            return tree;
        }

        public static BinarySearchTree<int> BuildBSTree(BinarySearchTree<int> tree)
        {
            tree.Root = new Node<int>(40);
            tree.Root.Left = new Node<int>(30);
            tree.Root.Right = new Node<int>(60);
            tree.Root.Left.Left = new Node<int>(10);
            tree.Root.Left.Right = new Node<int>(30);
            tree.Root.Right.Left = new Node<int>(50);
            tree.Root.Right.Right = new Node<int>(70);
            return tree;
        }


    }
}
