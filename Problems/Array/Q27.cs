namespace LeetCodeProject.Problems;

/*
nums = [1,2,3,3,4] val = 3
[1,2,4,3,3]
replaceIndex = 2
*/

public class Q27 {
    public int RemoveElement(int[] nums, int val) {
        if (nums.Length == 0) return 0;

        int i = 0;
        int n = nums.Length;
        
        while (i < n) {
            if (nums[i] == val) {
                nums[i] = nums[n - 1];
                n--;
            } else {
                i++;
            }
        }
        return n;
    }
}