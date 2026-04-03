using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeCSharp.Problems.Array
{
    public class Q219
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            var valueToIndex = new Dictionary<int, int>();
            for(var i = 0; i < nums.Length; i++)
            {
                if(!valueToIndex.ContainsKey(nums[i]))
                {
                    valueToIndex.Add(nums[i], i);
                    continue;
                }

                if(Math.Abs(valueToIndex[nums[i]] - i) <= k)
                {
                    return true;
                }
                else
                {
                    valueToIndex[nums[i]] = i;
                }
            }

            return false;
        }
    }
}