namespace LeetCode14DayChallenge.Day1
{
    public class BinarySearch
    {
        public static void Solution()
        {
            var nums = new[] { -1, 0, 3, 5, 9, 12 };
            var target = 2;

            var result = Search(nums, target);
            var x = result;
        }

        private static int Search(int[] nums, int target)
        {
            var result = -1;

            if (nums.Length <= 0 || nums.Length > 10000) return result;

            result = FindIndex(nums, 0, nums.Length - 1, target);

            return result;
        }

        private static int FindIndex(int[] nums, int startIndex, int endIndex, int target)
        {
            if (startIndex > endIndex) return -1;

            var mid = startIndex + ((endIndex - startIndex) / 2);

            if (mid < 0 || mid >= nums.Length) return -1;

            if (mid >= 0 && mid <= nums.Length - 1 && nums[mid] == target)
                return mid;
            else if (mid - 1 >= 0 && mid - 1 <= nums.Length - 1 && nums[mid - 1] == target)
                return mid - 1;
            else if (mid + 1 >= 0 && mid + 1 <= nums.Length - 1 && nums[mid + 1] == target)
                return mid + 1;

            if (nums[mid] < target)
                return FindIndex(nums, mid + 1, endIndex, target);
            else if (nums[mid] > target)
                return FindIndex(nums, startIndex, mid - 1, target);

            return -1;
        }
    }
}
