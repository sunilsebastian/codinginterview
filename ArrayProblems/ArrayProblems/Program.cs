using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Fibonacci series
            Console.Write($"Fib(8):");
            int val1 = Fibonacci.FibReCurrsionWithMemoiszation(8);
            int val2 = Fibonacci.FibReCurrsion(8);
            int val3 = Fibonacci.FibonacciUsingArray(8);
            int val4 = Fibonacci.FibonacciSimple(8);

            Console.WriteLine();
            Console.WriteLine($"Fib {val1} {val2} {val3} {val4}");


            //Reverse  Fibonacci
            Console.Write($"Fibonacci reverse:");
            Fibonacci.ReverseFibonacciSeries(8);
            Console.WriteLine();

            String testString = "abcdefg";
            Console.Write($"'{testString}' is unique:{   StringUnique.isStringUniqueue(testString)}");
            Console.WriteLine();

            string num = "1234";
            Console.Write($"'{num}' is Converted to Num:{StringToInt.Convert(num)}");
            Console.WriteLine();

            int numval = 1234;
            Console.Write($"'{numval}' is Converted to String:{IntToString.Convert(numval)}");
            Console.WriteLine();

            int maxVal =435;
            Console.Write($"Prime numbers below {maxVal}: ");
            PrimeNumbers.Print(maxVal);
            Console.WriteLine();


            string sentence = "Hello How are you   ";
            Console.Write($"Word count in '{sentence}' is: { WordCountInASentence.GetWordCount(sentence)}");
            Console.WriteLine();

            int[] arr = { 1, 2, 3, 4, 5 };
            int k = 6;
            Console.Write($"Pairs to Sum {k}: ");
            SunmUptoK.UnSortedSumUpToK(arr, k);
            Console.WriteLine();


            
            Console.Write($"Pairs to Sum {k}: ");
            SunmUptoK.SortedSumUpToK(arr, k);
            Console.WriteLine();

            string permuteString = "abc";
            Console.Write($"Permutation of string  '{permuteString}' : ");
            Permutation.Permute(permuteString);
            Console.WriteLine();

            int val= LargestContinousSum.GetLargestContinousSum(new int[] { 20, -2, 1, -3, 4, -1, 2, 1, -5, 4 });
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
