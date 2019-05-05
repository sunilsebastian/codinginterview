using System;

namespace DynamicPrograming
{
    public class LongestPalindrumSequence
    {
        public static int GetLongestPalindrumSequenceCount(string str)
        {
            int[,] T = new int[str.Length, str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                T[i, i] = 1;
            }
            for (int l = 2; l <= str.Length; l++)
            {
                for (int i = 0; i < str.Length - l + 1; i++)
                {
                    int j = i + l - 1; // take two chars,then 3 chars,4 char..take all chars

                    if (l == 2 && str[i] == str[j])
                    {
                        T[i, j] = 2;
                    }
                    else if (str[i] == str[j])
                    {
                        //diagonaly down left
                        T[i, j] = T[i + 1, j - 1] + 2;
                    }
                    else
                    {
                        T[i, j] = Math.Max(T[i + 1, j], T[i, j - 1]);
                    }
                }
            }
            return T[0, str.Length - 1];
        }
    }
}