using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PalindromeExercise
{
    //create a method (IsAPalindrome) that will take a parameter of type string and return a 
    //value of type bool.  If the given input is a palindrome – return true, else return false. 
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            //reverse the word 
            var reversed = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversed += word[i];  //reversed = reversed + word 
            }

            //compare the original with thr reverse
            if (reversed.ToLower() == word.ToLower())
            {
                return true;
            }
            else
            {
                return false;
            }

            //return wether they are the same or not
        }
    }
}
