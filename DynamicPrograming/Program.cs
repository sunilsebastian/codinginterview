using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPrograming
{
    class Program
    {
        public static void Main(string[] args)
        {

            var distictOccurrenceCount=DistinctSubSequenceCount.FindSubsequenceCount("banana", "ban");

            LongestPalindrumSequence.GetLongestPalindrumSequenceCount("agbdba");

            var maxPrd=MaxProduct.GetMaxProduct(new int[] { -2,2,-3,4});

            var mincuts=  MinimumPalindrumParition.MinPalPartion("abcbm");

            var res= HouseRobber.Rob(new int[] { 1, 2, 3, 1 });

            var numberofJumps=JumpGame.Jump(new int[] { 2, 3, 1, 1, 4 });

            var numDecodeways=DecodeWays.NumDecodings("2266");

            var longestSubstringCount= LongestCommonSubstring.GetLongestCommonSubstring("abc", "abcd");

            var longestSubSequenceCount= LongestCommonSubsequence.GetLongestCommonSubsequence("ABCDF", "AEBDF");

            var coinCount=CoinChange.GetMinimumCoinChangeForTargetAmt(new int[] { 7, 3, 2, 6 }, 13);

           var perfectSquareCount= PerfectSquare.GetPenumSquares(12);

            //new int[] { 2, 5, 3, 4 }  //5 best way to cut is 
            int[] arr2 = new int[] { 1, 5, 8, 9, 10, 17, 17, 20 }; //8

            arr2 = new int[] { 2, 5, 7,  8};
            var maxprice=CuttingRod.GetmaxValue(arr2, 5);

           var isThereSum= SubsetSum.IsSubsetSum(new int[] { 3, 34, 4, 12, 5, 2 }, 9);

           var profit= Knapsack.MaximizeProfit(new int[] { 1, 4, 5, 7 }, new int[] { 1, 3, 4, 5 }, 7);



        }
    }
}
