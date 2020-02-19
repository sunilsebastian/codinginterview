using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    public class ZigZagConversion
    {
        public static string ZigZagConvert(string s, int numRows)
        {
            if(s==null ||s.Length<2||numRows<2)
            {
                return s;
            }
            List<StringBuilder> list = new List<StringBuilder>();
            for(int i=0;i<numRows;i++)
            {
                list.Add(new StringBuilder());

            }
            int index = 0;
            bool goingDown = true;
            for(int i=0;i<s.Length;i++)
            {
                char c = s[i];
                list[index].Append(c);
                if(goingDown)
                {
                    if(index==numRows-1)
                    {
                        index = numRows - 2;
                        goingDown = false;
                    }
                    else
                    {
                        index++;
                    }
                }
                else
                {
                    if(index== 0)
                    {
                        index++;
                        goingDown = true;
                    }
                    else
                    {
                        index--;
                    }
                }
            }

            StringBuilder res = new StringBuilder();
            foreach(var text in list)
            {
                res.Append(text.ToString());

            }

            return res.ToString();
        }
    }
}
