using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonProblems
{

 //Your music player allows you to choose songs to play, but only in pairs of songs with duration that add up to whole minute(60s)
    public class PairsDivisibleByK
    {

        //        Example 1:
        //Input: [30,20,150,100,40]
        //        Output: 3
        //Explanation:
        //Three pairs have a total duration divisible by 60:

        //(time[0] = 30, time[2] = 150): total duration 180

        //(time[1] = 20, time[3] = 100): total duration 120

        //(time[1] = 20, time[4] = 40): total duration 60

        //Example 2:
        //Input: [60,60,60]
        //        Output: 3

 //       (a + b) % K = 0
 //=>    a%K + b%K = 0
 //=>    a%K + b%K = K%K
 //=>    b%K = K%K - a%K
 //=>     b%K = (K - a%K) % K.     {Range of a%K => [0, K-1]
 
    //https://www.geeksforgeeks.org/count-number-of-pairs-in-array-having-sum-divisible-by-k-set-2/
    public static int CountKdivPairs(int[] A, int K)
        {
            // Create a frequency array to count
            // occurrences of all remainders when
            // divided by K
            int[] freq = new int[K];

            // To store count of pairs.
            int ans = 0;

            // Traverse the array, compute the remainder
            // and add k-remainder value hash count to ans
            for (int i = 0; i < A.Length; i++)
            {
                int rem = A[i] % K;

                // Count number of ( A[i], (K - rem)%K ) pairs
           
                ans += freq[(K - rem) % K];

                // Increment count of remainder in hash map
                freq[rem]++;
            }

            return ans;
        }


        //this is a Two sum problem. take mode of num and and diff
        //remoinder is added to dict
        public static int CountKdivPairs1(int[] A, int K)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
          //  List<(int, int)> pairs = new List<(int, int)>();

            int count = 0;

            for (int i = 0; i < A.Length; i++)
            {
                int rem = A[i] % K;

                var diff= (K - rem) % K;
                if (dict.ContainsKey(diff))
                {
                    count += dict[diff];
                 //   pairs.Add((A[i], diff));
                }

                if (!dict.ContainsKey(rem))
                {
                    dict.Add(rem, 1);
                }
                else
                    dict[rem]++;
            }

            return count;
        }
    }
}
