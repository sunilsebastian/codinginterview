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


        public static int FindNum(int[] arr, int key)
        {
            int keyindex = 0;
            if (arr == null || arr.Length == 0) return -1;

            if (arr.Length == 1 && arr[0] == key) return 0;
            int pivot = FindPivot(arr, 0, arr.Length - 1);


            if (pivot != -1 && arr[pivot] == key)
                return pivot;

            if (pivot == -1)
            {
                keyindex = BinarySearch(arr, 0, arr.Length - 1, key);
            }

            else if (key <= arr[pivot - 1] && key >= arr[0])
            {
                keyindex = BinarySearch(arr, 0, pivot - 1, key);
            }
            else
            {
                keyindex = BinarySearch(arr, pivot, arr.Length - 1, key);
            }
            return keyindex;
        }


        private static  int FindPivot(int[] arr, int start, int end)
        {

            if (arr[start] < arr[end]) return -1;

            if (start < end)
            {
                int mid = (start + end) / 2;

                if (arr[mid + 1] < arr[mid])
                    return mid + 1;
                if (arr[mid - 1] > arr[mid])
                    return mid;
                
                //this check is important
                if (arr[start] <= arr[mid])
                {
                    return FindPivot(arr, mid + 1, end);

                }
                else
                {
                    return FindPivot(arr, start, mid - 1);

                }

            }
            return -1;
        }


        public static int BinarySearch(int[] arr, int start, int end, int key)
        {
            //Binary serach is less than equal
            if (start <= end)
            {
                int mid = (start + end) / 2;

                if (key > arr[mid])
                {
                    return BinarySearch(arr, mid + 1, end, key);
                }
                else if (key < arr[mid])
                {
                    return BinarySearch(arr, start, mid - 1, key);
                }
                else
                {
                    return mid;
                }
            }

            return -1;
        }
    }
    }
