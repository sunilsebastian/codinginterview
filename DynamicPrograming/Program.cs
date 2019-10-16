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
            bool perfectShuffle=StringInterLeaving.IsPerfectShuffle("AB", "D", "ADBECF");
            //bool perfectShuffle=StringInterLeaving.IsPerfectShuffle("bcc", "bbca", "bbcbcac");
            int cost = MatrixChainMultiplication.Multply(new int[] { 2, 3, 6, 4, 5 });
            WordBreakCount.GetWordBreakCount(new List<string> { "i", "am", "ace" ,"iam"}, "iamace");
            int player1Max= Gold2Player.MaximizeFirstPlayerGain(new int[] { 3, 9, 1, 2 });

            var palindromes = NumberofPalindromes.GetCount(3);

            var distictOccurrenceCount=DistinctSubSequenceCount.FindSubsequenceCount("banana", "ban");

            LongestPalindrumSequence.GetLongestPalindrumSequenceCount("agbdba");

            var maxPrd=MaxProduct.GetMaxProduct(new int[] { -2,2,-3,4});

            var mincuts=  MinimumPalindrumParition.MinPalPartion("agbdba");

            var res= HouseRobber.Rob(new int[] { 1, 2, 3, 1 });

            var canj = JumpGame.CanJump(new int[] { 2, 3, 1, 1, 4 });

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

           var isThereSum= SubsetSum.IsSubsetSum1(new int[] { 2,3,7,8,10 }, 11);

           var profit= Knapsack.MaximizeProfit(new int[] { 1, 4, 5, 7 }, new int[] { 1, 3, 4, 5 }, 7);

           var res1= WildCardMatching.StringMatch("abc", "*bc",3,3);
            var res2= RegExMatching.StringMatch("abc", "*bc", 3, 3);



        }
    }
}
