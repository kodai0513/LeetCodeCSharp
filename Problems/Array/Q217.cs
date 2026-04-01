using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeCSharp.Problems.Array
{
    public class Q217
    {
        public bool ContainsDuplicate(int[] nums)
        {
            var histories = new HashSet<int>();
            foreach(var num in nums)
            {
                if(histories.Contains(num))
                {
                    return true;
                }

                histories.Add(num);
            }

            return false;
        }
    }
}