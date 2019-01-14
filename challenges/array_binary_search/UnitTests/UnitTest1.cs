using System;
using Xunit;
using array_binary_search;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void FindMiddle_ReturnsIndexOdd()
        {
            Assert.Equal(2, Program.FindMiddle(0,4));
        }

        [Fact]
        public void FindMiddle_ReturnsIndexEven()
        {
            Assert.Equal(3, Program.FindMiddle(0, 5));
        }

        [Fact]
        public void FindMiddle_ReturnsIndexEmpty()
        {
            Assert.Equal(0, Program.FindMiddle(0, 0));
        }

        [Fact]
        public void CompareToKey_ReturnsMatch()
        {
            Assert.Equal("match", Program.CompareToKey(5,5));
        }

        [Fact]
        public void CompareToKey_ReturnsLower()
        {
            Assert.Equal("lower", Program.CompareToKey(5, 6));
        }

        [Fact]
        public void CompareToKey_ReturnsHigher()
        {
            Assert.Equal("higher", Program.CompareToKey(5, 4));
        }

        [Fact]
        public void BinarySearch_ReturnsFoundIndex()
        {
            int[] testArray = { 0, 1, 0 };
            Assert.Equal(1, Program.BinarySearch(testArray,1));
        }

        [Fact]
        public void BinarySearch_ReturnsFirstMatch()
        {
            int[] testArray = { 0, 1, 1, 0 };
            Assert.Equal(2, Program.BinarySearch(testArray,1));
        }

        [Fact]
        public void BinarySearch_ReturnsMinusOne()
        {
            int[] testArray = { 0, 1, 1, 0 };
            Assert.Equal(-1, Program.BinarySearch(testArray, 2));
        }
    }
}
