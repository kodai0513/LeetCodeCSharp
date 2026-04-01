using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeCSharp.Problems.String
{
    public class Q125
    {
        public bool IsPalindrome(string s)
        {
            var leftIndex = 0;
            var rightIndex = s.Length - 1;

            while(leftIndex < rightIndex)
            {
                if(!IsAlphaNumeric(s[leftIndex]))
                {
                    leftIndex++;
                }
                else if(!IsAlphaNumeric(s[rightIndex]))
                {
                    rightIndex--;
                }
                else
                {
                    if (leftIndex < s.Length && rightIndex >= 0 && char.ToLowerInvariant(s[leftIndex]) != char.ToLowerInvariant(s[rightIndex]))
                    {
                        return false;
                    }
                    leftIndex++;
                    rightIndex--;
                }
            }

            return true;
        }

        public static bool IsAlphaNumeric(char c)
        {
            return (c >= 'a' && c <= 'z') || 
                (c >= 'A' && c <= 'Z') || 
                (c >= '0' && c <= '9');
        }
    }
}