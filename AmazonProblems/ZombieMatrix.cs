using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonProblems
{
    public class ZombieMatrix
    {
		public  static int minDaysToInfectAll(int[][] grid)
		{
			Queue<(int,int)> q = new Queue<(int,int)>();
			
			//total count of items in the array
			int target = grid.Length * grid[0].Length;
			int cnt = 0, res = 0;
			for (int i = 0; i < grid.Length; i++)
			{
				for (int j = 0; j < grid[0].Length; j++)
				{
					if (grid[i][j] == 1)
					{
						q.Enqueue((i, j ));
						cnt++;
					}
				}
			}
			int[][] dirs =new int[4][] { new int[]{ 0, 1 }, new int[]{ 0, -1 },new int[] { 1, 0 }, new int[]{ -1, 0 } };
			while (q.Count()!=0)
			{
				int size = q.Count();
				if (cnt == target)
					return res;

				for (int i = 0; i < size; i++)
				{
					var cur = q.Dequeue();
					foreach (var  dir in dirs)
					{
						int ni = cur.Item1 + dir[0];
						int nj = cur.Item2 + dir[1];

						if (ni >= 0 && ni < grid.Length && nj >= 0 && nj < grid[0].Length && grid[ni][nj] == 0)
						{
							cnt++;
							q.Enqueue((ni,nj));
							grid[ni][nj] = 1;
						}
					}
				}
				//result incremented after infecting all in the level
				res++;
			}
			return -1;
		}
	}
}
