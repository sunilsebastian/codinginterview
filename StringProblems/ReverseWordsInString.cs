using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    public class ReverseWordsInString
    {

        public static string GetReversedWordsInsentence(string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence)) return string.Empty;
            if (sentence.Length == 1) return sentence;

            int count = 0;
            int i;
            StringBuilder resultString = new StringBuilder();

            for (i= sentence.Length-1; i>=1;i--)
            {
            
                if(sentence[i]!=' ' && sentence[i-1] == ' ')
                {
                    resultString.Append(sentence.Substring(i, count + 1) + " ");                   
                    count = 0;
                }
                else
                {
                    if (sentence[i] != ' ')
                    {
                        count++;
                    }
                }
            }

            resultString.Append(sentence.Substring(i, count + 1));
            return resultString.ToString().Trim();

        }
    }
}
