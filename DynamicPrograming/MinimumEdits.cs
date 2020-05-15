using System;

namespace DynamicPrograming
{
    //Levenshtein Distance
    public class MinimumEdits
    {
        public static int FindMinimumEdits(string str1, string str2)
        {
            int[,] temp = new int[str1.Length + 1, str2.Length + 1];

            for (int i = 0; i < temp.GetLength(1); i++)
            {
                temp[0, i] = i;
            }

            for (int i = 0; i < temp.GetLength(0); i++)
            {
                temp[i, 0] = i;
            }

            for (int i = 1; i <= str1.Length; i++)
            {
                for (int j = 1; j <= str2.Length; j++)
                {
                    if (str1[i - 1] == str2[j - 1])
                    {
                        temp[i, j] = temp[i - 1, j - 1]; //get the diagonal
                    }
                    else
                    {
                        temp[i, j] = 1 + min(temp[i - 1, j - 1], temp[i - 1, j], temp[i, j - 1]);
                    }
                }
            }

            return temp[str1.Length, str2.Length];
        }

        private static int min(int a, int b, int c)
        {
            int l = Math.Min(a, b);
            return Math.Min(l, c);
        }
    }
}