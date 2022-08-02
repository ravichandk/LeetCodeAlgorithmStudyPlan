using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode14DayChallenge.Day4
{
    public class ReverseWords
    {
        public static void Solution()
        {
            var str = "Let's take LeetCode contest";

            var reverseString = Reverse(str);
            var x = reverseString;
        }

        private static string Reverse(string s)
        {
            var reverseString = "";
            var revWord = "";

            for (var i = 0; i < s.Length; i++)
            {
                if (s[i].ToString() == " ")
                {
                    reverseString = reverseString + revWord + " ";
                    revWord = "";
                }
                else
                {
                    revWord = s[i] + revWord;
                }
            }

            reverseString = reverseString + revWord;
            
            return reverseString;
        }

        private static string ReverseWord(string str)
        {
            var firstHalfReverseWord = "";
            var secondHalfReverseWord = "";

            for (var i = 0; i < (str.Length + 1) / 2; i++)
            {
                secondHalfReverseWord += str[str.Length - i - 1];

                if (str.Length % 2 == 1 && i >= (str.Length / 2))
                    continue;

                firstHalfReverseWord = str[i] + firstHalfReverseWord;
            }

            var returnStr = secondHalfReverseWord + firstHalfReverseWord;
            return returnStr;
        }
    }
}
