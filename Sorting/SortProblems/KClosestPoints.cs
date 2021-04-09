using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortProblems
{
    public class KClosestPoints
    {
        //smallest or nearest=>Max Heap
        public static int[][] KClosest(int[][] points, int K)
        {
            PQ<Point> pq = new PQ<Point>(false);
           // PriorityQueue<Tuple<int,int>> pq1 = new PriorityQueue<Tuple<int,int>>(false);

            int rows = points.Length;
            
            for (int i = 0; i < rows; i++)
            {
                // distance[i] = (points[i][0] * points[i][0]) + (points[i][1] * points[i][1]);
                var p = new Point(points[i][0], points[i][1],i);

                if (pq.Count() < K)
                {
                   // pq.Enqueue(distance[i], new Tuple<int,int>(distance[i],i));

                    pq.Enqueue(p);
                }
                else
                {   if(p.CompareTo(pq.Peek())<0)
                    //if (distance[i] < pq.Peek().Item1)
                    {
                        pq.Dequeue();
                        pq.Enqueue(p);
                    }
                }
            }

            var result = new int[K][];
            int index = 0;
            for (int j = 0; j < K; j++)
            {
                result[index++] = points[pq.Dequeue().index];
            }
            return result;
        }

    }

    public class Point : IComparable<Point>
    {
        public int x { get; set; }
        public int y { get; set; }
        public  int index { get; set; }
        public Point(int val1, int val2,int idx)
        {
            x = val1;
            y = val2;
            index = idx;
        }
        public int CompareTo(Point p)
        {
            int distance1 = (this.x * this.x) + (this.y * this.y);
            int distance2 = (p.x * p.x) + (p.y * p.y);

            return distance1 - distance2;
        }

    }
}
