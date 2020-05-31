using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class HappyNumber
    {

        //19 True
        //20 False
        public static  bool IsHappy(int n)
        {
            List<int> list = new List<int>();

            //if list contains the sum and its number 1 then it is a happy number.
            while (!list.Contains(n))
            {
                list.Add(n);
                n = GetSquareSum(n, 0);
            }

            return (n == 1);

        }

        public static  int GetSquareSum(int n, int sum)
        {
            if (n == 0)
                return sum;

            int mod = n % 10;
            int num = n / 10;

            return GetSquareSum(num, sum + (mod * mod));

        }
    }
}
