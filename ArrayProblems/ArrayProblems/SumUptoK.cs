using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class SunmUptoK
    {
        public static void SortedSumUpToK(int[] arr,int k)
        {
            int max = arr.Length - 1;
            int min = 0;

            while(max>min)
            {
                int sum = arr[min] + arr[max];
                if (sum<k)
                {
                    min++;
                }
                else if(sum>k)
                {
                    max--;
                }
                else
                {
                    Console.Write($"({arr[min]},{arr[max]}) ");
                    min++;
                    max--;
                }
            }
        }

        public static void UnSortedSumUpToK(int[] arr,int k)
        {
            HashSet<int> set = new HashSet<int>();
            for(int i=0;i<arr.Length;i++)
            {
                if(set.Contains(k- arr[i]))
                {
                    Console.Write($"({arr[i]},{k- arr[i]}) ");
                }
                else
                {
                    set.Add(arr[i]);
                }
            }
         
        }
    
          
            public static void FindPairIndex(int[] arr, int k)
            {
                var dict = new Dictionary<int, int>();

                for (int i = 0; i < arr.Length; i++)
                {
                    if (dict.ContainsKey(k -arr[i]))
                    {
                         Console.Write($"({dict[k - arr[i]]},{i}) ");
                
                    }
                    dict.Add(arr[i], i);
                }
            }

        

    }
}
