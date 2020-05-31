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
            bool happy=HappyNumber.IsHappy(19);
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

          

           

            //Print Prime
            int maxVal = 435;
            Console.Write($"Prime numbers below {maxVal}: ");
            PrimeNumbers.Print(maxVal);
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



            var row=PascalTraiangleKRow.GetRow(3);

           var waveArray= ArrayInWaveForm.GetWaveForm(new int[] { 20, 10, 8, 6, 4, 2 });


            Console.Write("Pushing negative numbers { 4, -3, 2, -5, 5, -1, 3 } to the left:");
            PushNegativeNumbersToLeft.PushNegativeNumbers(new int[] { 4, -3, 2, -5, 5, -1, 3 });
                     
            Console.WriteLine();

            //Largest contigous number sum
            int val = LargestContinousSum.GetLargestContinousSum(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });
            Console.Write($"Largest continous sum of (-2, 1, -3, 4, -1, 2, 1, -5, 4 ): {val}");
            Console.WriteLine();

            CircularArrayLargestSum.MaxSubarraySumCircular(new int[] { 2, 3, -6, -7, 4, 5 });

            Console.Write($"Print Paiirs Difference Up To:");
            DifferenceUptoK.PrintPaiirsDifferenceUpToK(new int[] {3,1, 4,1,5}, 2);
            Console.WriteLine();

            Console.Write($"Print Paiirs Difference Up To(Sorted):");
            DifferenceUptoK.PrintPaiirsDifferenceUpToKSorted(new int[] { 8, 12, 16, 4, 0, 20 }, 4);
            Console.WriteLine();

            Console.Write($"Print 3 numbers sum to 22 ");
            Sumupto3numbers.PrintNumbers(new int[] { 1, 4, 45, 6, 10, 8 }, 22);
            Console.WriteLine();
            Sumupto3numbers.ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 });
            Console.WriteLine();

          

            //Find missing element in an array
            arr = new int[] { 1, 2, 4, 5, 6 };
            Console.Write($"MissingElement in [ 1,2, 4, 5, 6 ]: {MissingElement.FindMissingElement(arr, 6)}");

            //Convert input to required output.
            int[] input = { 2, 3, 1, 4 };
            int[] output = { 12, 8, 24, 6 };
            var result = TransformArrayValue.Convert(input);
            bool isEqual = output.SequenceEqual(result);
            Console.WriteLine();

           

            //Even Occuring First Element..
            input = new int[] { 1, 2, 2, 3, 3, 4, 5, 4, 4, 6, 4 };
            Console.Write("Even Occuring First Element in { 1,2,2,3,3,4,5,4,4,6,4} is :");
            NumberRepeatingEvenTimes.FindNumberRepeatingEvenTimes(input);
            Console.WriteLine();

          
            
           

            //Find duplicates in an array
            RemoveDuplicatesInArray.RemoveDuplicatesUnsortedarray(new int[] { 5, 3, 2, 2, 1, 6, 6, 5, 5 });
            Console.WriteLine();

            RemoveDuplicatesInArray.RemoveDuplicatesUnsortedarrayUsingHashSet(new int[] { 5, 3, 2, 2, 1, 6, 6, 5, 5 });
            Console.WriteLine();

            RemoveDuplicatesInArray.RemoveDuplicatesInSortedArray(new int[] { 1, 2, 2, 2, 3, 3, 3, 4, 5, 6, 6 });
            Console.WriteLine();

            //Number of Is in Binary representation
            Console.Write($"number of 1s in binary represenation of 10 :{NumberOfOnesInBinary.CountOnesInBinary(10)}");
            Console.WriteLine();

            //Find number is Odd
            Console.Write($"number 7 is Odd? :{ BitwiseOddorEven.FindOdd(7)}");
            Console.WriteLine();

            

          

            //Queue using 2 stack
            QueueUsingStack.Enqueue(10);
            QueueUsingStack.Enqueue(11);
            QueueUsingStack.Enqueue(12);

            Console.Write("Enqueue:{10,11,12} Dequeue: ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(QueueUsingStack.Dequeue() + " ");
            }
            Console.WriteLine();

            input = new int[] { 1, 2, 3, 3, 3, 2, 4, 5, 5, 6 };
            Console.Write($"Duplicates in array [1,2,3,3,2,4,5,5,6] :");
            DuplicatesInArray.FindDuplicates(input);
            Console.WriteLine();

            int[,] sortedArray = new int[,] { { -3, -2, -1, 1 }, { -2, 2, 3, 4 }, { 4, 5, 7, 8 } };
            int negCount = NegativeNumCountSortedMatrix.GetNegativeNumCountSortedMatrix(sortedArray);
            Console.Write($"Count of Negative numbers in Sorated 2D Array  [[-3,-2,-1,1], [-2,2,3,4 ], [ 4,5,7,8]] :{negCount}");
            Console.WriteLine();

            //Max repeating element in an array
            input = new int[] { 2, 3, 3, 5, 3, 4, 1, 7, 7 };//N is the size
            k = 8; //Values in array should be 0 to k
            int maxrepeat = MaxRepeatingElementInArray.FindMaxRepeatingElementInAnArray(input, k);
            Console.WriteLine($"max repeating element in [2,3,3,5,3,4,1,7,7] :{maxrepeat}");
             

            UnionOfTwoSortedArrays.PrintUnion(new int[] { 1, 2, 3 }, new int[] { 4, 5, 5 });
            Console.WriteLine();


            var median = MedianOfTwoSortedArrays.getMedian(new int[] { 1, 2, 9 }, new int[] { 4, 5, 10 }, 3);
            Console.WriteLine();

            InterSectionOfSortedArray.PrintIntersection(new int[] { 1, 2, 9 }, new int[] { 2, 4, 9 }, 3, 3);
            Console.WriteLine();

           var resultArray= MergeAndMeadian.MergeArrays(new int[] { 1, 5, 8 }, new int[] { 2,4,9 }, new int[] { 3,6,7 });

            Console.WriteLine();

            var bestPrice=MaxProfitOnSale.BestPrice(new int[] { 1, 10, 6, 3, 9, 2 });
           Console.WriteLine($"Max profit on Buy and sell:{bestPrice}");

            //FileRead fileRead = new FileRead();
            //fileRead.ReadFileWithFixedBuffer();

            //Console.WriteLine();

          

            RotateArray.Rotate(new int[] { 1, 2, 3, 4, 5 }, 2);

            Console.WriteLine("After rotation array by 2:");
            Console.WriteLine();

            DutchNationalFlag.Sort(new int[] { 0, 2, 1, 1, 2,0, 1 });
            Console.WriteLine("Sort an array of 0 1 2:");
            Console.WriteLine();

            Console.WriteLine("After Merging Intervals:");
            MergeIntervals.Merge(new int[,] { { 1, 4 }, { 2, 4 }, { 5, 7 }, { 6, 8 } });


            //int[][] varArray = new int[2][] { new int[] { 1, 3 }, new int[] { 6, 9} };
            //  MergeIntervals.Insert(varArray,new int[] { 2, 5 });
            int[][] varArray = new int[5][] { new int[] { 1, 2 }, new int[] {3,5 }, new int[] {6,7}, new int[] { 8,10} , new int[] { 12, 16 } };
            MergeIntervals.Insert(varArray,new int[] { 4,9});

            Console.WriteLine();


            Console.WriteLine("After Inserting  Intervals:");
            MergeIntervals.Insert(new int[,] { { 1, 2 }, { 3,5 }, { 6, 7 }, { 8,10},{ 12, 16 } },new int[,] { { 4, 9 } });
            Console.WriteLine();

          

           

            //  int minSetSize= MinMaxSizeSubArray.FindMinumSizeSubarraySumEqualsk(new int[] { 2, 3, 1, 2, 4, 3 }, 7);
             int minSetSize= MinMaxSizeSubArray.FindMinumSizeSubarraySumEqualsk(new int[] { -1, 1, 2, 1, 2, 1 }, 4);

            int maxSetSize = MinMaxSizeSubArray.FindMaximumSizeSubarraySumEqualsk(new int[] { 1,-1,5,-2,3}, 3);
           

            //List<List<int>> triangle = new List<List<int>>()
            //{   new List<int>(){2},
            //    new List<int>(){3,4},
            //    new List<int>(){6,5,7},
            //    new List<int>() {4,1,8,3} };


            List<List<int>> triangle = new List<List<int>>()
            {   new List<int>(){-1},
                new List<int>(){2,3 },
                new List<int>(){1,-1,-3} };

            Triangle.MinSum(triangle);

           

            //FindNumInRotatedArray.FindNum(new int[] { 7, 8, 9, 1, 2, 3, 4, 5, 6 }, 8);
            FindNumInRotatedArray.FindNum(new int[] { 1, 3 }, 3);

         

            //element repeated more than n/2 times
            var majElement=MajorityVote.FindMajorityElement(new int[] {7,2,7,2,7,2,7,7});
            var majElement1 = MajorityVote.FindMajorityElement(new int[] { 1,2,3,2,2});

            MissingPositiveNumber.FindFirstMissingPositiveNumber(new int[] { 3,4,-1,1 });

            var maxValues= SlidingWindowMaximum.PrintSlidingWindowMaximum(new int[] { 1, 3, 1, 2, 0, 5,9,10 }, 3);
            maxValues = SlidingWindowMaximum.PrintSlidingWindowMaximum(new int[] { 1, 3 }, 5);

           

            PlusOneTest.PlusOne(new int[] {9,9,9});

           int basVersion=    BadVersionFinder.FirstBadVersion(2126753390);

          


            MovingAverage mv = new MovingAverage(3);
            var mv1= mv.Next(1);
            var mv2=mv.Next(10);
            var mv3= mv.Next(3);
            var mv4= mv.Next(5);
            var mv5 = mv.Next(7);
            var mv6 = mv.Next(3);


            FrogJump.CanReachLastStone(new int[] { 0, 1, 3, 5, 6, 8, 12, 17 });

            Console.ReadLine();
        }
    }
}
