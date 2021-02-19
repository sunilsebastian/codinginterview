using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonProblems
{
    public class KnightMoves
    {

        public static int getNumberOfValidMoves(int k, int r, int c)
        {
            int[][] dirs = new int[][]
            {
            new int[] {2,1},
            new int[] {1,2},
            new int[] {-2,1},
            new int[] {-1,2},
            new int[] {2,-1},
            new int[] {1,-2},
            new int[] {-2,-1},
            new int[] {-1,-2},
            };
            Queue<int[]> q = new Queue<int[]>();
            q.Enqueue(new int[] { r, c });
            while (q.Count > 0)
            {
                int count = q.Count;
                for (int i = 0; i < count; i++)
                {
                    int[] pos = q.Dequeue();
                    foreach (int[] dir in dirs)
                    {
                        int nr = dir[0] + pos[0];
                        int nc = dir[1] + pos[1];
                        if (nr >= 0 && nr < 8 && nc < 8 && nc >= 0)
                        {
                            q.Enqueue(new int[] { nr, nc });
                        }
                    }
                }
                k--;
                if (k == 0) 
                    return q.Count;

            }
            return 0;
        }
    }
}
