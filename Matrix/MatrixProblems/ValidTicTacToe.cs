using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixProblems
{
    public class ValidTicTacToe
    {
        int[,] matrix;
        int size = 0;

        public ValidTicTacToe(int n)
        {
            matrix = new int[n,n];
            size = n;
        }

        public int Move(int row, int col, int player)
        {
            matrix[row,col] = player;

            //check row
            bool win = true;
            for (int i = 0; i < size; i++)
            {
                if (matrix[row,i] != player)
                {
                    win = false;
                    break;
                }
            }

            if (win) return player;

            //check column
            win = true;
            for (int i = 0; i <size; i++)
            {
                if (matrix[i,col] != player)
                {
                    win = false;
                    break;
                }
            }

            if (win) return player;

            //check back diagonal
            win = true;
            for (int i = 0; i <size; i++)
            {
                if (matrix[i,i] != player)
                {
                    win = false;
                    break;
                }
            }

            if (win) return player;

            //check forward diagonal
            win = true;
            for (int i = 0; i < size; i++)
            {
                if (matrix[i,size - i - 1] != player)
                {
                    win = false;
                    break;
                }
            }

            if (win) return player;

            return 0;
        }
    }
}
