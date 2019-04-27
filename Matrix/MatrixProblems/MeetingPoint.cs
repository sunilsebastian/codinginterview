using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixProblems
{
    public class MeetingPoint
    {
        public static  int MinTotalDistance(int[,] grid)
        {
            int m = grid.GetLength(0);
            int n = grid.GetLength(1);

            List<int> cols = new List<int>();
            List<int> rows = new List<int>();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i,j] == 1)
                    {
                        cols.Add(j);
                        rows.Add(i);
                    }
                }
            }

            int sum = 0;

            foreach(var i in  rows)
            {
                sum += Math.Abs(i - rows[(rows.Count) / 2]);
            }

            cols.Sort();

            foreach (var i in cols)
            {
                sum += Math.Abs(i - cols[(cols.Count) / 2]);
            }

            return sum;
        }
    }
}
