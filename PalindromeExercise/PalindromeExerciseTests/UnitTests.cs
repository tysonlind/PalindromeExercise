using System;
using Xunit;

namespace PalindromeExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("banana", false)]
        [InlineData("civic", true)]
        [InlineData("Level", true)]
        public void PalindromeTest(string word, bool expected)
        {
            Palindrome pali = new Palindrome();

            var actual = pali.IsPalindrome(word);

            Assert.Equal(expected, actual);

        }
    }
}
