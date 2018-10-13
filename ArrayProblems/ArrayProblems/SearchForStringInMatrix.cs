using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class SearchForStringInMatrix
    {
        public static bool FindString(Char[,] grid,string word)
        {
            bool isFind = false;
            for(int i=0;i<grid.GetLength(0);i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    isFind = FindStringInternal(word, grid, i, j);
                    if (isFind == true)
                        return true;
                }
            }
            return isFind;
        }

        private static bool FindStringInternal(string word, Char[,] grid, int i, int j)
        {
            bool found = false;
            int row = grid.GetLength(0);
            int col = grid.GetLength(1);
            int[] rowdir = { -1, -1, -1,  0, 0,  1, 1, 1 };
            int[] coldir = { -1,  0,  1, -1, 1, -1, 0, 1 };

            if (word[0] != grid[i, j])
                return false;

            for(int dir=0;dir<8;dir++)
            {
                int mi = i + rowdir[dir];
                int mj=j + coldir[dir];
                int k;
                for (k=1;k<word.Length;k++)
                {
                    if(mi<0 || mi>row || mj<0 || mj>col) 
                        break;
                    if (grid[mi, mj] != word[k])
                        break;
                    else
                    {
                        mi = mi + rowdir[dir];
                        mj = mj + coldir[dir];
                    }
                }
                if(k== word.Length)
                {
                    found = true;
                    break;
                }
            }
            return found;
        }
    }
}
