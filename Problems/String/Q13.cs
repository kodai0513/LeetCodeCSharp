using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeCSharp.Problems.String
{
    public class Q13
    {
        public int RomanToInt(string s)
        {
            var romanMap = new Dictionary<char, int>
            {
                ['I'] = 1,
                ['V'] = 5,
                ['X'] = 10,
                ['L'] = 50,
                ['C'] = 100,
                ['D'] = 500,
                ['M'] = 1000
            };

            var ans = 0;
            for(var i = 0; i < s.Length; i++)
            {
                if(i + 1 < s.Length && romanMap[s[i]] < romanMap[s[i + 1]])
                {
                    ans -= romanMap[s[i]];
                }
                else
                {
                    ans += romanMap[s[i]];
                }
                
            }

            return ans;

        }
    }
}