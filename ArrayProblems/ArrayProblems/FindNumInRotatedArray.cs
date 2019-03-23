using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class FindNumInRotatedArray
    {
        //1 2 3 4 //pivot -1 ie no pivot. its not rotated
        //3 4 1 2  //assume 1 is the pivot;

        //6 7 8 1 2 3 4  //assume 1 is the pivot;
        public static int  FindNum(int[] arr,int key)
        {
            int keyindex = 0;
            int pivot = FindPivot(arr);

            if (arr[pivot] == key)
                return pivot;

            if( key<= arr[pivot-1]  && key>=arr[0])
            {
                keyindex= BinarySearch(arr, 0, pivot - 1, key);
            }
            else
            {
                keyindex= BinarySearch(arr,pivot, arr.Length-1, key);
            }
            return keyindex;

        }

        public static int BinarySearch(int[] arr, int start, int end,int key)
        {
            while(start<end)
            {
                int mid = (start + end) / 2;

                if(key>arr[mid])
                {
                    start = mid + 1;
                }
                else if(key< arr[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    return mid;
                }
            }

             return -1;
        }

        public static int FindPivot(int[] arr)
        {
            int start = 0;
            int end = arr.Length - 1;

            if (arr[start] < arr[end]) return -1;

            while(start<end)
            {
               int  mid = (start + end) / 2;

                if (arr[mid + 1] < arr[mid])
                    return mid + 1;
                if (arr[mid - 1] > arr[mid])
                    return  mid;

                if(arr[start]<=arr[mid])
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid-1;
                }

            }
            return -1;
        }
    }
}
