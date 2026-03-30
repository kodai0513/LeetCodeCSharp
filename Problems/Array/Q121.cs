using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeCSharp.Problems.Array
{
    public class Q121
    {
        public int MaxProfit(int[] prices)
        {
            var currentMinPrice = prices[0];
            var maxProfit = 0;
            for(var i = 1; i < prices.Length; i++)
            {
                maxProfit = Math.Max(prices[i] - currentMinPrice, maxProfit);
                currentMinPrice = Math.Min(prices[i], currentMinPrice);
            }

            return maxProfit;
        }
    }
}