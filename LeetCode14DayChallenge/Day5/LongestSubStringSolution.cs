namespace LeetCode14DayChallenge.Day5
{
    public class LongestSubStringSolution
    {
        public static void Solution()
        {
            //var str = "abcabcbb";
            //var str = "pwwkew";
            //var str = "bbbbb";
            //var str = "dvdf";
            //var str = "abbacc";

            var result1 = LengthOfLongestSubstring("abcabcbb");
            var result2 = LengthOfLongestSubstring("pwwkew");
            var result3 = LengthOfLongestSubstring("bbbbb");
            var result4 = LengthOfLongestSubstring("dvdf");
            var result5 = LengthOfLongestSubstring("abbacc");

            var x = result1;
        }

        private static int LengthOfLongestSubstring(string s)
        {
            var maxLength = 0;
            var continousStringLength = 0;
            var existingChars = new System.Collections.Generic.Dictionary<char, int>();
            var lastValidIndex = 0;

            for (var i = 0; i < s.Length; i++)
            {
                if(existingChars.ContainsKey(s[i]))
                {
                    if(lastValidIndex < existingChars[s[i]])
                    {
                        lastValidIndex = existingChars[s[i]];
                    }
                    
                    if(continousStringLength > maxLength)
                    {
                        maxLength = continousStringLength;
                    }
                    continousStringLength = i > lastValidIndex ? i - lastValidIndex - 1 : 0;
                }

                existingChars[s[i]] = i;
                continousStringLength++;
            }

            if(continousStringLength > maxLength)
            {
                maxLength = continousStringLength;
            }

            return maxLength;
        }
    }
}
