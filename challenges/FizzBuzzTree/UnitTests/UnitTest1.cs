using System;
using Xunit;
using FizzBuzzTree;
using FizzBuzzTree.Classes;

namespace UnitTests
{
    public class UnitTest1
    {
        /// <summary>
        /// verifies that multiples of 15 are found and replaced
        /// </summary>
        /// <param name="value"> location of changed node in return array </param>
        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        public void FizzBuzzTree_FindsAndReplacesWithFizzBuzz(int value)
        {
            BinaryTree tree = Program.BuildBinTree(new BinaryTree());
            Program.FizzBuzzTree(tree.Root);
            Assert.Equal("FizzBuzz", tree.PostOrder()[value]);
        }

        /// <summary>
        /// verifies that multiples of 3 are found and replaced
        /// </summary>
        /// <param name="value"> location of changed node in return array </param>
        [Theory]
        [InlineData(4)]
        public void FizzBuzzTree_FindsAndReplacesWithFizz(int value)
        {
            BinaryTree tree = Program.BuildBinTree(new BinaryTree());
            Program.FizzBuzzTree(tree.Root);
            Assert.Equal("Fizz", tree.PostOrder()[value]);
        }

        /// <summary>
        /// verifies that multiples of 5 are found and replaced
        /// </summary>
        /// <param name="value"> location of changed node in return array </param>
        [Theory]
        [InlineData(0)]
        [InlineData(2)]
        [InlineData(6)]
        public void FizzBuzzTree_FindsAndReplacesWithBuzz(int value)
        {
            BinaryTree tree = Program.BuildBinTree(new BinaryTree());
            Program.FizzBuzzTree(tree.Root);
            Assert.Equal("Buzz", tree.PostOrder()[value]);
        }

        /// <summary>
        /// verifies that strings are left untouched and produce no unhandled exceptions
        /// </summary>
        /// <param name="value"> location of changed node in return array </param>
        [Theory]
        [InlineData(1)]
        public void FizzBuzzTree_LeavesOtherTypesAlone(int value)
        {
            BinaryTree tree = Program.BuildBinTree(new BinaryTree());
            Program.FizzBuzzTree(tree.Root);
            Assert.Equal("test", tree.PostOrder()[value]);
        }
    }
}
