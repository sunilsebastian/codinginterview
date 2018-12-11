using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class MaxConsecutiveRepatingChar
    {
        public static char FindMaxConsecutiveRepatingChar(string input)
        {
           
            char[] arr = input.ToCharArray();
            int i;
            int count = 1;
            int currentLargest = 0;
            char repeatingChar = arr[0];

            for(i=1;i<arr.Length;i++)
            {
                if(arr[i]==arr[i-1])
                {
                    count++;
                }
                else
                {
                    if(count> currentLargest)
                    {
                        repeatingChar = arr[i - 1];
                        currentLargest = count;
                    }

                    count = 1;
                }
            }
            if (count > currentLargest)
            {
                repeatingChar = arr[i-1];
            }

            return repeatingChar;
        }

    }
}
