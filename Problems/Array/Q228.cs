using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeCSharp.Problems.Array
{
    public class Q228
    {
        public IList<string> SummaryRanges(int[] nums)
        {
            if(nums.Length == 0)
            {
                return [];
            }
            var smallestSortedRange = new List<string>();
            for (int i = 0; i < nums.Length; i++)
            {
                var start = nums[i];

                while(i + 1 < nums.Length && nums[i] + 1 == nums[i + 1])
                {
                    i++;
                }

                if(start == nums[i])
                {
                    smallestSortedRange.Add(start.ToString());
                }
                else
                {
                    smallestSortedRange.Add($"{start}->{nums[i]}");
                }
            }

            return smallestSortedRange;
        }
    }
}