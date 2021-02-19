using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonProblems
{

//    Input:
//a = [[1, 2], [2, 4], [3, 6]]
//b = [[1, 2]]
//target = 7

//Output: [[2, 1]]

//Explanation:
//There are only three combinations[1, 1], [2, 1], and[3, 1], which have a total sum of 4, 6 and 8, respectively.
//Since 6 is the largest sum that does not exceed 7, [2, 1] is the optimal pair.
    public class OptimalUtilization
    {

        public static List<List<int>> getTargetSumIds(int[][] a, int[][] b, int target)
        {

            List<List<int>> lst = new List<List<int>>();
            Array.Sort(a, (x, y)=>x[1] - y[1]);

            Array.Sort(b, (x, y)=>x[1] - y[1]);

            int lowIndex = 0;
            int highIndex = a.Length - 1;
            PQ<Pair> q = new PQ<Pair>(false);
            while (lowIndex < b.Length && highIndex >= 0)
            {
                int sum = b[lowIndex][1] + a[highIndex][1];
                if (sum <= target)
                {
                    q.Enqueue(new Pair(a[highIndex][0], b[lowIndex][0], sum));
                    lowIndex++;
                }
                else
                {
                    highIndex--;
                }
            }
            //Pq is used if there is morethan one value match the target;
            int largetSumValue = q.Peek().value;
            while (q.Count()!=0)
            {
                int curValue = q.Peek().value;
                if (curValue < largetSumValue)
                    break;
                List<int> l = new List<int>();
                l.Add(q.Peek().id1);
                l.Add(q.Peek().id2);
                q.Dequeue();
                lst.Add(l);
            }
            return lst;
        }

    }

    class Pair:IComparable<Pair>
    {
        public int id1 { get; set; }
        public int id2 { get; set; }
        public int value { get; set; }

        public Pair(int i, int j, int v)
        {
            this.id1 = i;
            this.id2 = j;
            this.value = v;
        }

        public int CompareTo(Pair other)
        {
            return this.value - other.value;
        }
    }

}
