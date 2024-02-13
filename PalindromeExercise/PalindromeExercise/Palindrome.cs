using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class Palindrome
    {
        public bool IsPalindrome(string str)
        {
            string[] strArr = str.ToLower().Split();
            string[] strArrRev = strArr.Reverse().ToArray();

            for (int i = 0; i < strArr.Length; i++)
            {
                if (strArr[i] != strArrRev[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
