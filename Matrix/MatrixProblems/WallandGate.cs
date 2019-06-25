using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixProblems
{

    //For example, given the 2D grid:
    //    INF  -1  0  INF
    //    INF INF INF  -1
    //    INF  -1 INF  -1
    //    0  -1 INF INF
    //After running your function, the 2D grid should be:
    //  3  -1   0   1
    //  2   2   1  -1
    //  1  -1   2  -1
    //  0  -1   3   4

    public class WallandGate
    {
        public static  void GetWallsAndGates(int[,] rooms)
        {
            if (rooms == null || rooms.GetLength(0) == 0 || rooms.GetLength(1) == 0)
                return;

            int m = rooms.GetLength(0);
            int n = rooms.GetLength(1);

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (rooms[i,j] == 0)
                    {
                        fill(rooms, i, j, 0);
                    }
                }
            }
        }

        public static void fill(int[,] rooms, int i, int j, int distance)
        {
            int m = rooms.GetLength(0);
            int n = rooms.GetLength(1);
            //idea here is neighbour will be grater distance than pev. so rooms[i,j] < distance condition is equivalent to visited
            if (i < 0 || i >= m || j < 0 || j >= n || rooms[i,j] < distance)
            {
                return;
            }

            rooms[i,j] = distance;

            fill(rooms, i - 1, j, distance + 1);
            fill(rooms, i, j + 1, distance + 1);
            fill(rooms, i + 1, j, distance + 1);
            fill(rooms, i, j - 1, distance + 1);
        }
    }
}
