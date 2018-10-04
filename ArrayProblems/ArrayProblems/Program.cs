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

            //Check chars in string unique
            String testString = "abcdefg";
            Console.Write($"'{testString}' is unique:{   StringUnique.isStringUniqueue(testString)}");
            Console.WriteLine();

            //Convert string to number
            string num = "1234";
            Console.Write($"'{num}' is Converted to Num:{StringToInt.Convert(num)}");
            Console.WriteLine();

            //number to string
            int numval = 1234;
            Console.Write($"'{numval}' is Converted to String:{IntToString.Convert(numval)}");
            Console.WriteLine();

            //Print Prime
            int maxVal =435;
            Console.Write($"Prime numbers below {maxVal}: ");
            PrimeNumbers.Print(maxVal);
            Console.WriteLine();

            //No of words in a string
            string sentence = "Hello How are you   ";
            Console.Write($"Word count in '{sentence}' is: { WordCountInASentence.GetWordCount(sentence)}");
            Console.WriteLine();

            //Pairs sum to a given number in array- Unsorted
            int[] arr = { 1, 2, 3, 4, 5 };
            int k = 6;
            Console.Write($"Pairs to Sum {k}: ");
            SunmUptoK.UnSortedSumUpToK(arr, k);
            Console.WriteLine();


            //Pairs sum to a given number in array- Sorted
            Console.Write($"Pairs to Sum {k}: ");
            SunmUptoK.SortedSumUpToK(arr, k);
            Console.WriteLine();

            // permutation of characters in a string
            string permuteString = "abc";
            Console.Write($"Permutation of string  '{permuteString}' : ");
            Permutation.Permute(permuteString);
            Console.WriteLine();

            //Largest contigous number sum
            int val = LargestContinousSum.GetLargestContinousSum(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });
            Console.Write($"Largest continous sum of (-2, 1, -3, 4, -1, 2, 1, -5, 4 ): {val}");
            Console.WriteLine();

            //give 3 strings check string 3 order of char are same as of string1 and string 2
            string string1 = "abcd";
            string string2 = "hij";
            string string3 = "ahbijcd";
            Console.Write($"Is String  '{string3}' In Order: {StringOrderCheck.IsStringsAreInOrder(string1, string2, string3)}");
            Console.WriteLine();

            //Find missing element in an array
            arr = new int[]{ 1, 2, 4, 5, 6 };
            Console.Write($"MissingElement in [ 1,2, 4, 5, 6 ]: {MissingElement.FindMissingElement(arr, 6)}");

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

            //Reverse words in a string
            string sentenceToreverse = "hello how are you";
            Console.Write($"Reverse of sentence '{sentenceToreverse}' is:{ReverseWordsInString.GetReversedWordsInsentence("hello how are you")}");
            Console.WriteLine();

            //Anagram
            string s1 = "twoplusone";
            string s2 = "oneplustwo";
            Console.Write($" '{s1}' and '{s2}' are Anagram? {Anagram.isStringsAnagram(s1, s2)}'");
            Console.WriteLine();

            //Find duplicates in an array
            RemoveDuplicatesInArray.RemoveDuplicatesUnsortedarray(new int[] { 5, 3, 2, 2, 1 ,6,6,5,5});
            Console.WriteLine();

            RemoveDuplicatesInArray.RemoveDuplicatesUnsortedarrayUsingHashSet(new int[] { 5, 3, 2, 2, 1, 6, 6, 5, 5 });
            Console.WriteLine();

            RemoveDuplicatesInArray.RemoveDuplicatesInSortedArray(new int[] { 1,2,2,2,3,3,3,4,5,6,6 });
            Console.WriteLine();

            //Number of Is in Binary representation
            Console.Write($"number of 1s in binary represenation of 10 :{NumberOfOnesInBinary.CountOnesInBinary(10)}");
            Console.WriteLine();

            //Find number is Odd
            Console.Write($"number 7 is Odd? :{ BitwiseOddorEven.FindOdd(7)}");
            Console.WriteLine();

            string num1 = "999";
            string num2 = "888";
            var sum= AddTwoLargeNumber.AddTwoNumbers(num1, num2);
            Console.Write($"{num1} + {num2} = {sum}");
            Console.WriteLine();

            var mulres= MultiplyTwoLargeNumber.MultiplyBigNumbers(num1,num2);
            Console.Write($"{num1} * {num2} = {mulres}");
            Console.WriteLine();
            //Addition of two very large number (ie not fit into integer range)

            QueueUsingStack.Enqueue(10);
            QueueUsingStack.Enqueue(11);
            QueueUsingStack.Enqueue(12);

            Console.Write("Enqueue:{10,11,12} Dequeue: ");
            for (int i = 0; i < 3; i++)
            {
               Console.Write(QueueUsingStack.Dequeue() + " ");
            }
            Console.ReadLine();
        }
    }
}
