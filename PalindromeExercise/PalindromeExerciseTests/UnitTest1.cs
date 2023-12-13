using PalindromeExercise;
using System;
using Xunit;
using Xunit.Sdk;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("civic", true)]
        [InlineData("Mom", true)]
        [InlineData("level", true)]
        [InlineData("Radar", true)]
        [InlineData("frank", false)]
        [InlineData("", false)]
        [InlineData("song", false)]
        [InlineData(null, false)]

        public void Test1(string word, bool expected)
        {
            //Arrange
            var ws = new WordSmith();

            //Act
            var actual = ws.IsAPalindrome(word);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
