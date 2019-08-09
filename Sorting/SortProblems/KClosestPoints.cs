using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortProblems
{
    public class KClosestPoints
    {
        public static int[][] KClosest(int[][] points, int K)
        {

            PriorityQueue<Tuple<int,int>> pq = new PriorityQueue<Tuple<int,int>>(false);

            int rows = points.Length;
            int[] distance = new int[rows];

            for (int i = 0; i < rows; i++)
            {
                distance[i] = (points[i][0] * points[i][0]) + (points[i][1] * points[i][1]);

                if (pq.Count() < K)
                {
                    pq.Enqueue(distance[i], new Tuple<int,int>(distance[i],i));
                }
                else
                {
                    if (distance[i] < pq.Peek().Item1)
                    {
                        pq.Dequeue();
                        pq.Enqueue(distance[i], new Tuple<int, int>(distance[i], i));
                    }
                }
            }

            var result = new int[K][];
            int index = 0;
            for (int j = 0; j < K; j++)
            {
                result[index++] = points[pq.Dequeue().Item2];
            }


            return result;

        }

    }
}
