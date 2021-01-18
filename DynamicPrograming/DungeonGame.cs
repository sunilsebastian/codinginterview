using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPrograming
{
    //https://leetcode.com/problems/dungeon-game/
    //https://leetcode.com/problems/minimum-path-sum/
    public class DungeonGame
    {
       //  -2   -3    3
       //  -5   -10   1
       //   10   30   -5

        //Refer book
        public static int CalculateMinimumHP(int[][] dungeon)
        {
            int rowMax = dungeon.Length - 1;
            int colMax = dungeon[0].Length - 1;

            int[,] result = new int[dungeon.Length, dungeon[0].Length];

            result[rowMax, colMax] = Math.Min(0, dungeon[rowMax][colMax]);

            //row
            for (int i = dungeon.Length - 2; i >= 0; i--)
            {
                result[i, colMax] = result[i + 1, colMax] + dungeon[i][colMax];
                if (result[i, colMax] > 0)
                    result[i, colMax] = 0;
            }

            //column
            for (int j = dungeon[0].Length - 2; j >= 0; j--)
            {
                result[rowMax, j] = result[rowMax, j + 1] + dungeon[rowMax][j];
                if (result[rowMax, j] > 0)
                    result[rowMax, j] = 0;
            }


            for (int i = dungeon.Length - 2; i >= 0; i--)
            {
                for (int j = dungeon[0].Length - 2; j >= 0; j--)
                {
                    result[i, j] = Math.Max(result[i, j + 1], result[i + 1, j]) + dungeon[i][j];
                    if (result[i, j] > 0) result[i, j] = 0;
                }
            }

            return Math.Abs(result[0, 0]) + 1;
        }
    }
}
