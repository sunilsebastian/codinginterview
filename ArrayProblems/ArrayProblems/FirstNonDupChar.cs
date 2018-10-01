using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class FirstNonDupChar
    {
        public static void FirstNonDuplicatingChar(string str)
        {
            int[] countArray = new int[128];

            foreach(char s in str)
            {
                countArray[s]++;
            }

            foreach (char s in str)
            {
                if (countArray[s]<2)
                {
                    Console.Write(s);
                    break;
                }
            }

        }
    }
}
