using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeCSharp.Problems.String
{
    public class Q28
    {
        public int StrStr(string haystack, string needle)
        {
            if(haystack.Length < needle.Length)
            {
                return - 1;
            }

            for(var i = 0; i <= haystack.Length - needle.Length; i++)
            {
                if(haystack[i] == needle[0])
                {
                    if(haystack[i..(i + needle.Length)] == needle)
                    {
                        return i;
                    }
                }
                
            }

            return -1;
        }
    }
}