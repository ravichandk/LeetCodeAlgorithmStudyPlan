namespace LeetCode75.Day02
{
    public class C001_LongestCommonPrefix
    {
        public static void Solution()
        {
            //var strs = new[] { "flower", "flow", "floight" };
            var strs = new[] { "dog", "racecar", "car" };

            var longestPrefix = LongestCommonPrefix(strs);
            var x = longestPrefix;
        }

        private static string LongestCommonPrefix(string[] strs)
        {
            var output = "";
            var maxPrefixLength = 0;

            var prefixDictionary = new System.Collections.Generic.Dictionary<string, int>();

            for (var i = 0; i < strs.Length; i++)
            {
                var currentString = strs[i];
                var prefix = "";

                for (var j = 0; j < currentString.Length; j++)
                {
                    prefix += currentString[j].ToString();

                    if(!prefixDictionary.ContainsKey(prefix))
                    {
                        prefixDictionary[prefix] = 0;
                    }

                    prefixDictionary[prefix]++;
                }
            }

            foreach(var item in prefixDictionary)
            {
                if (item.Value < strs.Length) continue;

                if (item.Key.Length > maxPrefixLength)
                {
                    maxPrefixLength = item.Key.Length;
                    output = item.Key;
                }
            }

            return output;
        }
    }
}
