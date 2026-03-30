using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeCSharp.Problems.String
{
    public class Q58
    {
        public int LengthOfLastWord(string s)
        {
            int length = 0;
            for (int i = s.Length - 1; i >= 0; i--) {
                if (s[i] != ' ') {
                    length++;
                } else if (length > 0) {
                    break;
                }
            }
            
            return length;
        }
    }
}