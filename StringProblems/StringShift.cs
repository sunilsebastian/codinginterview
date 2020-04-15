using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    public class StringShift
    {
        public static  string GetStringShift(string s, int[][] shift)
        {

            int lshiftCount = 0;
            int rshiftCount = 0;
          

            char[] arr = s.ToCharArray();
            for (int i = 0; i < shift.Length; i++)
            {
                if (shift[i][0] == 0)
                    lshiftCount += shift[i][1];
                else
                    rshiftCount += shift[i][1];
            }

            if (lshiftCount == rshiftCount)
                return s;

            if (lshiftCount > rshiftCount)
            {
                var k = lshiftCount - rshiftCount;
                Reverse(arr, 0, k - 1);
                Reverse(arr, k, arr.Length - 1);
                Reverse(arr, 0, arr.Length - 1);
            }
            else
            {
                var k = rshiftCount - lshiftCount;
                int a = arr.Length - k;
                Reverse(arr, 0, a - 1);
                Reverse(arr, a, arr.Length - 1);
                Reverse(arr, 0, arr.Length - 1);
            }

            return new String(arr);


        }

        public static void Reverse(char[] arr, int i, int j)
        {
            int start = i;
            int end = j;
            while (start < end)
            {
                var temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }


    }
}
