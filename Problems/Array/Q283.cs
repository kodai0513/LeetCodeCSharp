using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeCSharp.Problems.Array
{
    public class Q283
    {
        public void MoveZeroes(int[] nums)
        {
            var lastNonZeroIndex = 0;
            for(var i = 0; i < nums.Length; i++)
            {
                if(nums[i] != 0)
                {
                    nums[lastNonZeroIndex] = nums[i];
                    lastNonZeroIndex++;
                }
            }

            for(var i = lastNonZeroIndex; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
        }
    }
}