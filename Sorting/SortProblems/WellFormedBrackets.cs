using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortProblems
{
    public class WellFormedBrackets
    {

        public static string[] GetWellFormedBrackets(int n)
        {
            List<string> result = new List<string>();
            WellFormedBracketsHelper(n, n, result, "");
            return result.ToArray();
        }


        public static void WellFormedBracketsHelper(int openBrackets, int closedBrackets, List<string> result, string resultString)
        {
            if (openBrackets == 0 && closedBrackets == 0)
            {
                result.Add(resultString);
                return;
            }
            if (openBrackets < 0)
            {
                return;
            }

            if (openBrackets == closedBrackets)
            {
                WellFormedBracketsHelper(openBrackets - 1, closedBrackets, result, resultString + "(");
            }
            else
            {
                WellFormedBracketsHelper(openBrackets - 1, closedBrackets, result, resultString + "(");
                WellFormedBracketsHelper(openBrackets, closedBrackets - 1, result, resultString + ")");
            }
        }
    }
}