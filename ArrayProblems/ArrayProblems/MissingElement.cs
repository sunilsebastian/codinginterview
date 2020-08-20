using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class MissingElement
    {
        //very important n is arr.Length;
        public static int FindMissingElement(int[] arr,int n)
        {
            //n(n+1)/2
            int result = 0;

            for(int i=0;i<arr.Length; i++)
            {
                result = result ^ arr[i];

            }

            for (int i = 1; i <=n; i++)
            {
                result = result ^ i;

            }

            return result;
        }

        //https://leetcode.com/explore/featured/card/july-leetcoding-challenge/547/week-4-july-22nd-july-28th/3399/

        //Input:  [1,2,1,3,2,5]
        //Output: [3,5]
        public int[] SingleNumberIII(int[] nums)
        {

            int n = 0;
            int[] result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                n = n ^ nums[i];
            }

            //get the first bit which is different
            int diff = n & -n;

            for (int i = 0; i < nums.Length; i++)
            {
                if ((nums[i] & diff) == 0)
                    result[0] = result[0] ^ nums[i];
                else
                    result[1] = result[1] ^ nums[i];
            }

            return result;

        }
    }


}
