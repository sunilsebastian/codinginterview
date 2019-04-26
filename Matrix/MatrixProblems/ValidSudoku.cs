using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixProblems
{
    public class ValidSudoku
    {
        public static Boolean IsValidSudoku(char[,] board)
        {
            short[] rows = new short[9];
            short[] cols = new short[9];
            short[] squares = new short[9];
            for(int row=0;row<board.GetLength(1);row++)
            {
                for(int col=0;col<board.GetLength(1);col++)
                {
                   // Console.WriteLine($"{row} {col} ==>{3 * (row / 3) + col / 3}");

                    short value=(short)(1<<(board[row,col]-'1'));
                    if ((value & rows[row]) > 0) return false;
                    if ((value & cols[col]) > 0) return false;
                    if ((value & squares[3 * (row / 3) + col / 3]) > 0) return false;
                    rows[row] |= value;
                    cols[col] |= value;
                    squares[3 * (row / 3) + col / 3] |= value;

                }
            }
            return true;
        }
    }
}
