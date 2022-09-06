using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode75.Day05
{
    public class MinimumSubSequence
    {
        public static void Solution()
        {
            var array = new[] { 3, 4, 2, 6, 3, 1 };
            var result = GetMinimumSubSequence(array);
            var x = result;
        }

        private static long GetMinimumSubSequence(int[] array)
        {
            var minElement = array[0];
            var maxElement = array[0];
            long totalSum = -1;

            foreach(var i in array)
            {
                if (i < minElement)
                    minElement = i;

                if (i > maxElement)
                    maxElement = i;
            }

            for(var i = 0; i < array.Length; i++)
            {
                var minSubSequence = new int[3];
                minSubSequence[0] = array[i];
                var nextMaxElement = maxElement;
                var secondIndex = i;
                var nextElementFound = false;
                
                for (var j = i + 1; j < array.Length; j++)
                {
                    if(array[j] > array[i] && array[j] <= nextMaxElement)
                    {
                        minSubSequence[1] = array[j];
                        nextMaxElement = array[j];
                        secondIndex = j;
                        nextElementFound = true;
                    }
                }

                if (!nextElementFound) continue;

                var nextMinElement = minSubSequence[1];

                for(var k = secondIndex + 1; k < array.Length; k++)
                {
                    if(array[k] < nextMinElement)
                    {
                        minSubSequence[2] = array[k];
                        nextMinElement = array[k];
                        nextElementFound = true;
                    }
                }

                if (!nextElementFound) continue;

                if (minSubSequence[0] <= 0 || minSubSequence[1] <= 0 || minSubSequence[2] <= 0) continue;

                long sum = minSubSequence[0] + minSubSequence[1] + minSubSequence[2];

                if(totalSum == -1 || sum < totalSum)
                {
                    totalSum = sum;
                }
            }

            return totalSum;
        }
    }
}
