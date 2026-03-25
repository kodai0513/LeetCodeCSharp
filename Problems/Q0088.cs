using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeCSharp.Problems
{
    public class Q0088
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            var p1 = m - 1;
            var p2 = n - 1;
            for(var i = m + n - 1; i >= 0; i--)
            {
                if (p2 < 0)
                {
                    break;
                }


                if(p1 >= 0 && nums1[p1] > nums2[p2])
                {
                    nums1[i] = nums1[p1];
                    p1--;
                } else
                {
                    nums1[i] = nums2[p2];
                    p2--;
                }
            }
        }
    }
}