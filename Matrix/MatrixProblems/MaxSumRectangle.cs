using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixProblems
{
    public class Result
    {
        public int MaxSum { get; set; }
        public int LeftBound { get; set; }
        public int RightBound { get; set; }
        public int TopBound { get; set; }
        public int BottomBound { get; set; }
      
    }

    public class KadaneResult
    {
        public int MaxSum { get; set; }
        public int Start { get; set; }
        public int End { get; set; }
        public KadaneResult(int maxSum, int start, int end)
        {
            this.MaxSum = maxSum;
            this.Start = start;
            this.End = end;
        }
    }

    public class MaxSumRectangleSum
    {
        public static Result GetMaxSum(int[,] input)
        {
            int rows = input.GetLength(0);
            int cols = input.GetLength(1);
            int[] temp = new int[rows];
            Result result = new Result();
            for (int left = 0; left < cols; left++)
            {
                for (int i = 0; i < rows; i++)
                {
                    temp[i] = 0;
                }
                for (int right = left; right < cols; right++)
                {
                    for (int i = 0; i < rows; i++)
                    {
                        temp[i] += input[i,right];
                    }
                    KadaneResult kadaneResult = Kadane(temp);
                    if (kadaneResult.MaxSum > result.MaxSum)
                    {
                        result.MaxSum = kadaneResult.MaxSum;
                        result.LeftBound = left;
                        result.RightBound = right;
                        result.TopBound = kadaneResult.Start;
                        result.BottomBound = kadaneResult.End;
                    }
                }
            }
            return result;
        }

        private static  KadaneResult Kadane(int[] arr)
        {
            int max = 0;
            int maxStart = -1;
            int maxEnd = -1;
            int currentStart = 0;
            int maxSoFar = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                maxSoFar += arr[i];
                if (maxSoFar < 0)
                {
                    maxSoFar = 0;
                    currentStart = i + 1;
                }
                if (max < maxSoFar)
                {
                    maxStart = currentStart;
                    maxEnd = i;
                    max = maxSoFar;
                }
            }
            return new KadaneResult(max, maxStart, maxEnd);
        }
    }
}
