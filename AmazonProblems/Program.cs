using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonProblems
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var productRatings = new int[3][] { new int[] { 4, 4 }, new int[] { 1, 2 }, new int[] { 3, 6 } };
            FiveStarRating.MinimumNumberOfAdditionalFiveStar(productRatings, 77);

            var group1 = new int[3][] { new int[] {1,2 }, new int[] {2,4 }, new int[] { 3,6} };
            var group2 = new int[3][] { new int[] {1,2 },new int[]{ 2, 1 },new int[]{ 3, 3 } };
            OptimalUtilization.getTargetSumIds(group1, group2, 7);

            var pairs= OptimizeBoxweight.optimizingBoxWeights(new int[] { 8,2,2,2,9 });

            FillTheTruck.fillTheTruck(3, new List<int> { 1, 2, 3 }, 3, new List<int> { 3, 2, 1 }, 4);

            var priceOfJeans = new List<int> { 2, 3 };
            var priceOfShoes = new List<int> { 4};
            var priceOfSkirts = new List<int> { 2, 3 };
            var priceOfTops = new List<int> { 1,2};

            long noofwaystopurchase=ShoppingOption.soltuion4(priceOfJeans, priceOfShoes, priceOfSkirts, priceOfTops, 10);



            List<List<string>> codelist = new List<List<string>> { new List<string> { "apple", "apple" }, new List<string> { "banana", "anything", "banana" } };
            //  var shoppingCart = new List<string> { "banana", "orange", "banana", "apple", "apple" };
            var shoppingCart = new List<string> { "orange", "apple", "apple", "banana", "orange", "banana" };
            bool isEligibile=FreshPromotion.isWinner(codelist, shoppingCart);

            Turnstile.GetTimes(4, new int[] { 0, 0, 1, 5 }, new int[] { 0, 1, 1, 0 });

           int swaps= MinSwapToSort.NumberOfSwapsToSort(new int[] { 5, 4, 1, 2 });
            KnightMoves.getNumberOfValidMoves(2, 0, 0);
            int count=CloudFrontCache.ConnectedSum(8, new List<string> { "8 1", "5 8", "7 3", "8 6" });
            DifficultyOfJobSchedule.MinDifficulty(new int[] { 6, 5, 4, 3, 2, 1 }, 2);
            //[30,20,150,100,40]
            PairsDivisibleByK.CountKdivPairs(new int[] { 30, 20, 150, 100, 40 }, 60);
            string s = "|**|*|*";
            int[] startIndices = new int[] { 1, 1 }, endIndices = new int[] { 5, 6 };
            ItemsInContainers.NumberOfItems(s, startIndices, endIndices);
        
            NearestCity.findNearestCities();

            List<string> keywords = new List<string> { "anacell", "cetracular","services", "betacellular" };

            List<string> review = new List<string> {
              "Anacell provides the best services in the city",
               "betacellular has awesome services",
              "Best services provided by anacell, everyone should use anacell"};

         
            AllDistinctSubstringSizeK.substrings("awaglknagawunagwkwagl", 4);

            TopFrequentWordInSentence.PopMentioned(2, keywords, review);

        }
    }
}
