using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayProblems
{
    public class MatrixSpirall
    {

       public  static void PrintMatrixSpiral( int[,] a)
        {
            int rowmax = a.GetLength(0);
            int colmax= a.GetLength(1); 
            int i, rowmin = 0, colmin = 0;
          

            while (rowmin < rowmax && colmin < colmax)
            {
                
                for (i = colmin; i < colmax; ++i)
                {
                    Console.Write(a[rowmin, i] + " ");
                }
                rowmin++;

             
                for (i = rowmin; i < rowmax; ++i)
                {
                    Console.Write(a[i, colmax - 1] + " ");
                }
                colmax--;


                if (rowmin < rowmax)
                {
                    for (i = colmax - 1; i >= colmin; --i)
                    {
                        Console.Write(a[rowmax - 1, i] + " ");
                    }
                    rowmax--;
                }


                if (colmin < colmax)
                {
                    for (i = rowmax - 1; i >= rowmin; --i)
                    {
                        Console.Write(a[i, colmin] + " ");
                    }
                    colmin++;
                }
            }
        }
          
    }
    
}
