using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortProblems
{
    public class AllPossibleNQueen
    {
        public static string[][] GetNQueenPositions(int n)
        {
            int[,] mat = new int[n, n];

            var  result = new List<string[]>();
            Position[] position = new Position[n];

            NQueenHelper(mat, result, 0, n, position);

            return result.ToArray();
        }


        private static void NQueenHelper(int[,] mat, List<string[]> result, int row,int n, Position[] position)
        {
            //Base condition

            if(row==n)
            {
                Generate(result, position);
                return;
            }

            //loop through the cloumns
            for(int col=0;col<n;col++)
            {
                bool isSafe = true;

                //threat check for number of existing queens
                for(int queen=0;queen<row;queen++)
                {
                    if (position[queen].Column == col
                        || (position[queen].Row - position[queen].Column == row - col)
                        || (position[queen].Row + position[queen].Column == row + col))
                        {
                        isSafe = false;
                        break;
                    }
                }

                if(isSafe==true)
                {
                    position[row] = new Position(row, col);
                    NQueenHelper(mat,result, row+1, n, position);
                }

            }

        }
        public static void Generate(List<string[]> result, Position[] position)
        {
            string[] arr = new string[position.Length];
            for(int j=0;j<position.Length;j++)
            {
                string s = string.Empty;
                for ( int i=0;i< position.Length; i++)
                {
                    if(i== position[j].Column)
                    {
                        s+= "q";
                    }
                    else
                    {
                        s += "-";
                    }
                }
                arr[j] = s;

            }
            result.Add(arr);

        }
    }

   

    public class Position
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public Position(int row, int column)
        {
            Row = row;
            Column = column;
        }
    }
}
