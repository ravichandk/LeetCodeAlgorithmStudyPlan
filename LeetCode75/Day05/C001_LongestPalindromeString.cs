namespace LeetCode75.Day05
{
    public class C001_LongestPalindromeString
    {
        public static void Solution()
        {
            var longestString = 0;

            longestString = LongestPalindrome(new[] { "lc", "cl", "gg" });
            longestString = LongestPalindrome(new[] { "ab", "ty", "yt", "lc", "cl", "ab" });
            longestString = LongestPalindrome(new[] { "nn", "nn", "hg", "gn", "nn", "hh", "gh", "nn", "nh", "nh" });
            longestString = LongestPalindrome(new[] { "dd", "aa", "bb", "dd", "aa", "dd", "bb", "dd", "aa", "cc", "bb", "cc", "dd", "cc" });
            longestString = LongestPalindrome(new[] { "qo", "fo", "fq", "qf", "fo", "ff", "qq", "qf", "of", "of", "oo", "of", "of", "qf", "qf", "of" });

            var result = longestString;
        }

        private static int LongestPalindrome(string[] words)
        {
            var wordsProcessed = new System.Collections.Generic.Dictionary<string, int>();
            var pairOfWords = new System.Collections.Generic.List<string>();
            var sameLetterWords = new System.Collections.Generic.List<string>();

            foreach(var word in words)
            {
                if(word[0] == word[1])
                {
                    if(wordsProcessed.ContainsKey(word))
                    {
                        pairOfWords.Add(word);
                        sameLetterWords.Remove(word);
                        wordsProcessed.Remove(word);
                    }
                    else
                    {
                        sameLetterWords.Add(word);
                        wordsProcessed[word] = 1;
                    }
                    continue;
                }

                var reverseWord = $"{word[1]}{word[0]}";

                if (wordsProcessed.ContainsKey(reverseWord))
                {
                    pairOfWords.Add(reverseWord);
                    wordsProcessed[reverseWord]--;
                    
                    if (wordsProcessed[reverseWord] == 0)
                        wordsProcessed.Remove(reverseWord);

                    continue;
                }

                if (!wordsProcessed.ContainsKey(word))
                    wordsProcessed[word] = 0;
                wordsProcessed[word]++;
            }

            return (pairOfWords.Count * 4) + (sameLetterWords.Count > 0 ? 2 : 0);
        }
    }
}
