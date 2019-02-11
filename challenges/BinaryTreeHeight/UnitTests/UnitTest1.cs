using System;
using Xunit;
using BinaryTreeHeight;
using BinaryTreeHeight.Classes;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanFindHeightOfImbalancedTree()
        {
            BinaryTree tree = Program.BuildBinTree();

            Assert.Equal(7, Program.CalculateBinaryTreeHeight(tree.Root));
        }

        [Fact]
        public void CanReturnZeroForSingleNode()
        {
            Node node = new Node(1);

            Assert.Equal(0, Program.CalculateBinaryTreeHeight(node));
        }

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
    }
}
