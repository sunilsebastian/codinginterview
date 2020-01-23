using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{ 
    //checkin test
    public class Anagram
    {

        public static bool isStringsAnagram(string str1, string str2)
        {
            int[] charArray = new int[128];
            if (str1.Length != str2.Length)
                return false;
            else
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    charArray[str1[i]]++;
                }

                for (int i = 0; i < str2.Length; i++)
                {
                    charArray[str2[i]]--;

                    if (charArray[str2[i]] < 0)
                        return false;
                }

            }
            return true;
        }
    }
}
