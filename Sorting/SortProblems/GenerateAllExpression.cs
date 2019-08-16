using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortProblems
{
    public class GenerateAllExpression
    {
        public static string[] Generate(string s, long target)
        {
            List<string> results = new List<string>();
            generate_all_expressions(s, target, 0, 0, "", results, 0);
            return results.ToArray();
        }

       public  static void generate_all_expressions(string s, long target, int currPos, long prevVal, string prevStr, List<string> results, long currentVal)
        {
            if (s.Length == currPos)
            {
                if (currentVal == target)
                    results.Add(prevStr);

                return;
            }
            var currentPart = "";
            for (int i = currPos; i < s.Length; i++)
            {
                currentPart += s[i];
                long val = Convert.ToInt64(currentPart);

                if (currPos == 0)
                {
                    generate_all_expressions(s, target, i + 1, val, currentPart, results, val);
                }
                else
                {
                    generate_all_expressions(s, target, i + 1, val, prevStr + "+" + currentPart, results, val + currentVal);
                    generate_all_expressions(s, target, i + 1, prevVal * val, prevStr + "*" + currentPart, results, currentVal - prevVal + prevVal * val);

                }


            }
        }
    }
}
