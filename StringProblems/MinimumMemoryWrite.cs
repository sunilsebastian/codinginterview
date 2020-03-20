using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    public class MinimumMemoryWrite
    {
      
        public static string MoveLettersMinimizingMmemoryWrites(string s)
        {

            int i = -1;
            char[] arr = s.ToCharArray();
           
            for(int j=0;j<arr.Length;j++)
            {
                if (arr[j] >= 48 && arr[j] <= 57)
                    continue;
                i++;
                arr[i] = arr[j];
            }

            return new string(arr);

        }

    }
}
