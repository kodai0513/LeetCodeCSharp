/***
insertSearch: 2
 0,1,2,3
[1,3,5,6]

***/

namespace LeetCodeCSharp.Problems
{
    public class Q0035
    {
        public int SearchInsert(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Count() - 1;
            while(left <= right)
            {
                var mid = (int)Math.Floor((left + right) / 2.0);
                if(target > nums[mid])
                {
                    left = mid + 1;
                } else if(target < nums[mid])
                {
                    right = mid - 1;
                } else
                {
                    return mid;
                }
            }

            return left;
        }
    }
}