using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class StringUnique
    {
        public static bool isStringUniqueue(string s)
        {
            bool[] arr = new bool[128];
            char[] charArr = s.ToCharArray();
            var len = charArr.Length;
            for (int i = 0; i < len; i++)
            {
                int idx = (int)charArr[i];

                if (arr[idx] == true)
                    return false;
                else
                {
                    arr[idx] = true;
                }
            }
            return true;
        }
    }
}
