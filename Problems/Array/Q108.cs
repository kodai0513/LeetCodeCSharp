using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/**
[1, 2, 3, 4, 5]

*/

namespace LeetCodeCSharp.Problems
{

    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null) {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    
    public class Q108
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            if(nums.Count() == 0)
            {
                return null;
            }

            var mid = (int)Math.Floor(nums.Count() / 2.0);
            var rootNode = new TreeNode(nums[mid]);

            rootNode.left = SortedArrayToBST(nums[..mid]);
            rootNode.right = SortedArrayToBST(nums[(mid+1)..]);

            return rootNode;
        }
    }

    /** より高速化したバージョン
    public class Solution {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            return Helper(nums, 0, nums.Length - 1);
        }

        private TreeNode Helper(int[] nums, int left, int right) {
            if (left > right) return null;

            int mid = left + (right - left) / 2;
            
            TreeNode rootNode = new TreeNode(nums[mid]);
            rootNode.left = Helper(nums, left, mid - 1);
            rootNode.right = Helper(nums, mid + 1, right);

            return rootNode;
        }
    }
    */
}