using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeCSharp.Problems.Array
{
    public class Q268
    {
        public int MissingNumber(int[] nums)
        {
            var expect = nums.Length * (nums.Length + 1) / 2;
            var act = 0;
            foreach(var num in nums)
            {
                act += num;
            }

            return expect - act;
        }
    }
}