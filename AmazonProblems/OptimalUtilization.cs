using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonProblems
{

//    This problem is a variant of closest pair sum.You'll be given two arrays
//arr1 = { { 1, 2000}, { 2, 3000}, { 3, 4000} }
//    arr2 = { { 1, 5000 }, {2, 3000} }
//the first element of every pair represents id and the second value represents the value.
//and a target x = 5000
//Find the pairs from both the arrays whose vaue add upto a sum which is less than given target and should be close to the target.

//Output for the above example:
//{ {1, 2} } // Note that the output should be in id's



    //var group1 = new int[3][] { new int[] {1,2 }, new int[] {2,4 }, new int[] { 3,6} };
    //var group2 = new int[3][] { new int[] { 1, 2 }, new int[] { 2, 1 }, new int[] { 3, 3 } };
    //int target = 7;

    //var group1 = new int[4][] { new int[] { 1,3  }, new int[] { 2, 5 }, new int[] { 3, 7 }, new int[] { 4,10 } };
    //var group2 = new int[4][] { new int[] { 1, 2 }, new int[] { 2, 3 }, new int[] { 3, 4 }, new int[] { 4, 5 } };
    //int target = 10;
    // Output: [[2, 4], [3, 2]]

    //var group1 = new int[3][] { new int[] { 1, 8 }, new int[] { 2, 7 }, new int[] { 3, 14 } };
    //var group2 = new int[3][] { new int[] { 1,5 }, new int[] { 2, 10 }, new int[] { 3, 14 }};
    //int target = 20;
    //Output: [[3, 1]]
    public class OptimalUtilization
    {

        public static  List<int[]> getTargetSumIds(List<int[]> a, List<int[]> b, int target)
        {
            a.Sort(Comparer<int[]>.Create((x, y) => x[1] - y[1]));
            b.Sort(Comparer<int[]>.Create((x, y) => x[1] - y[1]));

            List<int[]> result = new List<int[]>();
            int max = Int32.MinValue;

            int m = a.Count;
            int n = b.Count;


            int i = 0;
            int j = n - 1;

            while (i < m && j >= 0)
            {
                int sum = a[i][1] + b[j][1];
                if (sum > target)
                {
                    --j;
                }
                else
                {
                    if (max <= sum)
                    {
                        if (max < sum)
                        {
                            max = sum;
                            result.Clear();
                        }
                        result.Add(new int[] { a[i][0], b[j][0] });
                        int index = j - 1;
                        while (index >= 0 && b[index][1] == b[index + 1][1])
                        {
                            result.Add(new int[] { a[i][0], b[index][0] });
                            index--;
                        }
                    }
                    ++i;
                }
            }
            return result;
        }

        //    public static List<List<int>> getTargetSumIds1(int[][] a, int[][] b, int target)
        //    {

        //        List<List<int>> lst = new List<List<int>>();
        //        Array.Sort(a, (x, y)=>x[1] - y[1]);

        //        Array.Sort(b, (x, y)=>x[1] - y[1]);

        //        int lowIndex = 0;
        //        int highIndex = a.Length - 1;
        //        PQ<Pair> q = new PQ<Pair>(false);
        //        while (lowIndex < b.Length && highIndex >= 0)
        //        {
        //            int sum = b[lowIndex][1] + a[highIndex][1];
        //            if (sum <= target)
        //            {
        //                q.Enqueue(new Pair(a[highIndex][0], b[lowIndex][0], sum));
        //                lowIndex++;
        //            }
        //            else
        //            {
        //                highIndex--;
        //            }
        //        }
        //        //Pq is used if there is morethan one value match the target;
        //        int largetSumValue = q.Peek().value;
        //        while (q.Count()!=0)
        //        {
        //            int curValue = q.Peek().value;
        //            if (curValue < largetSumValue)
        //                break;
        //            List<int> l = new List<int>();
        //            l.Add(q.Peek().id1);
        //            l.Add(q.Peek().id2);
        //            q.Dequeue();
        //            lst.Add(l);
        //        }
        //        return lst;
        //    }

        //}

        //class Pair:IComparable<Pair>
        //{
        //    public int id1 { get; set; }
        //    public int id2 { get; set; }
        //    public int value { get; set; }

        //    public Pair(int i, int j, int v)
        //    {
        //        this.id1 = i;
        //        this.id2 = j;
        //        this.value = v;
        //    }

        //    public int CompareTo(Pair other)
        //    {
        //        return this.value - other.value;
        //    }
        //}

    }
}