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
            KnightTourPhoneNumGivenLength.GetPhoneNumberGivenLength(0, 3);
            EqualSumPartition.EqualSubSetSumPartition(new List<int> {2,1,3,7,-3,10 });
            CutRopeMaxProduct.GetCutRopMaxProduct(5);
           // int ans = TextJustification.Justify(new string[] { "qjeJnFkqq", "JlRjenW", "jg", "badsha","JK","PK" }, 13);
            int ans = TextJustification.Justify(new string[] { "omg", "very", "are", "extreme"}, 10);
            //int ans = TextJustification.Justify(new string[] { "abc", "d", "efgh"}, 50);
            bool perfectShuffle=StringInterLeaving.IsPerfectShuffle("AB", "D", "ADBECF");
            //bool perfectShuffle=StringInterLeaving.IsPerfectShuffle("bcc", "bbca", "bbcbcac");
            int cost = MatrixChainMultiplication.Multply(new int[] { 2, 3, 6, 4, 5 });
            WordBreakCount.GetWordBreakCount(new List<string> { "i", "am", "ace" }, "iamace");

            WordBreakCount.GetWordBreakCount(new List<string> { "c", "od", "e", "x" }, "code");

            WordBreakCount.GetWordBreakCount(new List<string> { "i", "like", "you", "ilike", "likeyou" }, "code");

            WordBreakCount.WordBreakII("abc", new List<string> { "a", "b", "c", "ab" });

            int player1Max= Gold2Player.MaximizeFirstPlayerGain(new int[] { 3, 9, 1, 2 });

            var palindromes = NumberofPalindromes.GetCount(3);

            var distictOccurrenceCount=DistinctSubSequenceCount.FindSubsequenceCount("banana", "ban");

            LongestPalindrumSequence.GetLongestPalindrumSequenceCount("agbdba");

            LongestPalindrumSequence.GetLongestPalindrumSubstringCount("agbdba");

            var maxPrd=MaxProduct.GetMaxProduct(new int[] { -2,2,-3,4});

            var mincuts=  MinimumPalindrumParition.MinPalPartion("agbdba");

            var res= HouseRobber.Rob(new int[] { 1, 2, 3, 1 });

            var canj = JumpGame.CanJump(new int[] { 2, 3, 1, 1, 4 });
            var can1= JumpGame.CanReach(new int[] { 4, 2, 3, 0, 3, 1, 2 },0);
            var can = JumpGame.Jump(new int[] { 2, 3, 1, 1, 4 });

            //var numberofJumps=JumpGame.Jump(new int[] { 2, 3, 1, 1, 4 });
            int numDecodeways = DecodeWays.NumDecodings1("226");//226
             numDecodeways=DecodeWays.NumDecodings("126"); //2266

            var longestSubstringCount= LongestCommonSubstring.GetLongestCommonSubstring("abc", "abcd");

            LongestCommonSubstring.GetLongestCommonSubstringRecur("cdab", "cdx");

            var incSequence= LongestIncreasingSubsequencecs.LongestIncreasingSubsequenceRecursive(new int[] { 3,4,-1,0,6,2,3 });

            var longestSubSequenceCount= LongestCommonSubsequence.GetLongestCommonSubsequence("ABCDF", "AEBDF");

            CoinChange.GetMinimumCoinChangeRecursion(new int[] { 7, 3, 2, 6 }, 13);
            var coinCount=CoinChange.GetMinimumCoinChangeForTargetAmt(new int[] { 7, 3, 2, 6 }, 13);

           var perfectSquareCount= PerfectSquare.NumSquares(12);

            //new int[] { 2, 5, 3, 4 }  //5 best way to cut is 
            int[] arr2 = new int[] { 1, 5, 8, 9, 10, 17, 17, 20 }; //8

            arr2 = new int[] { 2, 5, 7,  8};
            var maxprice=CuttingRod.GetmaxValue(arr2, 5);

           var isThereSum= SubsetSum.IsSubsetSum1(new int[] { 2,3,7,8,10 }, 11);

           var profit= Knapsack.MaximizeProfit(new int[] { 1, 4, 5, 7 }, new int[] { 1, 3, 4, 5 }, 7);

           var res1= WildCardMatching.StringMatch("abc", "*bc",3,3);
          // var res2= RegExMatching.StringMatch("abc", "*bc", 3, 3);
           var res3 = RegExMatching.StringMatch("aab", "a*b*", 3, 3);

         var wresult=   CanBreakWord.WordBreak("applepenapple", new List<string> { "apple", "pen" });



        }
    }
}
