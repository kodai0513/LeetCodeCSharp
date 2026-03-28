using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeCSharp.Problems.Array
{
    public class Q118
    {
        public IList<IList<int>> Generate(int numRows)
        {
            var pascal = new List<IList<int>>();
            for(var i = 0; i < numRows; i++)
            {
                var headIndex = 0;
                var tailIndex = i;
                var rows = new List<int>();
                for(var j = 0; j <= i; j++)
                {
                    if(j == headIndex)
                    {
                        rows.Add(1);
                        continue;
                    }
                    
                    if(j == tailIndex)
                    {
                        rows.Add(1);
                        continue;
                    }

                    var prevRows = pascal[i - 1];
                    rows.Add(prevRows[j - 1] + prevRows[j]);
                }

                pascal.Add(rows);
            }

            return pascal;
        }
    }
}