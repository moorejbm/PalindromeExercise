using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        //	Write you test method in the UnitTest1.cs file 

        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        [InlineData("Racecar", true)]
        public void MyTest(string word, bool expected)
        {
            //arranged
            var tester = new WordSmith();
            //act
            bool actual = tester.IsAPalindrome(word);

            //assert
            Assert.Equal(expected, actual);


        }
    }
}
