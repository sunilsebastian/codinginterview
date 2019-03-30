using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixProblems
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


        //board =
        //[
        //  ['A','B','C','E'],
        //  ['S','F','C','S'],
        //  ['A','D','E','E']
        //]

        //Given word = "ABCCED", return true.
        //Given word = "SEE", return true.
        //Given word = "ABCB", return false.

        public static bool Exist(char[,] board, String word)
        {
            int row = board.GetLength(0);   //length-->row
            int column = board.GetLength(1); //width -->column
            bool[,] visited = new bool[row,column];

            if (row * column < word.Length) return false;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    visited[i,j] = false;
                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (board[i,j] == word[0])
                    {
                        bool flag = Dfs(i, j, word, board, 0, visited);
                        if (flag)
                            return flag;
                    }
                }
            }
            return false;
        }
        public static bool Dfs(int i, int j, String word, char[,] board, int k, bool[,] visited)
        {
           
            if (k == word.Length)
            {
                return true;
            }
            if (i < 0 || j < 0 || i > board.GetLength(0) - 1 || j > board.GetLength(1) - 1 || visited[i,j] || board[i,j] != word[k]) return false;

                visited[i,j] = true;


            if (Dfs(i - 1, j, word, board, k + 1, visited) || Dfs(i + 1, j, word, board, k + 1, visited) || Dfs(i, j - 1, word, board, k + 1, visited) || Dfs(i, j + 1, word, board, k + 1, visited)) return true;

            visited[i,j] = false;
            return false;
        }
    }
}
