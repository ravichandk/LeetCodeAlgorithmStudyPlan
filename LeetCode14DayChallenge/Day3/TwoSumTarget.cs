namespace LeetCode14DayChallenge.Day3
{
    public class TwoSumTarget
    {
        public static void Solution()
        {
            //var numbers = new[] { 2, 7, 11, 15 };
            //var target = 9;

            //var numbers = new[] { 2, 3, 4 };
            //var target = 6;

            //var numbers = new[] { -1, 0 };
            //var target = -1;

            var numbers = new[] { -1000, -1, 0, 1  };
            var target = 1;

            var result = TwoSum(numbers, target);
            var x = result;
        }

        private static int[] TwoSum(int[] numbers, int target)
        {
            if (numbers.Length < 2 || numbers.Length > 30000) return null;

            var result = new int[2];

            var positiveIndexPointer = new int[2001];
            var negativeIndexPointer = new int[2001];

            for (var i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] >= 0)
                {
                    positiveIndexPointer[numbers[i]] = i + 1;
                }
                else
                {
                    negativeIndexPointer[numbers[i] * -1] = i + 1;
                }
            }

            for (var i = 0; i < numbers.Length; i++)
            {
                var diff = target - numbers[i];

                if (diff >= 0 && positiveIndexPointer[diff] > 0)
                {
                    return new[] { i + 1, positiveIndexPointer[diff]};
                }
                else if(diff < 0 && negativeIndexPointer[diff * -1] > 0)
                {
                    return new[] { i + 1, negativeIndexPointer[diff * -1] };
                }
            }

            return result;
        }
    }
}
