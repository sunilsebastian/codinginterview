﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonProblems
{
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
    }
}
