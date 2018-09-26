using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class MissingElement
    {

        public static int FindMissingElement(int[] arr,int n)
        {
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
    }
}
