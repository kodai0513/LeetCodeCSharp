using LeetCodeCSharp.Problems;
using LeetCodeProject.Problems;

var problem = new Q0088();
var nums = new int[] {1,2,3,0,0,0};
problem.Merge(nums, 3, [2,5,6], 3);
foreach(var num in nums)
{
    Console.Write(num);
}