using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPrograming
{
    public class TextJustification
    {
        public static int Justify(String[] words, int width)
        {
            int[,] cost = new int[words.Length, words.Length];

            for (int i = 0; i < words.Length; i++)
            {
             
                cost[i, i] = width - words[i].Length;
              
              
                for (int j = i + 1; j < words.Length; j++)
                {
                    cost[i, j] = cost[i, j - 1] - words[j].Length - 1;
                   
                }
            }


            for (int i = 0; i < words.Length; i++)
            {
                for (int j = i; j < words.Length; j++)
                {
                    if (cost[i, j] < 0)
                    {
                        cost[i, j] = Int32.MaxValue;
                    }
                    else
                    {
                        cost[i, j] = (int)Math.Pow(cost[i, j], 3);
                    }
                }
            }

            int[] minCost = new int[words.Length];
            int[] result = new int[words.Length];

            for (int i = words.Length - 1; i >= 0; i--)
            {
                minCost[i] = cost[i, words.Length - 1];
                result[i] = words.Length;

                for (int j = words.Length - 1; j > i; j--)
                {
                    if (cost[i, j - 1] == Int32.MaxValue)
                    {
                        continue;
                    }
                    if (minCost[i] > minCost[j] + cost[i, j - 1])
                    {
                        minCost[i] = minCost[j] + cost[i, j - 1];
                        result[i] = j;
                    }
                }
                //exclude the last line
                if (result[i]==words.Length)
                {
                    minCost[i] = 0;
                }

            }

            return minCost[0];
        }
    }
}
