
using System.Collections.Generic;
using System.Linq;

namespace LeetCode75.Day01
{
    public class C002_SpiralOrder
    {
        public static void Solution()
        {
            //var matrix = new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } };
            //var matrix = new[] { new[] { 1, 2, 3, 4, 5, 6 }, new[] { 7, 8, 9, 10, 11, 12 }, new[] { 13, 14, 15, 16, 17, 18}, new[] { 19, 20, 21, 22, 23, 24 } };
            var matrix = new[] { new[] { 3 }, new[] { 2 }};

            var orderedMatrix = SpiralOrder(matrix);
            System.Console.WriteLine(string.Join(",", orderedMatrix.ToArray()));
            var x = orderedMatrix;
        }

        private static IList<int> SpiralOrder(int[][] matrix)
        {
            //GetNumbers(matrix[0], matrix[matrix.Length - 1 - 0]);

            var numbers = new List<int>();
            var j = 0;

            var rowLength = matrix.Length;
            var columnLength = matrix[0].Length;
            var indexesCovered = new Dictionary<string, string>();

            while (true)
            {
                if (j > rowLength - 1 - j) break;

                var firstRow = matrix[j];
                var lastRow = matrix[rowLength - 1 - j];
                var shouldBreak = false;

                for (var i = j; i < firstRow.Length - j; i++)
                {
                    var currentIndexCovered = $"{j}_{i}";
                    if (indexesCovered.ContainsKey(currentIndexCovered))
                    {
                        shouldBreak = true;
                        break;
                    }

                    numbers.Add(firstRow[i]);
                    indexesCovered[currentIndexCovered] = "true";
                }

                for (var i = j + 1; i <= rowLength - 2 - j; i++)
                {
                    var currentIndexCovered = $"{i}_{columnLength - 1 - j}";
                    if (indexesCovered.ContainsKey(currentIndexCovered))
                    {
                        shouldBreak = true;
                        break;
                    }

                    numbers.Add(matrix[i][columnLength - 1 - j]);
                    indexesCovered[currentIndexCovered] = "true";
                }

                for (var i = lastRow.Length - 1 - j; i >= j; i--)
                {
                    var currentIndexCovered = $"{rowLength - 1 - j}_{i}";
                    if (indexesCovered.ContainsKey(currentIndexCovered))
                    {
                        shouldBreak = true;
                        break;
                    }

                    numbers.Add(lastRow[i]);
                    indexesCovered[currentIndexCovered] = "true";
                }

                for (var i = rowLength - 2 - j; i >= j + 1; i--)
                {
                    var currentIndexCovered = $"{i}_{j}";
                    if (indexesCovered.ContainsKey(currentIndexCovered))
                    {
                        shouldBreak = true;
                        break;
                    }

                    numbers.Add(matrix[i][j]);
                    indexesCovered[currentIndexCovered] = "true";
                }

                if (shouldBreak) break;
                j++;
            }

            return numbers;
        }
    }
}
