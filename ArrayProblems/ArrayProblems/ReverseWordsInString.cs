using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class ReverseWordsInString
    {

        public static string GetReversedWordsInsentence(string sentence)
        {
            int count = 0;
            int i;
            string resultString = string.Empty;
            for (i= sentence.Length-1; i>=1;i--)
            {
            
                if(sentence[i]!=' ' && sentence[i-1] == ' ')
                {
                    resultString = resultString + sentence.Substring(i, count + 1) + " ";
                    count = 0;
                }
                else
                {
                    count++;
                }
            }

            resultString = resultString + sentence.Substring(i, count + 1);
            return resultString;

        }
    }
}
