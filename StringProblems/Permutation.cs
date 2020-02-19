using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    public class Permutation
    {
        public static void Permute(string word)
        {
            Dictionary<char, int> dict = TokenCount(word);
            char[] result = new char[word.Length];
            char[] token = dict.Keys.ToArray<char>();
            int[] tokenCount = dict.Values.ToArray<int>();
            PermuteHelper(result, token, tokenCount, 0);
        }

        private static void PermuteHelper(char[] result,char[] token, int[] tokenCount,int level)
        {
            if(level==result.Length)
            {
                Console.Write(new String(result) +" ");
                return;
            }

            for(int i=0;i<token.Length;i++)
            {
                if (tokenCount[i] < 1)
                    continue;

                tokenCount[i]--;
                result[level] = token[i];

                PermuteHelper(result, token, tokenCount, level+1);

                tokenCount[i]++;
            }
        }

        private static Dictionary<char, int> TokenCount(string word)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            char[] array = word.ToCharArray();
            foreach(char c in array)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict.Add(c, 1);
                }
            }
            return dict;
        }


    }
}
