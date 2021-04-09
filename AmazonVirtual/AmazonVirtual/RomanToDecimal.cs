using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonVirtual
{
    class RomanToDecimal
    {
        public int RomanToInt(string s)
        {

            Dictionary<char, int> dict = new Dictionary<char, int>();
            dict.Add('I', 1);
            dict.Add('V', 5);
            dict.Add('X', 10);
            dict.Add('L', 50);
            dict.Add('C', 100);
            dict.Add('D', 500);
            dict.Add('M', 1000);

            int prev = dict[s[0]];
            int num = 0;
            num = num + prev;
            for (int i = 1; i < s.Length; i++)
            {
                int current = dict[s[i]];
                if (prev < current)
                {
                    num = (num - prev) + (current - prev);
                }
                else
                {
                    num = num + current;
                }

                prev = current;
            }

            return num;
        }

    }
}
