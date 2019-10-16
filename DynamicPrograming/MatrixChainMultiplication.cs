using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPrograming
{
    public class MatrixChainMultiplication
    {

        public static int Multply(int[] arr)
        {

            int[,] result = new int[arr.Length, arr.Length];
            int val = 0;

            for (int l = 2; l < arr.Length; l++)
            {
                for (int i = 0; i < arr.Length - l; i++)
                {
                    int j = i + l;
                    result[i, j] = Int32.MaxValue;
                    for (int k = i + 1; k < j; k++)
                    {
                        val = result[i, k] + result[k, j] + arr[i] * arr[k] * arr[j];
                        if (val < result[i, j])
                        {
                            result[i, j] = val;
                        }
                    }
                }
            }
            return result[0, arr.Length - 1];

        }
    }
}
