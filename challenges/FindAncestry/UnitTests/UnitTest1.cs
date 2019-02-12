using FindAncestry;
using System;
using tree.Classes;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void ReturnsTrueWhenHeadIsAncestor()
        {
            bool ancestor = Program.IsAncestor(Program.BuildBinTree(), 1, 6);
            Assert.True(ancestor);
        }

        [Fact]
        public void ReturnsTrueWhenInternalNodeIsAncestor()
        {
            bool ancestor = Program.IsAncestor(Program.BuildBinTree(), 3, 6);
            Assert.True(ancestor);
        }

        [Fact]
        public void ReturnsFalseWhenNoAncestry()
        {
            bool ancestor = Program.IsAncestor(Program.BuildBinTree(), 5, 15);
            Assert.False(ancestor);
        }

        [Fact]
        public void ReturnsFalseWhenTreeIsNode()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(0);
            bool ancestor = Program.IsAncestor(tree, 0, 6);
            Assert.False(ancestor);
        }
    }
}
