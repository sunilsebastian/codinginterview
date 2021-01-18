using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixProblems
{
    public static class NQueen
    {
        public static Position[] SolveNQueenOneSolution(int n)
        {
            Position[] positions = new Position[n];
            bool hasSolution = SolveNQueenOneSolutionUtil(n, 0, positions);
            if (hasSolution)
            {
                return positions;
            }
            else
            {
                return new Position[0];
            }
        }

        private static  bool SolveNQueenOneSolutionUtil(int n, int row, Position[] positions)
        {
            if (n == row)
            {
                return true;
            }
            int col;
            for (col = 0; col < n; col++)
            {
                bool foundSafe = true;

                //check if this row and col is not under attack from any previous queen.
                for (int queen = 0; queen < row; queen++)
                {
                    if (positions[queen].col == col || // new queen is in same column of previous queen
                        positions[queen].row - positions[queen].col == row - col || //diagonal path
                        positions[queen].row + positions[queen].col == row + col) ////diagonal path
                    {
                        foundSafe = false;
                        break;
                    }
                }
                if (foundSafe)
                {
                    positions[row] = new Position(row, col);
                    if (SolveNQueenOneSolutionUtil(n, row + 1, positions))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }

    public class Position
    {
        public int row { get; set; }
        public int col { get; set; }
        public Position(int row, int col)
        {
            this.row = row;
            this.col = col;
        }
    }
}
