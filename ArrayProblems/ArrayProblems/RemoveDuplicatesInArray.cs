using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class RemoveDuplicatesInArray
    {
        public static void RemoveDuplicatesUnsortedarray(int[] arr)
        {
         //Just check any element of same value exist from 0 to i (i excluded)
         //check current element with all elements for it , if not maches 
        // we can conclude that current element isa duplicate. 
            int[] temp = new int[arr.Length];


            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                bool dup = false;
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        dup = true;

                        break;
                    }
                }

                if (dup == false)
                {
                    temp[count] = arr[i];
                    count++;
                }

            }

            for (int k = 0; k < count; k++)
            {
                Console.Write(temp[k] + " ");
            }

        }

        public static void RemoveDuplicatesUnsortedarrayUsingHashSet(int[] arr)
        {
            HashSet<int> set = new HashSet<int>();
            int count = 0;

            for( int i=0;i<arr.Length;i++)
            {
                if(!set.Contains(arr[i]))
                {
                    set.Add(arr[i]);
                }
            }
            int[] result = new int[set.Count];
            foreach(int j in set)
            {
                result[count++] = j;
            }

            for (int k = 0; k < count; k++)
            {
                Console.Write(result[k] + " ");
            }

        }

        public static void RemoveDuplicatesInSortedArray(int[] arr)
        {
            int count = 0;
            int[] result = new int[arr.Length];
            result[count++] = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] != arr[i - 1])
                {
                    result[count++] = arr[i];
                }
            }

            for (int k = 0; k < count; k++)
            {
                Console.Write(result[k] + " ");
            }

        }


    }
}
