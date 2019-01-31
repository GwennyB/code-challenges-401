using System;
using Xunit;
using FindMax;
using FindMax.Classes;

namespace UnitTests
{
    public class UnitTest1
    {
        /// <summary>
        /// verifies that FindMaxValue returns 'null' when tree is empty
        /// </summary>
        [Fact]
        public void FindMaxValue_ReturnsNull()
        {
            BinaryTree tree = new BinaryTree();
            Assert.Null(Program.FindMaxValue(tree.Root));
        }

        /// <summary>
        /// verifies that FindMaxValue returns the correct max when on an internal node
        /// </summary>
        [Fact]
        public void FindMaxValue_ReturnsCorrectMaxAtInternal()
        {
            int[] treeValues = new int[] { 1, 20, 3, 4, 5, 6, 7 };
            BinaryTree tree = Program.BuildBinTree(treeValues);
            Assert.Equal(20,Program.FindMaxValue(tree.Root));
        }

        /// <summary>
        /// verifies that FindMaxValue returns the correct max when on root
        /// </summary>
        [Fact]
        public void FindMaxValue_ReturnsCorrectMaxAtRoot()
        {
            int[] treeValues = new int[] { 20, 2, 3, 4, 5, 6, 7 };
            BinaryTree tree = Program.BuildBinTree(treeValues);
            Assert.Equal(20, Program.FindMaxValue(tree.Root));
        }

        /// <summary>
        /// verifies that FindMaxValue returns the correct max when on leaf
        /// </summary>
        [Fact]
        public void FindMaxValue_ReturnsCorrectMaxAtLeaf()
        {
            int[] treeValues = new int[] { 1, 2, 3, 4, 20, 6, 7 };
            BinaryTree tree = Program.BuildBinTree(treeValues);
            Assert.Equal(20, Program.FindMaxValue(tree.Root));
        }

        /// <summary>
        /// verifies that FindMaxValue returns the correct max when negative
        /// </summary>
        [Fact]
        public void FindMaxValue_ReturnsCorrectMaxNegative()
        {
            int[] treeValues = new int[] { -1, -2, -3, -4, -5, -6, -7 };
            BinaryTree tree = Program.BuildBinTree(treeValues);
            Assert.Equal(-1, Program.FindMaxValue(tree.Root));
        }

        /// <summary>
        /// verifies that FindMaxValue returns the correct max when on leaf
        /// </summary>
        [Fact]
        public void FindMaxValue_ReturnsCorrectMaxAllEqual()
        {
            int[] treeValues = new int[] { 1, 1, 1, 1, 1, 1, 1 };
            BinaryTree tree = Program.BuildBinTree(treeValues);
            Assert.Equal(1, Program.FindMaxValue(tree.Root));
        }
    }
}
