namespace DynamicPrograming
{
    public class LongestCommonSubstring
    {
        public static int GetLongestCommonSubstring(string str1, string str2)
        {
            int[,] dp = new int[str1.Length + 1, str2.Length + 1];

            int max = 0;
            for (int i = 1; i <= str1.Length; i++)
            {
                for (int j = 1; j <= str2.Length; j++)
                {
                    if (str1[i - 1] == str2[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                        if (max < dp[i, j])
                        {
                            max = dp[i, j];
                        }
                    }
                }
            }
            return max;
        }
    }
}