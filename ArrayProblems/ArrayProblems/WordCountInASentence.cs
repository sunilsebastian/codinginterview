using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class WordCountInASentence
    {
        public static int GetWordCount(string s)
        {
            int count = 0;
            int i = 0;
            for(i=s.Length-1;i>=1;i--)
            {
                if(s[i-1]==' ' && s[i]!=' ')
                {
                    count++;
                }
            }

            if(s[i]!=' ')
            {
                count++;
            }
            return count;
        }
    }
}
