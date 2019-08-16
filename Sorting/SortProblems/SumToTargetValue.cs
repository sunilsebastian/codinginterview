using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortProblems
{
    public class SumToTargetValue
    {
        public static bool check_if_sum_possible(long[] arr, long k)
        {

           // var result=  CheckSumHelper(arr, 0, 0, k, 0);
           var result= CheckSumHelper(arr, k, 0, 0);
            return result;

        }

        //Inclusion Exclusion
        public static bool  CheckSumHelper(long[] arr, long k,long sum, int trackPointer)
        {
            if (trackPointer == arr.Length)
            {
                if (sum == k)
                    return true;
                return false;

            }
            //Exclude
            if(CheckSumHelper(arr, k, sum, trackPointer+1))
            {
                return true;
            }
            long val = arr[trackPointer];

            //Include
            if (CheckSumHelper(arr, k, sum+val, trackPointer+1))
            {
                return true;
            }
            return false;
        }

        private static bool CheckSumHelper(long[] arr, long currval, long prevval, long k, int trackPointer)
        {
            if (trackPointer == arr.Length)
            {
                return false;

            }
            long sum = 0;

            for (int i = trackPointer; i < arr.Length; i++)
            {
                long val = arr[i];

                sum = (currval + val);

                if (sum == k)
                    return true;

                if (CheckSumHelper(arr, sum, val, k, trackPointer+1))
                {
                    return true;
                }
            }

            return false;
        }

    }
}
