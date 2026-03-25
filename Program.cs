using LeetCodeCSharp.Problems;
using LeetCodeProject.Problems;

var problem = new Q0066();
var nums = new int[] {9, 9, 9};
var answer = problem.PlusOne(nums);
foreach(var num in answer)
{
    Console.Write(num);
}