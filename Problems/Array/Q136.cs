using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeCSharp.Problems.Array
{
    public class Q136
    {
        public int SingleNumber(int[] nums)
        {
            int result = 0;
            foreach (int n in nums) {
                result ^= n; 
            }

            return result;
        }
    }
}