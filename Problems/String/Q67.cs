using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeCSharp.Problems.String
{
    public class Q67
    {
        public string AddBinary(string a, string b)
        {
            var carr = false;
            var result = "";
            for(var i = 0; i < Math.Max(a.Length, b.Length); i++)
            {
                var flagCount = carr ? 1: 0;
                flagCount += a.Length - i - 1 >= 0 ? a[a.Length - i - 1] - '0' : 0;
                flagCount += b.Length - i - 1 >= 0 ? b[b.Length - i - 1] - '0' : 0;

                result = (char)((flagCount % 2) + '0') + result;
                carr = flagCount / 2 >= 1;
            }

            if(carr)
            {
                result = '1' + result;
            }

            return result;
        }
    }
}