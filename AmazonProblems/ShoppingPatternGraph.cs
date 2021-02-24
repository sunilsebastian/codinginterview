using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonProblems
{
    public class ShoppingPatternGraph
    {
        static int min;
        public  static int getMinScore(int nodes, int edges, int[] from, int[] to)
        {
             min = Int32.MaxValue;
            Dictionary<int, HashSet<int>> adjList = new Dictionary<int, HashSet<int>>();
            for (int i = 0; i <edges; i++)
            {
                    if (!adjList.ContainsKey(from[i]))
                        adjList.Add(from[i], new HashSet<int>());
                    adjList[from[i]].Add(to[i]);

                    if (!adjList.ContainsKey(to[i]))
                        adjList.Add(to[i], new HashSet<int>());
                    adjList[to[i]].Add(from[i]);

              
            }
            bool[] visited = new bool[nodes + 1];
            for (int i = 1; i <= nodes; i++)
            {
                if (adjList.ContainsKey(i))
                {
                    dfs(i, i, adjList, visited, 0, 1);
                }
            }
            return min == Int32.MaxValue ? -1 : min;
        }

        private static void dfs(int start, int cur, Dictionary<int, HashSet<int>> adjList, bool[] visited, int score, int edge)
        {
            visited[cur] = true;

            HashSet<int> neighbours = adjList[cur];

            
            int curScore = neighbours.Count - edge;
            int totalScore = score + curScore;
            foreach (var ne in neighbours)
            {
                if (edge == 3)
                {
                    if (ne == start)
                    {
                        min = Math.Min(min, totalScore);
                    }
                }
                else if (!visited[ne] && edge < 3)
                {
                    dfs(start, ne, adjList, visited, totalScore, edge + 1);
                }
            }
            visited[cur] = false;
        }
    }
}
