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

        //With duplicate case. may not be needed
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

     
        //  Algo monster solution. not handling duplicates. may not be needed
        public static List<List<int>> getPairs(List<List<int>> a, List<List<int>> b, int target)
        {
            a.Sort(Comparer<List<int>>.Create((x, y) => x[1] - y[1]));
            b.Sort(Comparer<List<int>>.Create((x, y) => x[1] - y[1]));

            int maxSum = Int32.MinValue;
            List<List<int>> maxPairs = new List<List<int>>();
            int i = 0;int j = b.Count-1;
            while(i<a.Count && j>=0)
            {
                List<int> x = a[i];
                List<int> y = b[j];
                int curSum = x[1] + y[1];
                if (curSum > target)
                {
                    j--;
                    continue;
                }
                //we need to get a pair closest to target(scurSum<=target) and less than target
                //aftre previous if we got that cuSumm is less than Target good.
                //check the current sum is more close to target than previous
                //if so mark current as maxSum.
                if (curSum > maxSum)
                {
                    maxSum = curSum;
                    maxPairs.Clear();
                }
                //this will add closest pair to list
                maxPairs.Add(new List<int> { x[0], y[0] });
                i++;
            }
            return maxPairs;
        }


    }
}