namespace LeetCodeProject.Problems;

public class Q26 {
    public int RemoveDuplicates(int[] nums)
    {
        var writeIndex = 1;
        for(var i = 1; i < nums.Length; i++)
        {
            if(nums[i] != nums[i - 1])
            {
                nums[writeIndex] = nums[i];
                writeIndex++;
            }
        }
        
        return writeIndex;
    }
}