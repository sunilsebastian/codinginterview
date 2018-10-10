using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class DuplicatesInArray
    {
        public static void FindDuplicates(int[] input)
        {   //0 1 2 3 4 5 6 7 8
            //1,2,3,3,2,4,5,5,6
            for (int i = 0; i < input.Length; i++)
            {
                if (input[Math.Abs(input[i])]>=0)
                {
                    input[Math.Abs(input[i])] = -input[Math.Abs(input[i])];
                }
                else
                {
                    Console.Write(Math.Abs(input[i]) + " ");
                }
            }

        }
    }
}
