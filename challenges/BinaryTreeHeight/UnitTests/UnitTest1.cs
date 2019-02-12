using System;
using Xunit;
using BinaryTreeHeight;
using BinaryTreeHeight.Classes;

namespace UnitTests
{
    public class UnitTest1
    {
        /// <summary>
        /// verifies that height of a non-null, non-linear, imbalanced tree can be found
        /// </summary>
        [Fact]
        public void CanFindHeightOfImbalancedTree()
        {
            BinaryTree tree = Program.BuildBinTree();

            Assert.Equal(7, Program.CalculateBinaryTreeHeight(tree.Root));
        }

        /// <summary>
        /// verifes that a single node is counted as height=0
        /// </summary>
        [Fact]
        public void CanReturnZeroHeightForSingleNode()
        {
            Node node = new Node(1);

            Assert.Equal(0, Program.CalculateBinaryTreeHeight(node));
        }

        /// <summary>
        /// verifies that a single-path tree (ie - linked list) returns accurate height
        /// </summary>
        [Fact]
        public void CanFindHeightOfLinkedList()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.Left = new Node(1);
            tree.Root.Left.Left = new Node(1);
            tree.Root.Left.Left.Left = new Node(1);
            tree.Root.Left.Left.Left.Left = new Node(1);
            tree.Root.Left.Left.Left.Left.Left = new Node(1);

            Assert.Equal(5, Program.CalculateBinaryTreeHeight(tree.Root));
        }

        /// <summary>
        /// verifies that # levels of a non-null, non-linear, imbalanced tree can be found
        /// </summary>
        [Fact]
        public void CanFindLevelsOfImbalancedTree()
        {
            BinaryTree tree = Program.BuildBinTree();

            Assert.Equal(8, Program.CalculateBinTreeLevels(tree.Root));
        }

        /// <summary>
        /// verifes that a single node is counted as single level
        /// </summary>
        [Fact]
        public void CanReturnOneLevelForSingleNode()
        {
            Node node = new Node(1);

            Assert.Equal(1, Program.CalculateBinTreeLevels(node));
        }

        /// <summary>
        /// verifies that a single-path tree (ie - linked list) returns height = # nodes
        /// </summary>
        [Fact]
        public void CanFindLevelsOfLinkedList()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.Left = new Node(1);
            tree.Root.Left.Left = new Node(1);
            tree.Root.Left.Left.Left = new Node(1);
            tree.Root.Left.Left.Left.Left = new Node(1);
            tree.Root.Left.Left.Left.Left.Left = new Node(1);

            Assert.Equal(6, Program.CalculateBinTreeLevels(tree.Root));
        }
    }
}
