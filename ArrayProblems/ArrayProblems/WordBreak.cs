using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class WordBreak
    {
      
        public static string BreakWorkBasedOnDictionary(string s, int index,List<string> lst)
        {
          
            StringBuilder b = new StringBuilder();
            for (int i = index; i < s.Length; i++)
            {
                b.Append(s[i]);
                if (lst.Contains(b.ToString()))
                {
                    var result = BreakWorkBasedOnDictionary(s, i + 1, lst);
                    if(result!=null)
                    {
                        return b.ToString() + " " + result; ;
                    }
                }
            }

            if(lst.Contains(b.ToString()))
            {
                return b.ToString();
            }

            return null;
        }
    }
}
