using System;
using System.Collections.Generic;

namespace ArrayProblems
{
    public class Fibonacci
    {
        // Fibonacci(5)
        // 0 1 1 2 3 5  i.e 0+1,1+1,1+2, 2+3

        //O(n)
        // fib(8) means sum till generate 8 number excluding zero.
        // Fib(8) need 7 adiitions so loop is from 2 to n+1

        private static Dictionary<int, int> dict = new Dictionary<int, int>();

        public static int FibonacciUsingArray(int n)
        {
            int[] fibArr = new int[n + 1];
            fibArr[0] = 0;
            fibArr[1] = 1;
            int i;
            Console.Write($"{fibArr[0]} {fibArr[1]} ");
            for (i = 2; i <= n; i++)
            {
               // Console.WriteLine(string.Format("i={0}   {1}={2}+{3}", i, fibArr[i], fibArr[i - 1], fibArr[i - 2]));
                fibArr[i] = fibArr[i - 1] + fibArr[i - 2];

                Console.Write(fibArr[i] +" ");
            }

            return fibArr[n];
        }

        public static int FibonacciSimple(int n)
        {
            int a = 0;
            int b = 1;
            int c = 0;
            int count = 2;
            while (count < n + 1)
            {
                c = a + b;
                a = b; b = c;

                count++;
            }

            return c;
        }

        public static void ReverseFibonacciSeries(int n)
        {
            int[] fibArr = new int[n + 1];
            fibArr[0] = 0;
            fibArr[1] = 1;
            int i;
         
            for (i = 2; i <= n; i++)
            {
              
                fibArr[i] = fibArr[i - 1] + fibArr[i - 2];

            }

            for (i = n; i >= 0; i--)
            {
                Console.Write(fibArr[i] + " ");
            }

            //for(int i=n;i>=0; i--)
            //{
            //    Console.Write(FibReCurrsionWithMemoiszation(i) + " ");
            //}
        }

        public static int FibReCurrsion(int n)
        {
            if (n == 0 || n == 1)
                return n;
            return FibReCurrsion(n - 1) + FibReCurrsion(n - 2);
        }

        public static int FibReCurrsionWithMemoiszation(int n)
        {
            int x; int y;

            if (n == 0 || n == 1)
                return n;

            if (dict.ContainsKey(n - 1))
            {
                x = dict[n - 1];
            }
            else
            {
                x = FibReCurrsionWithMemoiszation(n - 1);
                dict.Add(n - 1, x);
            }

            if (dict.ContainsKey(n - 2))
            {
                y = dict[n - 2];
            }
            else
            {
                y = FibReCurrsionWithMemoiszation(n - 2);
                dict.Add(n - 2, y);
            }

            return x + y;
        }
    }
}