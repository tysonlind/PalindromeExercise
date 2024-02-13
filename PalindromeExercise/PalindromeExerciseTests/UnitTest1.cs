using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
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
