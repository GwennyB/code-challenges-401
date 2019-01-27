using System;
using Xunit;
using MultiBracketValidationChallenge;

namespace UnitTests
{
    public class UnitTest1
    {
        /// <summary>
        /// verifies that method returns 'true' when passed strings containing balanced brackets or no brackets
        /// </summary>
        /// <param name="value"> string to check </param>
        [Theory]
        [InlineData("")]
        [InlineData("BBBBB")]
        [InlineData("{}")]
        [InlineData("{}(){}")]
        [InlineData("()[[Extra Characters]]")]
        [InlineData("(){}[[]]")]
        [InlineData("{}{Code}[Fellows](())")]
        public void MultiBracketValidation_ReturnsTrueWhenBracketsBalanced(string value)
        {
            Assert.True(Program.MultiBracketValidation(value));
        }

        /// <summary>
        /// verifies that method returns 'false' when passed strings containing imbalanced brackets
        /// </summary>
        /// <param name="value"> string to check </param>
        [Theory]
        [InlineData("[({}]")]
        [InlineData("[B(B{B}B]B")]
        [InlineData("(](")]
        [InlineData("~(~]~(~")]
        [InlineData("{(})")]
        [InlineData("/{/(/}/)/")]
        public void MultiBracketValidation_ReturnsFalseWhenBracketsImbalanced(string value)
        {
            Assert.False(Program.MultiBracketValidation(value));
        }
    }
}
