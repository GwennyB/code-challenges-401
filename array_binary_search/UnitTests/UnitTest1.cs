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
    }
}
