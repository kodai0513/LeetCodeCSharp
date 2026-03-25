namespace LeetCodeProject.Problems;

public class Q0001 {
    public int[] TwoSum(int[] nums, int target)
    {
        var map = new Dictionary<int, int>();
        for(var i = 0; i < nums.Length; i++)
        {
            var complete = target - nums[i];
            if(map.ContainsKey(complete)) return new int[] { map[complete], i };
            map[nums[i]] = i;
        }

        return Array.Empty<int>();
    }
}