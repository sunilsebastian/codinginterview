using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonProblems
{
    //Amazon-OA-or-Amazon-Music-Runtime


    //You are on a flight and wanna watch two movies during this flight.
    //You are given int[] movie_duration which includes all the movie durations.
    //You are also given the duration of the flight which is d in minutes.
    //Now, you need to pick two movies and the total duration of the two movies is less than or equal to (d - 30min).
    //Find the pair of movies with the longest total duration. If multiple found, return the pair with the longest movie.

    //e.g.
    //Input
    //movie_duration: [90, 85, 75, 60, 120, 150, 125]
    //    d: 250

    //Output from aonecode.com
    //[90, 125]
    //90min + 125min = 215 is the maximum number within 220 (250min - 30min)

    //another problem similar:https://leetcode.com/discuss/interview-question/938809/Amazon-OA-or-Amazon-Music-Runtime
    public class MoviesOnFlight
    {
        public  static List<int> findPair(int[] durations, int d)
        {
         
            List<(int, int)> result = new List<(int, int)>();
         
            Array.Sort(durations);
            int max = Int32.MinValue;
            int start = 0, end = durations.Length - 1, target = d - 30;
            while (start < end)
            {
                int sum = durations[start] + durations[end];

                if (sum > target)
                {
                    end--;
                }
                else
                {
                    if (sum > max)
                    {
                        max = sum;
                        result.Clear();

                    }
                    result.Add((durations[start], durations[end]));

                    start++;

                }
            }

            //int[] pair = new int[2];
            //int mx = Int32.MinValue;
            //for(int i=0;i<result.Count;i++)
            //{
            //    int dif = Math.Abs(result[i].Item1 - result[i].Item2);
            //    if(dif>mx)
            //    {
            //        pair[0] = result[i].Item1;
            //        pair[1] = result[i].Item2;
            //    }
               
            //}

            if (result.Count > 0)
            {
                result.Sort(Comparer<(int, int)>.Create((a, b) => Math.Abs(b.Item1 - b.Item2) - Math.Abs(a.Item1 - a.Item2)));
                return new List<int> { result[0].Item1, result[0].Item2 };
            }

            return new List<int>();


        }

    }
}
