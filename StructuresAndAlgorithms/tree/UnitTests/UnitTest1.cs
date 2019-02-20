using System;
using Xunit;
using tree.Classes;
using linked_list.Classes;

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
        /// verifies that InOrder returns null list when tree empty
        /// </summary>
        [Fact]
        public void InOrder_ReturnsEmptyListWhenEmpty()
        {
            BinaryTree tree = new BinaryTree();

            int[] values = new int[] {  };

            Assert.Equal(values, tree.InOrder());
        }

        /// <summary>
        /// verifies that InOrder returns empty list when tree empty
        /// </summary>
        [Fact]
        public void InOrder_ReturnsProperOrderWhenImbalanced()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);
            //tree.Root.Left.Left = new Node(4);
            tree.Root.Left.Right = new Node(5);
            //tree.Root.Right.Left = new Node(6);
            tree.Root.Right.Right = new Node(7);

            int[] values = new int[] { 2, 5, 1, 3, 7 };

            Assert.Equal(values, tree.InOrder());
        }

        /// <summary>
        /// verifies that PreOrder returns an array in the expected order when tree is imbalanced
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
        /// verifies that PreOrder returns empty list when tree empty
        /// </summary>
        [Fact]
        public void PreOrder_ReturnsEmptyListWhenEmpty()
        {
            BinaryTree tree = new BinaryTree();

            int[] values = new int[] {  };

            Assert.Equal(values, tree.PreOrder());
        }

        /// <summary>
        /// verifies that PreOrder returns an array in the expected order when tree is imbalanced
        /// </summary>
        [Fact]
        public void PreOrder_ReturnsProperOrderWhenImbalanced()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);
            //tree.Root.Left.Left = new Node(4);
            tree.Root.Left.Right = new Node(5);
            //tree.Root.Right.Left = new Node(6);
            tree.Root.Right.Right = new Node(7);

            int[] values = new int[] { 1, 2, 5, 3, 7 };

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
        /// verifies that PostOrder returns empty list when tree empty
        /// </summary>
        [Fact]
        public void PostOrder_ReturnsEmptyListWhenEmpty()
        {
            BinaryTree tree = new BinaryTree();

            int[] values = new int[] {  };

            Assert.Equal(values, tree.PostOrder());
        }

        /// <summary>
        /// verifies that PostOrder returns an array in the expected order when tree is imbalanced
        /// </summary>
        [Fact]
        public void PostOrder_ReturnsProperOrderWhenImbalanced()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);
            //tree.Root.Left.Left = new Node(4);
            tree.Root.Left.Right = new Node(5);
            tree.Root.Right.Left = new Node(6);
            //tree.Root.Right.Right = new Node(7);

            int[] values = new int[] { 5, 2, 6, 3, 1 };

            Assert.Equal(values, tree.PostOrder());
        }

        /// <summary>
        /// verifies that Contains returns 'true' when value is present on leaf node
        /// </summary>
        [Fact]
        public void Contains_ReturnsTrueOnInternalNode()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Root = new Node(40);
            tree.Root.Left = new Node(20);
            tree.Root.Right = new Node(60);
            tree.Root.Left.Left = new Node(10);
            tree.Root.Left.Right = new Node(30);
            tree.Root.Right.Left = new Node(50);
            tree.Root.Right.Right = new Node(70);

            Assert.True(tree.Contains(50));
        }

        /// <summary>
        /// verifies that Contains returns 'true' when value is present on root node
        /// </summary>
        [Fact]
        public void Contains_ReturnsTrueOnRootNode()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Root = new Node(40);
            tree.Root.Left = new Node(20);
            tree.Root.Right = new Node(60);
            tree.Root.Left.Left = new Node(10);
            tree.Root.Left.Right = new Node(30);
            tree.Root.Right.Left = new Node(50);
            tree.Root.Right.Right = new Node(70);

            Assert.True(tree.Contains(40));
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
        /// verifies that Add inserts a new node smaller than all others
        /// </summary>
        [Fact]
        public void Add_AddsNewSmallestNode()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Root = new Node(40);
            tree.Root.Left = new Node(20);
            tree.Root.Right = new Node(60);
            tree.Root.Left.Left = new Node(10);
            tree.Root.Left.Right = new Node(30);
            tree.Root.Right.Left = new Node(50);
            tree.Root.Right.Right = new Node(70);

            tree.Add(5);

            int[] values = new int[] { 5, 10, 20, 30, 40, 50, 60, 70 };

            Assert.Equal(values, tree.InOrder());
        }

        /// <summary>
        /// verifies that Add inserts a new node larger than all others
        /// </summary>
        [Fact]
        public void Add_AddsNewLargestNode()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Root = new Node(40);
            tree.Root.Left = new Node(20);
            tree.Root.Right = new Node(60);
            tree.Root.Left.Left = new Node(10);
            tree.Root.Left.Right = new Node(30);
            tree.Root.Right.Left = new Node(50);
            tree.Root.Right.Right = new Node(70);

            tree.Add(75);

            int[] values = new int[] { 10, 20, 30, 40, 50, 60, 70,75 };

            Assert.Equal(values, tree.InOrder());
        }

        /// <summary>
        /// verifies that Add does not add duplicate node
        /// </summary>
        [Fact]
        public void Add_RejectsDuplicate()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Root = new Node(40);
            tree.Root.Left = new Node(20);
            tree.Root.Right = new Node(60);
            tree.Root.Left.Left = new Node(10);
            tree.Root.Left.Right = new Node(30);
            tree.Root.Right.Left = new Node(50);
            tree.Root.Right.Right = new Node(70);

            tree.Add(20);

            int[] values = new int[] { 10, 20, 30, 40, 50, 60, 70 };

            Assert.Equal(values, tree.InOrder());
        }
    }
}
