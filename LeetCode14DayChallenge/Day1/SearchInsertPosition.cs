namespace LeetCode14DayChallenge.Day1
{
    public class SearchInsertPosition
    {
        public static void Solution()
        {
            var nums = new[] { 1, 3, 5, 6 };
            var target = 2;

            var result = SearchInsert(nums, target);
            var x = result;
        }

        private static int SearchInsert(int[] nums, int target)
        {
            if (target < nums[0]) return 0;
            if (target > nums[nums.Length - 1]) return nums.Length;

            return FindIndex(nums, 0, nums.Length - 1, target);
        }

        private static int FindIndex(int[] nums, int startIndex, int endIndex, int target)
        {
            if (startIndex > endIndex) return -1;

            var mid = startIndex + ((endIndex - startIndex) / 2);

            if (CheckIndex(nums, mid, target) >= 0) return CheckIndex(nums, mid, target);
            if (CheckIndex(nums, mid - 1, target) >= 0) return CheckIndex(nums, mid - 1, target);
            if (CheckIndex(nums, mid + 1, target) >= 0) return CheckIndex(nums, mid + 1, target);

            if (nums[mid] < target)
                return FindIndex(nums, mid + 1, endIndex, target);
            else if (nums[mid] > target)
                return FindIndex(nums, startIndex, mid - 1, target);

            return -1;
        }

        private static int CheckIndex(int[] nums, int index, int target)
        {
            if (index < 0 || index >= nums.Length) return -1;

            if (nums[index] == target)
                return index;
            else if (index > 0 && nums[index - 1] < target && nums[index] > target)
                return index;
            else if (index > 0 && index < nums.Length - 1
                    && nums[index] < target && nums[index + 1] > target)
                return index + 1;

            return -1;
        }
    }
}
