using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixProblems
{

    //Given a 2D board containing 'X' and 'O', capture all regions surrounded by 'X'. A region is captured by flipping all 'O's into 'X's in that surrounded region.
    public class SorroundedRegions
    {
        public void Fill(char[,] board)
        {
            if (board == null || board.GetLength(0) == 0)
                return;

            int m = board.GetLength(0);
            int n = board.GetLength(1);

            //merge O's on left & right boarder
            for (int i = 0; i < m; i++)
            {
                if (board[i,0] == 'O')
                {
                    merge(board, i, 0);
                }

                if (board[i,n - 1] == 'O')
                {
                    merge(board, i, n - 1);
                }
            }

            //merge O's on top & bottom boarder
            for (int j = 0; j < n; j++)
            {
                if (board[0,j] == 'O')
                {
                    merge(board, 0, j);
                }

                if (board[m - 1,j] == 'O')
                {
                    merge(board, m - 1, j);
                }
            }

            //process the board
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (board[i,j] == 'O')
                    {
                        board[i,j] = 'X';
                    }
                    else if (board[i,j] == '#')
                    {
                        board[i,j] = 'O';
                    }
                }
            }
        }

        public void merge(char[,] board, int i, int j)
        {

            if (i< 0 || i > board.GetLength(0)-1
                 || j < 0 && j > board.GetLength(1)-1
                 && board[i, j] == 'X')
                return;


                board[i,j] = '#';

         
                    merge(board, i-1, j);
                    merge(board, i ,j+1);
                    merge(board, i +1, j);
                    merge(board, i, j-1);
        
        }
    }
}
