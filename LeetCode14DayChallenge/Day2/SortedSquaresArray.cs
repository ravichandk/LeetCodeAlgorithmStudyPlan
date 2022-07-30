namespace LeetCode14DayChallenge.Day2
{
    public class SortedSquaresArray
    {
        public static void Solution()
        {
            //var nums = new[] { -4, -1, 0, 3, 10 };
            var nums = new[] { -7, -3, 2, 3, 11 };

            var result = SortedSquares(nums);

            var x = result;
        }

        private static int[] SortedSquares(int[] nums)
        {
            var squaresArray = new int[nums.Length];

            var indexOfZero = FindIndexOfChangingFromNegativeToPositive(nums, 0, nums.Length - 1);

            if (indexOfZero == -1 && nums[nums.Length - 1] < 0)
            {
                var j = 0;
                for (var i = nums.Length - 1; i >= 0; i--)
                {
                    squaresArray[j++] = nums[i] * nums[i];
                }
            }
            else if (indexOfZero == -1 && nums[0] >= 0)
            {
                for (var i = 0; i <= nums.Length - 1; i++)
                {
                    squaresArray[i] = nums[i] * nums[i];
                }
            }
            else
            {
                var leftIndex = indexOfZero;
                var rightIndex = indexOfZero + 1;

                var index = 0;

                while (leftIndex >= 0 || rightIndex <= nums.Length - 1)
                {
                    if(leftIndex >= 0 && rightIndex > nums.Length - 1)
                    {
                        squaresArray[index++] = nums[leftIndex] * nums[leftIndex];
                        leftIndex--;
                    }
                    else if(leftIndex < 0 && rightIndex <= nums.Length - 1)
                    {
                        squaresArray[index++] = nums[rightIndex] * nums[rightIndex];
                        rightIndex++;
                    }
                    else if(System.Math.Abs(nums[leftIndex]) <= System.Math.Abs(nums[rightIndex]))
                    {
                        squaresArray[index++] = nums[leftIndex] * nums[leftIndex];
                        leftIndex--;
                    }
                    else
                    {
                        squaresArray[index++] = nums[rightIndex] * nums[rightIndex];
                        rightIndex++;
                    }
                }
            }

            return squaresArray;
        }

        private static int FindIndexOfChangingFromNegativeToPositive(int[] nums, int startIndex, int endIndex)
        {
            if (startIndex > endIndex) return -1;

            var mid = startIndex + ((endIndex - startIndex) / 2);

            if (mid < 0 || mid >= nums.Length) return -1;

            if (mid >= 0 && mid < nums.Length - 1 && nums[mid] < 0 && nums[mid + 1] >= 0)
                return mid;
            else if (mid - 1 >= 0 && mid - 1 < nums.Length - 1 && nums[mid - 1] < 0 && nums[mid] >= 0)
                return mid - 1;

            if (nums[mid] < 0)
                return FindIndexOfChangingFromNegativeToPositive(nums, mid + 1, endIndex);
            else if (nums[mid] >= 0)
                return FindIndexOfChangingFromNegativeToPositive(nums, startIndex, mid - 1);

            return -1;
        }
    }
}
