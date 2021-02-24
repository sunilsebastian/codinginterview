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
            //n=> horizontal m=>vertical
           int vol= StorageOptimization.findMaxVolume(3, 3, new int[] { 2 }, new int[] { 2 });
           vol = StorageOptimization.findMaxVolume(2, 2, new int[] { 1 }, new int[] { 2 });
           vol = StorageOptimization.findMaxVolume(3, 2, new int[] {1,2, 3 }, new int[] { 1,2 });



            var productRatings = new int[3][] { new int[] { 4, 4 }, new int[] { 1, 2 }, new int[] { 3, 6 } };
            var rating=FiveStarRating.MinimumNumberOfAdditionalFiveStar(productRatings, 77);

   


            //var group1 = new List<int[]> { new int[] { 1, 8 }, new int[] { 2, 15 }, new int[] { 3, 9 } };
            //var group2 = new List<int[]> { new int[] { 1, 8 }, new int[] { 2, 11 }, new int[] { 3, 12 } };
            //int target = 20;
            //Output: [[1, 3], [3, 2]]

            var group1 = new List<int[]> { new int[] { 1, 2000 }, new int[] { 2,3000 }, new int[] { 3, 4000 } };
            var group2 = new List<int[]> { new int[] { 1,5000 }, new int[] { 2,3000 }};
            int target = 5000;

            var optimalResult= OptimalUtilization.getTargetSumIds(group1, group2, target);

            var optiomalPairs=OptimizeMemoryUsage.findPairs(new int[] { 1, 7, 2, 4, 5, 6 }, new int[] { 3, 1, 2 }, 6);


            var pairs= OptimizeBoxweight.GetBoxWeight(new List<int> { 5, 5, 5, 10, 10, 10, 11 });
            var pairs1 = OptimizeBoxweight.optimizingBoxWeights(new int[] { 5, 5, 5, 10, 10, 10, 11 });

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

           int minScore= ShoppingPatternGraph.getMinScore(6, 6, new int[] { 1, 2, 2, 3, 4, 5 }, new int[] { 2, 4, 5, 5,5, 6 });

            //(1,2), (2,5), (3,4), (4,6), (6,8), (5,7), (5,2), (5,2)
            var pars = new List<List<int>>() { new List<int> {1,2 } , new List<int> { 2,5 } , new List<int> {3,4} , 
                new List<int> {4,6} , new List<int> {6,8 }, new List<int> { 5,7}, new List<int> {5,2 }, new List<int> { 5,2}};
            GroupProductIdPairCategories.groupProductIdPairCategories(pars);


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

            //[1, 3, 5, 10, 80], instances = 2
            int instances=UtilizationChecks.finalInstances(2, new int[] { 25, 23, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 76, 80 });
   
            TransactionLogs.getFraudIds(new List<string> {" 345366 89921 45","029323 38239 23","38239 345366 15",
                "029323 38239 77","345366 38239 23","029323 345366 13","38239 38239 23"}, 3);

            var erliestTime=EarliestTimeToCompleteDeliveries.EarliestTime(2, new int[] { 8, 10 }, new int[] { 2, 2, 3, 1, 8, 7, 4, 5 });

            int[][] grid = new int[4][]{ new int[]{ 0, 1, 1, 0, 1 }, new int[]{ 0, 1, 0, 1, 0 }, new int[]{ 0, 0, 0, 0, 1 },new int[]{ 0, 1, 0, 0, 0 } };
            var minDaysToInfectAll=ZombieMatrix.minDaysToInfectAll(grid);

          var criticalPoints=  CriticalRouters.findCriticalConnections(7, 7, new List<int[]> { new int[] { 0, 1 } , new int[] { 0, 2 } ,
                new int[] { 1,3 } , new int[] { 2,3 } , new int[] { 2, 5 } ,new int[] { 5,6},new int[] { 3,4 }});

        }
    }
}
