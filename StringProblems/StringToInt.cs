using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    public class StringToInt
    {
        public static int Convert(string s)
        {
            int index = 0;
            int num = 0;
            while(index < s.Length)
            {
                num = num * 10;
                num = num + (s[index++]-'0');
            }
            return num;
        }
    }
}
