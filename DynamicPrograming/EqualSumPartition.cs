using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPrograming
{
    public class EqualSumPartition
    {
        public static int FirstFind(List<HashSet<int>> dp, int sum, int idx)
        {

            for (int i = 0; i <= idx; i++)
            {
                if (dp[i].Contains(sum))
                {
                    return i;
                }
            }

            return -1;
        }

        public static List<bool> EqualSubSetSumPartition(List<int> s)
        {
            // Write your code here
            List<bool> result = new List<bool>();

            int sum = 0;
            for (int i = 0; i < s.Count; i++)
            {
                sum += s[i];
            }

            if (sum % 2 == 1)
            {
                return result;
            }

            List<HashSet<int>> dp = new List<HashSet<int>>();

            dp.Add(new HashSet<int>());
            dp[0].Add(s[0]);

            for (int i = 1; i < s.Count; i++)
            {
                dp.Add(new HashSet<int>());
                dp[i].Add(s[i]);
                foreach (var k in dp[i - 1])
                {
                    dp[i].Add(k);
                    dp[i].Add(k + s[i]);
                }
            }

            for (int i = 0; i < dp.Count; i++)
            {
                if (dp[i].Contains(sum / 2))
                {
                    if (sum == 0 && i == dp.Count - 1)
                    {
                        return (new List<bool>());
                    }
                    for (int j = 0; j <= i; j++)
                    {
                        result.Add(false);
                    }

                    int value = sum / 2 - s[i];
                    int firstIndex = i;
                    result[firstIndex]= true;

                    while (value != 0)
                    {
                        firstIndex = FirstFind(dp, value, firstIndex);
                        if (firstIndex == -1)
                        {
                            return (new List<bool>());
                        }
                        result[firstIndex]= true;
                        value = value - s[firstIndex];
                    }

                    for (int j = i + 1; j < s.Count; j++)
                    {
                        result.Add(false);
                    }
                    return result;
                }
            }

            return result;

        }
    }
}
