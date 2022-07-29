namespace LeetCode14DayChallenge.Day1
{
    public class BadVersion : VersionControl
    {
        private static int _numberOfVersions = 1;
        private static int _badVersion = 1;

        public BadVersion() : base(_badVersion)
        {

        }

        public void Solution()
        {
            var result = FindBadVersion(1, _numberOfVersions);
            var x = result;
        }
    
        private int FindBadVersion(int start, int end)
        {
            if (start > end) return -1;

            var mid = start + ((end - start) / 2);

            if (!IsBadVersion(mid - 1) && IsBadVersion(mid))
                return mid;
            else if (!IsBadVersion(mid) && IsBadVersion(mid + 1))
                return mid + 1;

            if (IsBadVersion(mid))
                return FindBadVersion(start, mid - 1);
            else if (!IsBadVersion(mid))
                return FindBadVersion(mid + 1, end);

            return -1;
        }
    }

    public abstract class VersionControl
    {
        private readonly int _badVersion;

        public VersionControl(int badVersion)
        {
            _badVersion = badVersion;
        }

        public bool IsBadVersion(int version)
        {
            return version >= _badVersion;
        }
    }
}
