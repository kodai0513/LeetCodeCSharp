using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeCSharp.Problems.Array
{
    public class Q169
    {
        public int MajorityElement(int[] nums)
        {
            var count = 0;
            int candidate = 0;
            foreach(var num in nums)
            {
                if(count == 0)
                {
                    candidate = num;
                    count = 1;
                    continue;
                }

                if(num == candidate)
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }

            return candidate;
        }
    }
}