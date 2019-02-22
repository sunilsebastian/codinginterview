using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class RotateArray
    {
        public static void Rotate1(int[] array, int rotVal)
        {
            int len = array.Length;

            for (int i = 0; i < rotVal; i++)
            {
                int temp = array[len - 1];
                ShiftNum(array, array[len - 1]);

            }
        }

        public static void ShiftNum(int[] array, int righVal)
        {
            for (int i = array.Length - 2; i >= 0;i--)
            {
                array[i + 1] = array[i];

            }
            array[0] = righVal;
        }

        public static void Rotate(int[] arr, int order)
        {
            if (arr == null || arr.Length == 0 || order < 0)
            {
                return;
            }

            if (order > arr.Length)
            {
                order = order % arr.Length;
            }

            //length of first part
            int a = arr.Length - order;

            reverse(arr, 0, a - 1);
            reverse(arr, a, arr.Length - 1);
            reverse(arr, 0, arr.Length - 1);

            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");

        }

        public static void reverse(int[] arr, int left, int right)
        {
            if (arr == null || arr.Length == 1)
                return;

            while (left < right)
            {
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
                left++;
                right--;
            }
        }
    }
}
