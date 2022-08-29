namespace LeetCode14DayChallenge.Day6
{
    public class IslandMaxArea
    {
        public static void Solution()
        {
            var grid = new int[][]
            {
                new [] {0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0},
                new [] {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
                new [] {0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0},
                new [] {0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 0, 0},
                new [] {0, 1, 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 0},
                new [] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
                new [] {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
                new [] {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0 }
            };

            var result = MaxAreaOfIsland(grid);
            var x = result;
        }

        private static int MaxAreaOfIsland(int[][] grid)
        {
            var result = 0;



            return result;
        }
    }
}
