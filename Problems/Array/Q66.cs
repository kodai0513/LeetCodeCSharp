using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeCSharp.Problems
{
    public class Q66
    {
        public int[] PlusOne(int[] digits)
        {
            for(var i = digits.Count() - 1; i >= 0; i--)
            {
                var plusOneAfterNum = digits[i] + 1;
                if(plusOneAfterNum <= 9)
                {
                    digits[i] = plusOneAfterNum;
                    return digits;
                }
                digits[i] = 0;
            }

            return [1, ..new int[digits.Length]];
        }
    }
}