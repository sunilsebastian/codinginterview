using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonProblems
{
    public class FiveStarRating
    {

        //sorting 
        //(a,b)=> a-b  ascending
        //(a,b)=> a.ComparedTo(b)  ascending
        //(a,b)=>{if(a<b) return -1; else 0}
        public static int MinimumNumberOfAdditionalFiveStar(int[][] productRatings, double Threshold)
        {
            PQ<(int, int)> pq = new PQ<(int, int)>(Comparer<(int, int)>.Create((o1, o2) => {

            double val1 = (double)(o1.Item1 + 1) / (o1.Item2 + 1) - (double)o1.Item1 / o1.Item2;
            double val2 = (double)(o2.Item1 + 1) / (o2.Item2 + 1) - (double)o2.Item1 / o2.Item2;
                //sort descending
                if (val1> val2)
                    return -1;
                return 1;

            }));

            //[[4,4],[1,2],[3,6]

            // [5/5-4/4, [2/3-1/2], [4/7-3/6] => [0,0.16,0.07] => Max Heap

            //Heap
            //      [1,2]
            //   [4,4]   [3,6]
            //


            // currentPercent=(4/4) + (1/2) + (3/6)=2
            //requiredPercentage= 77% of number of products = 2.31


            //steps

            // currentPercent=(4/4) + (2/3) + (3/6)=2.16 (removed 1/2 and added 2/3)
            // currentPercent=(4/4) + (3/4) + (3/6)=2.25 (removed 2/3 and added 3/4)
            // currentPercent=(4/4) + (3/4) + (4/7)=2.321 (removed 3/6 and added 4/7)


            double requiredPercentage = (double)Threshold * productRatings.Length / 100;
            double curPercent = 0;
            foreach (var rating in productRatings)
            {
                pq.Enqueue((rating[0],rating[1]));
                curPercent += (double)rating[0] / rating[1];
            }
            int count = 0;
            while (curPercent < requiredPercentage && pq.Count()!=0)
            {
                var r = pq.Dequeue();

                //remove the percentage from  current percentage
                curPercent -= (double)r.Item1 / r.Item2;

                int fivestarReqviews = r.Item1+1;
                int totalReviews = r.Item2+1;
               
                //Add the percenatge after increasing the 5start rating and total rating by 1
                curPercent += (double)fivestarReqviews / totalReviews;

                pq.Enqueue((fivestarReqviews,totalReviews));
                count++;
            }
            return curPercent < requiredPercentage ? -1 : count;


        }
    }
}
