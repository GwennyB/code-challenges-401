using System;
using Xunit;
using breadth_first_traversal;
using breadth_first_traversal.Classes;

namespace UnitTests
{
    public class UnitTest1
    {
        /// <summary>
        /// verifies that BreadthFirst returns values in correct order
        /// </summary>
        [Fact]
        public void BreadthFirst_ReturnsCorrectOrder()
        {
            int[] values = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            Assert.Equal(values, Program.BreadthFirst(Program.BuildBinTree()));
        }

        /// <summary>
        /// verifies that BreadthFirst handles empty tree
        /// </summary>
        [Fact]
        public void BreadthFirst_HandlesEmptyTree()
        {
            int[] values = new int[] { };
            BinaryTree tree = new BinaryTree();

            Assert.Equal(values, Program.BreadthFirst(tree));
        }

        /// <summary>
        /// verifies that BreadthFirst handles imbalance to left
        /// </summary>
        [Fact]
        public void BreadthFirst_HandlesImbalanceLeft()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);
            tree.Root.Left.Left = new Node(4);
            //tree.Root.Left.Right = new Node(5);
            tree.Root.Right.Left = new Node(6);
            tree.Root.Right.Right = new Node(7);

            int[] values = new int[] { 1, 2, 3, 4, /*5,*/ 6, 7 };

            Assert.Equal(values, Program.BreadthFirst(tree));
        }

        /// <summary>
        /// verifies that BreadthFirst handles imbalance to right
        /// </summary>
        [Fact]
        public void BreadthFirst_HandlesImbalanceRight()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);
            tree.Root.Left.Left = new Node(4);
            tree.Root.Left.Right = new Node(5);
            //tree.Root.Right.Left = new Node(6);
            tree.Root.Right.Right = new Node(7);

            int[] values = new int[] { 1, 2, 3, 4, 5, /*6,*/ 7 };

            Assert.Equal(values, Program.BreadthFirst(tree));
        }

    }
}
