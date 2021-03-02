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
           vol = StorageOptimization.findMaxVolume(3, 2, new int[] {1,2,3 }, new int[] { 1,2 });


         int vol1=   StorageOptimization.storageOptimization(3, 3, new List<int> { 2 }, new List<int> { 2 });
         vol1 = StorageOptimization.storageOptimization(2,2, new List<int> { 1 }, new List<int> { 2 });
         vol1 = StorageOptimization.storageOptimization(3, 2, new List<int> { 1, 2,3 }, new List<int> { 1,2 });



            var productRatings = new int[3][] { new int[] { 4, 4 }, new int[] { 1, 2 }, new int[] { 3, 6 } };
            var rating=FiveStarRating.MinimumNumberOfAdditionalFiveStar(productRatings, 77);

   

          //--------------------------------------------------------------
            //var group1 = new List<int[]> { new int[] { 1, 8 }, new int[] { 2, 15 }, new int[] { 3, 9 } };
            //var group2 = new List<int[]> { new int[] { 1, 8 }, new int[] { 2, 11 }, new int[] { 3, 12 } };
            //int target = 20;
            //Output: [[1, 3], [3, 2]]

            var group1 = new List<int[]> { new int[] { 1, 2000 }, new int[] { 2,3000 }, new int[] { 3, 4000 } };
            var group2 = new List<int[]> { new int[] { 1,5000 }, new int[] { 2,3000 }};
            int target = 5000;

          
            var optimalResult= OptimalUtilization.getTargetSumIds(group1, group2, target);


            //var group11 = new List<List<int>> { new List<int> { 1, 8 }, new List<int> { 2, 15 }, new List<int> { 3, 9 } };
            //var group21 = new List<List<int>> { new List<int> { 1, 8 }, new List<int> { 2, 11 }, new List<int> { 3, 12 } };
            //int target1 = 20;
            //Output: [[1, 3], [3, 2]]


            //var group11 = new List<List<int>> { new List<int> { 1,3 }, new List<int> { 2,5}, new List<int> { 3, 7 }, new List<int> { 4, 10 } };
            //var group21 = new List<List<int>> { new List<int> { 1, 2 }, new List<int> { 2, 3 }, new List<int> { 3, 4 }, new List<int> { 4, 5 } };
            //int target1 = 10;

            //var group11 = new List<List<int>> { new List<int> { 1, 8 }, new List<int> { 2,7 }, new List<int> { 3,14 }};
            //var group21 = new List<List<int>> { new List<int> { 1, 5}, new List<int> { 2, 10 }, new List<int> { 3, 14 }};
            //int target1 = 20;


            var group11 = new List<List<int>> { new List<int> { 1, 8 }, new List<int> { 2, 15 }, new List<int> { 3,9} };
            var group21 = new List<List<int>> { new List<int> { 1, 8}, new List<int> { 2, 11 }, new List<int> { 3,12 } };
            int target1 = 20;

            var optimalResult1 = OptimalUtilization.getPairs(group11, group21, target1);

            //--------------------------------------------------------------------



            var optiomalPairs=OptimizeMemoryUsage.findPairs(new int[] { 1, 7, 2, 4, 5, 6 }, new int[] { 3, 1, 2 }, 6);


            var pairs= OptimizeBoxWeight.GetBoxWeight(new List<int> { 4, 5, 2, 3, 1, 2 });
            var pairs1 = OptimizeBoxWeight.optimizingBoxWeights(new int[] { 4, 5, 2, 3, 1, 2 });

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

            var orderTunsile=Turnstile.GetTimes(5, new int[] {0,1,1,3,3}, new int[] { 0, 1, 0, 0,1 });

            var inputNums = new int[] { 6, 3, 7, 1, 5, 8, 2, 4 };
            //var inputNums = new int[] { 5, 4, 1, 2 };
            //var inputNums = new int[] { 1, 9, 7 ,8 ,5 };
            //var inputNums = new int[] { 5, 2, 6, 1 };
            //var inputNums = new int[] { -1,-1};
            //var inputNums = new int[] { 6, 3, 7, 1, 5, 8, 2, 4 };

            int swaps = MinSwapToSort.NumberOfSwapsToSort(inputNums);
           // int swaps = MinSwapToSort.GetSwapCount(inputNums);
            KnightMoves.getNumberOfValidMoves(2, 0, 0);

            int count=CloudFrontCache.ConnectedSum(8, new List<string> { "8 1", "5 8", "7 3", "8 6" });


            // 6, 6, new int[] { 1, 2, 2, 3, 4, 5 }, new int[] { 2, 4, 5, 5,5, 6 }
            // 5, 6, new int[] { 1 ,1, 2 ,2 ,3, 4 }, new int[] { 2, 3, 3, 4, 4, 5, }
            // 2, 1, new int[] { 1 }, new int[] { 2}
           int minScore = ShoppingPatternGraph.getMinScore(6, 6, new int[] { 1, 2, 2, 3, 4, 5 }, new int[] { 2, 4, 5, 5, 5, 6 });

            int minScore1 = ShoppingPatternGraph.shoppingPatterns(2,  new List<int>{1}, new List<int> {2 });

            //(1,2), (2,5), (3,4), (4,6), (6,8), (5,7), (5,2), (5,2)
            var pars = new List<List<int>>() { new List<int> {1,2 } , new List<int> { 2,5 } , new List<int> {3,4} , 
                new List<int> {4,6} , new List<int> {6,8 }, new List<int> { 5,7}, new List<int> {5,2 }, new List<int> { 5,2}};
            GroupProductIdPairCategories.groupProductIdPairCategories(pars);

            //new int[] { 6, 5, 4, 3, 2, 1 }, 2);
            //new int[] { 9,9,9,9 }, 4);
            //new int[] { 11, 111, 22,222, 33, 333 ,44, 444 }, 6

            //new int[] {1,1,1 }, 3
            //new int[] { 7, 1, 7,1,7 ,1 }, 3

            var difficulty = DifficultyOfJobSchedule.MinDifficulty(new int[] { 6, 5, 4, 3, 2, 1 }, 2);
            
            
            //[30,20,150,100,40]
            //[60,60,60]
            //60 80 60
              PairsDivisibleByK.CountKdivPairs1(new int[] { 60,80,60 }, 60);
         //   PairsDivisibleByK.CountKdivPairs(new int[] { 60,80,60 }, 60);


            NearestCity.findNearestCities();



            //List<string> keywords = new List<string> { "anacell", "cetracular", "betacellular" };

            //List<string> review = new List<string> {
            //  "Anacell provides the best services in the city",
            //   "betacellular has awesome services",
            //  "Best services provided by anacell, everyone should use anacell"};

            List<string> keywords = new List<string> { "anacell", "cetracular", "betacellular", "deltacellular", "services" };

            List<string> review = new List<string> {
              "I love anacell Best services; Best services provided by anacell",
               "betacellular has great services",
              "eltacellular provides much better services than betacellular",
              "cetracular is worse than anacell",
              "Betacellular is better than deltacellular"};
            TopFrequentWordInSentence.topMentioned(2, keywords, review);

            AllDistinctSubstringSizeK.substrings("awaglknagawunagwkwagl", 4);
            AllDistinctSubstringSizeK.substrings("abacab", 3);


            //2, new int[] { 25, 23, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 76, 80 }
            //[1, 3, 5, 10, 80], instances = 2
            //[5, 10, 80], instances = 1

            //[80 10 20 30 50] 100000001
            int instances =UtilizationChecks.finalInstances(100000001, new int[] {80 ,10, 20, 30 ,50 });
   
            TransactionLogs.getFraudIds(new List<string> {"345366 89921 45","029323 38239 23","38239 345366 15",
                "029323 38239 77","345366 38239 23","029323 345366 13","38239 38239 23"}, 3);

            TransactionLogs.getFraudIds(new List<string> {"123456 123456 10","987657 918231 6",
                "123456 01 10","123456 10293 9","0 1 5","0 2 5"}, 3);

            var erliestTime=EarliestTimeToCompleteDeliveries.EarliestTime(2, new int[] { 8, 10 }, new int[] { 2, 2, 3, 1, 8, 7, 4, 5 });

            int[][] grid = new int[4][]{ new int[]{ 0, 1, 1, 0, 1 }, new int[]{ 0, 1, 0, 1, 0 }, new int[]{ 0, 0, 0, 0, 1 },new int[]{ 0, 1, 0, 0, 0 } };
            var minDaysToInfectAll=ZombieMatrix.minDaysToInfectAll(grid);

          var criticalPoints=  CriticalRouters.findCriticalConnections(7, 7, new List<int[]> { new int[] { 0, 1 } , new int[] { 0, 2 } ,
                new int[] { 1,3 } , new int[] { 2,3 } , new int[] { 2, 5 } ,new int[] { 5,6},new int[] { 3,4 }});

            //------------------------------------------
            List<List<int>> edges = new List<List<int>> { new List<int> { 1,4}, new List<int> { 4,5}, new List<int>() {2,3 } };
            List<List<int>> newEdges = new List<List<int>> { new List<int> { 1,2,5}, new List<int> {1,3,10 }, 
                new List<int>() {1,6,2 } ,new List<int>() {5,6,5 } };

            MinimumCostToConstructNewRoad.getMinimumCostToConstruct(6, edges, newEdges);
            MinCostToConstructNewRoad.minCostToConnectNodes(6, edges, newEdges);

            //-------------------------------------------

            //string input = "|**|*|*";
            // var ranges=new List<List<int>> { new List<int> {0,4 },new List<int>{0,6 } };

            string input = "*|*|*****|*|**";
            var ranges = new List<List<int>> { new List<int> { 1,3 }, new List<int> { 2,12 } };
            ItemsInContainers.numberOfItems(input, ranges);

          

        }
    }
}
