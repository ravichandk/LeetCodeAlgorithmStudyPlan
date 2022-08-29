
namespace LeetCode75.Day01
{
    public class C001_HappyNumbers
    {
        public static void Solution()
        {
            var n = 18;

            var isHappy = IsHappy(n);
            var x = isHappy;
        }

        private static bool IsHappy(int n)
        {
            var digitDictionary = new System.Collections.Generic.Dictionary<int, int>();

            bool isHappy;
            var digitSum = SumOfDigits(n);

            while (true)
            {
                if (digitDictionary.ContainsKey(digitSum))
                {
                    isHappy = false;
                    break;
                }

                if (digitSum == 1)
                {
                    isHappy = true;
                    break;
                }

                digitDictionary[digitSum] = 1;
                digitSum = SumOfDigits(digitSum);
            }

            return isHappy;
        }

        private static int SumOfDigits(int n)
        {
            var digitSum = 0;

            for(var i = 0; i < n.ToString().Length; i++)
            {
                int.TryParse(n.ToString()[i].ToString(), out var digit);

                digitSum += digit * digit;
            }

            return digitSum;
        }
    }
}
