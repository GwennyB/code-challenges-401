using System;
using Xunit;
using repeated_word;

namespace UnitTests
{
    public class UnitTest1
    {
        /// <summary>
        /// verifies that are found regardless of case
        /// </summary>
        [Theory]
        [InlineData(" dog cat dog bird ")]
        [InlineData(" Dog cat Dog bird ")]
        [InlineData(" DOG cat DOG bird ")]
        [InlineData(" DOG cat dog bird ")]
        public void CanFindDuplicateWithCaseDifferences(string line)
        {
            Assert.Equal("dog", Program.RepeatedWord(line));
        }

        /// <summary>
        /// verifies that are found regardless of punctuation
        /// </summary>
        [Theory]
        [InlineData(" dog cat dog bird ")]
        [InlineData(" dog, cat dog, bird ")]
        [InlineData(" dog: cat ,dog bird ")]
        [InlineData(" :dog; cat ,,(dog) bird ")]
        public void CanFindDuplicateWithPunctuation(string line)
        {
            Assert.Equal("dog", Program.RepeatedWord(line));
        }

        /// <summary>
        /// verifies that 'no repeats found' message is returned when no duplicates present
        /// </summary>
        [Fact]
        public void CanReturnMessageWhenNoDuplicate()
        {
            string line = "no duplicates in this line";
            Assert.Equal("no repeats found", Program.RepeatedWord(line));
        }
    }
}
