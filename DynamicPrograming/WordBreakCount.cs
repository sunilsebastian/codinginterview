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
            for (int l = 1; l <= txt.Length; l++)
            {
                var sb = new System.Text.StringBuilder();
                int sum = 0;

                for (int i = 0;i<l;i++)
                {
                    if (hashSet.Contains(txt.Substring(i, l - i)))
                    {
                        sum += dp[i];
                        sum %= 1000000007;
                    }
                }
                dp[l] = sum;
            }

            return dp[txt.Length];
        }

    }
}
