using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatrixProblems
{
    public class MatrixSpirall
    {

       public  static void PrintMatrixSpiral( int[,] a)
        {
            int rowmax = a.GetLength(0);
            int colmax= a.GetLength(1); 
            int i, rowmin = 0, colmin = 0;

            int dir = 0;

            while (rowmin < rowmax && colmin < colmax)
            {
                if (dir == 0)
                {
                    for (i = colmin; i < colmax; ++i)
                    {
                        Console.Write(a[rowmin, i] + " ");
                    }
                    rowmin++;
                }

                else if (dir == 1)
                {
                    for (i = rowmin; i < rowmax; ++i)
                    {
                        Console.Write(a[i, colmax - 1] + " ");
                    }
                    colmax--;
                }
                else if (dir == 2)
                {
                    for (i = colmax - 1; i >= colmin; --i)
                    {
                        Console.Write(a[rowmax - 1, i] + " ");
                    }
                    rowmax--;
                }
                else if (dir == 3)
                {
                    for (i = rowmax - 1; i >= rowmin; --i)
                    {
                        Console.Write(a[i, colmin] + " ");
                    }
                    colmin++;
                }

                dir = (dir + 1) % 4;
            }
        }
          
    }
    
}
