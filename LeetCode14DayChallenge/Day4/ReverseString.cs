using System.Linq;

namespace LeetCode14DayChallenge.Day4
{
    public class ReverseString
    {
        public static void Solution()
        {
            var str = new[] { "H", "A", "N", "n", "a", "h", "1" };

            Reverse(str.Select(i => i[0]).ToArray());
        }

        private static void Reverse(char[] s)
        {
            for (var i = 0; i < (s.Length + 1) / 2; i++)
            {
                var temp = s[i];
                s[i] = s[s.Length - i - 1];
                s[s.Length - i - 1] = temp;
            }

            var str = s;
            var x = str;
        }
    }
}
