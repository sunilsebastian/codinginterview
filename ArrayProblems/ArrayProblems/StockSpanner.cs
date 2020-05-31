using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{

    /*
     * 
     * Write a class StockSpanner which collects daily price quotes for some stock, and returns the span of that stock's price for the current day.

        The span of the stock's price today is defined as the maximum number of consecutive days (starting from today and going backwards) 
        for which the price of the stock was less than or equal to today's price.

        For example, if the price of a stock over the next 7 days were [100, 80, 60, 70, 60, 75, 85], then the stock spans would be [1, 1, 1, 2, 1, 4, 6].

        First, S = StockSpanner() is initialized.  Then:
        S.next(100) is called and returns 1,
        S.next(80) is called and returns 1,
        S.next(60) is called and returns 1,
        S.next(70) is called and returns 2,
        S.next(60) is called and returns 1,
        S.next(75) is called and returns 4,
        S.next(85) is called and returns 6.

    */
    public class StockSpanner
    {
        Stack<int[,]> stk = null;
        public StockSpanner()
        {
            stk = new Stack<int[,]>();
        }

        public int Next(int price)
        {
            int count = 1;
            if (stk.Count == 0)
            {
                stk.Push(new int[,] { { price, count } });
                return count;
            }

            while (stk.Count != 0 && stk.Peek()[0, 0] <= price)
            {
                var item = stk.Pop();
                count += item[0, 1];

            }
            stk.Push(new int[,] { { price, count } });



            return count;
        }
    }
}
