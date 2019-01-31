using System;
using Xunit;
using tree.Classes;

namespace UnitTests
{
    public class UnitTest1
    {
        /// <summary>
        /// verifies that InOrder returns an array in the expected order
        /// </summary>
        [Fact]
        public void InOrder_ReturnsProperOrder()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);
            tree.Root.Left.Left = new Node(4);
            tree.Root.Left.Right = new Node(5);
            tree.Root.Right.Left = new Node(6);
            tree.Root.Right.Right = new Node(7);

            int[] values = new int[] { 4, 2, 5, 1, 6, 3, 7 };

            Assert.Equal(values, tree.InOrder());
        }

        /// <summary>
        /// verifies that PreOrder returns an array in the expected order
        /// </summary>
        [Fact]
        public void PreOrder_ReturnsProperOrder()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);
            tree.Root.Left.Left = new Node(4);
            tree.Root.Left.Right = new Node(5);
            tree.Root.Right.Left = new Node(6);
            tree.Root.Right.Right = new Node(7);

            int[] values = new int[] { 1, 2, 4, 5, 3, 6, 7 };

            Assert.Equal(values, tree.PreOrder());
        }

        /// <summary>
        /// verifies that PostOrder returns an array in the expected order
        /// </summary>
        [Fact]
        public void PostOrder_ReturnsProperOrder()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);
            tree.Root.Left.Left = new Node(4);
            tree.Root.Left.Right = new Node(5);
            tree.Root.Right.Left = new Node(6);
            tree.Root.Right.Right = new Node(7);

            int[] values = new int[] { 4, 5, 2, 6, 7, 3, 1 };

            Assert.Equal(values, tree.PostOrder());
        }

        /// <summary>
        /// verifies that Contains returns 'true' when value present in tree
        /// </summary>
        [Fact]
        public void Contains_ReturnsTrue()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Root = new Node(40);
            tree.Root.Left = new Node(20);
            tree.Root.Right = new Node(60);
            tree.Root.Left.Left = new Node(10);
            tree.Root.Left.Right = new Node(30);
            tree.Root.Right.Left = new Node(50);
            tree.Root.Right.Right = new Node(70);

            Assert.True(tree.Contains(60));
        }

        /// <summary>
        /// verifies that Contains returns 'false' when value not present in tree
        /// </summary>
        [Fact]
        public void Contains_ReturnsFalse()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Root = new Node(40);
            tree.Root.Left = new Node(20);
            tree.Root.Right = new Node(60);
            tree.Root.Left.Left = new Node(10);
            tree.Root.Left.Right = new Node(30);
            tree.Root.Right.Left = new Node(50);
            tree.Root.Right.Right = new Node(70);

            Assert.False(tree.Contains(55));
        }

        /// <summary>
        /// verifies that Add inserts a node of specified value in proper location
        /// </summary>
        [Fact]
        public void Add_AddsNodeInProperLocation()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Root = new Node(40);
            tree.Root.Left = new Node(20);
            tree.Root.Right = new Node(60);
            tree.Root.Left.Left = new Node(10);
            tree.Root.Left.Right = new Node(30);
            tree.Root.Right.Left = new Node(50);
            tree.Root.Right.Right = new Node(70);

            tree.Add(63);

            int[] values = new int[] { 10, 20, 30, 40, 50, 60, 63, 70 };

            Assert.Equal(values, tree.InOrder());

        }
    }
}
