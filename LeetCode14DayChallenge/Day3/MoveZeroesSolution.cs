namespace LeetCode14DayChallenge.Day3
{
    public class MoveZeroesSolution
    {
        public static void Solution()
        {
            //var nums = new[] { 0, 1, 0, 3, 12 };
            var nums = new[] { 0 };

            MoveZeroes(nums);
        }

        private static void MoveZeroes(int[] nums)
        {
            if (nums.Length <= 0 || nums.Length > 10000) return;

            var zeroesCount = 0;
            var newArray = new int[nums.Length];
            var newArrayIndex = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    zeroesCount++;
                    continue;
                }

                newArray[newArrayIndex++] = nums[i];
            }

            for (var i = 0; i < zeroesCount; i++)
            {
                newArray[newArrayIndex++] = 0;
            }

            for(var i = 0; i < nums.Length; i++)
            {
                nums[i] = newArray[i];
            }

            var x = nums;
        }
    }
}
