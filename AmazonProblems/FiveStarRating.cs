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

            double percentage = (double)Threshold * productRatings.Length / 100;
            double curPercent = 0;
            foreach (var rating in productRatings)
            {
                pq.Enqueue((rating[0],rating[1]));
                curPercent += (double)rating[0] / rating[1];
            }
            int count = 0;
            while (curPercent < percentage && pq.Count()!=0)
            {
                var r = pq.Dequeue();
                curPercent -= (double)r.Item1 / r.Item2;
                int fivestarReqviews = r.Item1+1;
                int totalReviews = r.Item2+1;
                curPercent += (double)fivestarReqviews / totalReviews;
                pq.Enqueue((fivestarReqviews,totalReviews));
                count++;
            }
            return curPercent < percentage ? -1 : count;


        }
    }
}
