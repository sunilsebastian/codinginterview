using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public  class RotateMatrix
    {
        public static void RotateMatrix90(int[,] matrix)
        {
            int levelCount = matrix.GetLength(0) / 2;
            int last = matrix.GetLength(0) - 1;
            int level = 0;
            while(level < levelCount)
            {
                for(int i=level;i<last;i++)
                {
                    Swap(ref matrix[level, i], ref matrix[i, last]);
                    Swap(ref matrix[level, i],ref matrix[last, last - i + level]);
                    Swap(ref matrix[level, i],ref matrix[last - i + level, level]);

                }
                last--;
                level++;
            }
       
            //Print matrix
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0} ", matrix[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
