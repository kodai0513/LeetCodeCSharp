using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeCSharp.Problems.Array
{
    public class Q119
    {
        public IList<int> GetRow(int rowIndex)
        {
            var rows = new int[rowIndex + 1];
            for(var i = 0; i <= rowIndex; i++)
            {
                var headIndex = 0;
                var tailIndex = i;
                rows[headIndex] = 1;
                rows[tailIndex] = 1;

                var prevValue = rows[0];

                for(var j = 1; j < i; j++)
                {
                    var total = rows[j] + prevValue;
                    prevValue = rows[j];
                    rows[j] = total;
                }
            }

            return rows;
        }
    }
}