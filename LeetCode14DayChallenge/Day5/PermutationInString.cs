namespace LeetCode14DayChallenge.Day5
{
    public class PermutationInString
    {
        public static void Solution()
        {
            var s1 = "abab";
            var s2 = "eidbabaooo";

            var result = CheckInclusion(s1, s2);
            var x = result;
        }

        private static bool CheckInclusion(string s1, string s2)
        {
            var charactersToFind = new System.Collections.Generic.Dictionary<char, int>();
            var sumOfCharacters = 0;
            var charArrayCount = new int[(int)'z'];

            for (var i = 0; i < s1.Length; i++)
            {
                charactersToFind[s1[i]] = 1;
                sumOfCharacters += (int)s1[i];
                charArrayCount[(int)s1[i]]++;
            }

            var characterSum = 0;
            var permutationString = "";
            var matchingPermutationStrings = new System.Collections.Generic.List<int[]>();
            var currentCharCount = new int[(int)'z'];

            for (var i = 0; i < s2.Length; i++)
            {
                if (charactersToFind.ContainsKey(s2[i]))
                {
                    characterSum += (int)s2[i];
                    currentCharCount[(int) s2[i]]++;

                    if (characterSum == sumOfCharacters)
                    {
                        matchingPermutationStrings.Add(currentCharCount);
                    }

                    continue;
                }

                characterSum = 0;
                currentCharCount = new System.Collections.Generic.List<int[]>();
            }

            var result = false;

            for (var i = 0; i < matchingPermutationStrings.Count; i++)
            {
                for(var j = (int)'a'; j <= (int)'z'; j++)
                {

                }
            }

            return result;
        }
    }
}
