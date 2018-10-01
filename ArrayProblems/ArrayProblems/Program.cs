﻿using System;
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

            int val = LargestContinousSum.GetLargestContinousSum(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });
            Console.Write($"Largest continous sum of (-2, 1, -3, 4, -1, 2, 1, -5, 4 ): {val}");
            Console.WriteLine();

            string string1 = "abcd";
            string string2 = "hij";
            string string3 = "ahbijcd";
            Console.Write($"Is String  '{string3}' In Order: {StringOrderCheck.IsStringsAreInOrder(string1, string2, string3)}");
            Console.WriteLine();

            arr = new int[]{ 1, 2, 4, 5, 6 };
            Console.Write($"MissingElement: {MissingElement.FindMissingElement(arr, 6)}");

            //Convert input to required output.
            int[] input = { 2, 3, 1, 4 };
            int[] output = { 12, 8, 24, 6 };
            var result=TransformArrayValue.Convert(input);
            bool isEqual = output.SequenceEqual(result);
            Console.WriteLine();

            //Balanced Paranthesis

            List<char> paranthesis = new List<char>{ '[', '{', '(' };
            Dictionary<char, char> pairs = new Dictionary<char, char>() { { '[', ']' }, { '{', '}' }, { '(', ')' } };
            string inputString = "[{]}"; //[{}]
            bool inorder = ParanthesisInOrder.Check(inputString);
            Console.WriteLine();

            //Even Occuring First Element..
            input = new int[] { 1, 2, 2 ,3,3};
            Console.Write("Even Occuring First Element in { 1,2, 2 ,3,3} is :");
            NumberRepeatingEvenTimes.FindNumberRepeatingEvenTimes(input);
            Console.WriteLine();

            //First non-repeating element

            testString = "abcabcdeefgfedhg";

            Console.Write($"Firs non duplicating char in   '{testString}' is:");
            FirstNonDupChar.FirstNonDuplicatingChar(testString);
            Console.WriteLine();

            string sentenceToreverse = "hello how are you";
            Console.Write($"Reverse of sentence '{sentenceToreverse}' is:{ReverseWordsInString.GetReversedWordsInsentence("hello how are you")}");
            Console.WriteLine();



            Console.ReadLine();
        }
    }
}
