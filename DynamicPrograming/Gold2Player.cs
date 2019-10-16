using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPrograming
{
    public class Gold2Player
    {
        public static int MaximizeFirstPlayerGain(int[] v)
        {
            var dp = new int[v.Length, v.Length];
            for (int i = 0; i < v.Length; i++)
            {
                dp[i, i] = v[i];
            }

            for (int i = 1; i < v.Length; i++)
            {
                dp[i - 1, i] = Math.Max(v[i - 1], v[i]);
            }

            //or you can take l=2
            for (int l = 3; l <= v.Length; l++) //l<v.Length
            {
                for (int i = 0; i <= v.Length - l; i++) //i<v.length
                {
                    int j = i + l - 1; //j=i+l
             
                    dp[i, j] = Math.Max(v[i] + Math.Min(dp[i + 2, j], dp[i + 1, j - 1]),
                                         v[j] + Math.Min(dp[i + 1, j - 1], dp[i, j - 2]));
                }
            }

            return dp[0, v.Length - 1];
        }
    }
}
