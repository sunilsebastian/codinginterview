using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonProblems
{
    public class CriticalRouters
    {
        //, DFS takes O(V+E) 
        //Space O(V)
        public static List<int> findCriticalConnections(int numNodes, int numEdges, List<int[]> edges)
            {
                if (edges == null || edges.Count==0) return new List<int>();

                int[]  visited = new int[numNodes];
                HashSet<int> result = new HashSet<int>();
                Dictionary<int, HashSet<int>> adjList = new Dictionary<int, HashSet<int>>();

        
            foreach (var pair in edges)
            {
                if (!adjList.ContainsKey(pair[0]))
                    adjList.Add(pair[0], new HashSet<int>());
                adjList[pair[0]].Add(pair[1]);

                if (!adjList.ContainsKey(pair[1]))
                    adjList.Add(pair[1], new HashSet<int>());
                adjList[pair[1]].Add(pair[0]);

            }
        

              Dfs(0, -1, adjList, 1,visited,result);

                 
                return new List<int>(result);
            }


            private static  int Dfs(int node, int prev, Dictionary<int, HashSet<int>> adjList, int marker,int[] visited, HashSet<int> result)
            {
                if (visited[node] == 0)
                {
                    visited[node] = marker;
                    HashSet<int> children = adjList[node];
                    foreach (var child in  children)
                    {
                        if (prev == child) continue;
                        int res = Dfs(child, node, adjList, marker + 1,visited,result);
                        if (res > marker)
                        {
                            if (children.Count > 1)
                                result.Add(node);
                            if (adjList[child].Count > 1)
                                result.Add(child);
                        }
                        else
                        {
                            visited[node] = res;
                        }
                    }
                }
                return visited[node];
            }
        }
}
