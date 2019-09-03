using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixProblems
{
    public class ZombiesCluster
    {

        public static int zombieCluster(List<string> zombies)
        {
            int count = 0;
            int zombieCount = zombies.Count;
            int columns = zombies[0].Length;
            bool[] visited = new bool[zombieCount];

            for (int row = 0; row < zombieCount; row++)
            {
                if (visited[row] == false)
                {
                    visited[row] = true;
                    count++;
                }
                zombieClusterHelper(row, zombies, visited);
            }
            return count;

        }

        public static void zombieClusterHelper(int row, List<string> zombies, bool[] visited)
        {
            for (int col = 0; col < zombies[0].Length; col++)
            {
                if (zombies[row][col] == '1' && !visited[col])
                {
                    visited[col] = true;

                    //move to the new row connected to current row
                    //col become next row
                    zombieClusterHelper(col, zombies, visited);
                }
            }

        }
    }
}
