using System;
using Xunit;
using tree.Classes;
using tree_intersection;
using System.Collections.Generic;

namespace UnitTests
{
    public class UnitTest1
    {
        /// <summary>
        /// verifies that TreeIntersection returns correct matches in 2 populated trees
        /// </summary>
        [Fact]
        public void CanReturnMatches()
        {
            BinaryTree treeA = Program.BuildBinTree(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            BinaryTree treeB = Program.BuildBinTree(new int[] { 1, -2, 3, -4, 5, -6, 7 });
            List<Object> list = new List<Object>() { "1","3","5","7" };
            Assert.Equal(list, Program.TreeIntersection(treeA, treeB));
        }

        /// <summary>
        /// verifies that TreeIntersection returns empty list when at least 1 tree is empty
        /// </summary>
        [Fact]
        public void CanHandleEmptyTree()
        {
            BinaryTree treeA = Program.BuildBinTree(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            BinaryTree treeB = new BinaryTree();
            List<Object> list = new List<Object>();
            Assert.Equal(list, Program.TreeIntersection(treeA, treeB));
        }

        /// <summary>
        /// verifies that TreeIntersection returns empty list when at least no matches present
        /// </summary>
        [Fact]
        public void CanReturnEmptyListWhenNoMatches()
        {
            BinaryTree treeA = Program.BuildBinTree(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            BinaryTree treeB = Program.BuildBinTree(new int[] { -1, -2, -3, -4, -5, -6, -7 });
            List<Object> list = new List<Object>();
            Assert.Equal(list, Program.TreeIntersection(treeA, treeB));
        }
    }
}
