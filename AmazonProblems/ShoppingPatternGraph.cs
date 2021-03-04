using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonProblems
{

    //Time O(V+E)

    //Space O(V)
    public class ShoppingPatternGraph
    {
        static int min;
        public  static int getMinScore(int nodes, int edges, int[] from, int[] to)
        {
             min = Int32.MaxValue;
            Dictionary<int, HashSet<int>> adjList = new Dictionary<int, HashSet<int>>();
           
            //forms the adjecency list
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


        #region algomonster solution

        public static int shoppingPatterns(int productsNodes, List<int> productsFrom, List<int> productsTo)
        {
           
            Dictionary<int, HashSet<int>> adjList = new Dictionary<int, HashSet<int>>();

            //forms the adjecency list
            for (int i = 0; i < productsFrom.Count; i++)
            {
                if (!adjList.ContainsKey(productsFrom[i]))
                    adjList.Add(productsFrom[i], new HashSet<int>());
                adjList[productsFrom[i]].Add(productsTo[i]);

                if (!adjList.ContainsKey(productsTo[i]))
                    adjList.Add(productsTo[i], new HashSet<int>());
                adjList[productsTo[i]].Add(productsFrom[i]);


            }
          
            int minSum = Int32.MaxValue;
            // all (u, v, w) where
            // - (u, v), (v, w), (u, w) are neighbors (trio)
            // - u < v < w (to avoid duplicates, as optimization)
            for (int u = 1; u <= adjList.Count; u++)
            {
                HashSet<int> uNeighbours = adjList[u];
                foreach (var  v in uNeighbours)
                {
                    if (v < u)
                        continue;
                    foreach (var w in uNeighbours)
                    {
                        HashSet<int> vNeighbours = adjList[v];
                        if (w < u || !vNeighbours.Contains(w))
                            continue;
                        HashSet<int> wNeighbours = adjList[w];
                        // each neighbors set include the other 2 in the trio,
                        // which we don't count in product score
                        int curSum = uNeighbours.Count + vNeighbours.Count + wNeighbours.Count - 6;
                        minSum = Math.Min(minSum, curSum);
                    }
                }
            }
            return minSum != Int32.MaxValue ? minSum : -1;
        }

        #endregion


    }
}
