using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    public class BestTimeToBuyAndSell
    {
        public int bestTimeToBuyAndSell(int[] arr)
        {
            float profit, min_price =float.MaxValue;
            float max_profit = 0;
            
            foreach (var price in arr)
            {
                if(price<min_price)
                    min_price = price;
                profit = price-min_price;
                if (profit > max_profit)
                    max_profit = profit;

            }
            return (int)max_profit;
        }
    }
}
