using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPrograming
{
    public class WordBreakCount
    {
        public static int GetWordBreakCount(List<string> dictionary, string txt)
        {
            var hashSet = new HashSet<string>(dictionary);
            int[] dp = new int[txt.Length + 1];
            dp[0] = 1;
            for (int i = 1; i <= txt.Length; i++)
            {
                var sb = new System.Text.StringBuilder();
                int sum = 0;

                for (int j = txt.Length - i; j < txt.Length; j++)
                {
                    sb.Append(txt[j]);
                    if (hashSet.Contains(sb.ToString()))
                    {
                        sum += dp[txt.Length - 1 - j];
                        sum %= 1000000007;
                    }
                }
                dp[i] = sum;
            }

            return dp[txt.Length];
        }

    }
}
