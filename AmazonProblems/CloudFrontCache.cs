using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonProblems
{
    public class CloudFrontCache
    {
        // G(V, E) with |V| vertices and |E| edges using DFS or BFS has O(|V|+|E|) complexity.

       // Space compexity O(V)
        //DFS and connected components
        public static int ConnectedSum(int n, List<string> edges)
        {
            bool[] visited = new bool[n];
            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();


            foreach (var edge in edges)
            {
                string[] arr = edge.Split(' ');
                int start = Int32.Parse(arr[0]);
                int end = Int32.Parse(arr[1]);

                if (!dict.ContainsKey(start))
                {
                    dict.Add(start, new List<int>());
                }
                dict[start].Add(end);

                if (!dict.ContainsKey(end))
                {
                    dict.Add(end, new List<int>());
                }
                dict[end].Add(start);

            }

            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (!visited[i - 1])
                {
                   int count= Dfs(dict, i, visited);
                    sum += (int)Math.Ceiling(Math.Sqrt(count));
                  
                }
            }


            return sum ;
        }


        private static int Dfs(Dictionary<int, List<int>> dict, int index, bool[] visited)
        {
            visited[index - 1] = true;
          
            if (!dict.ContainsKey(index)) return 1;
            int count = 0;
            foreach (var ne in dict[index])
            {
                if (!visited[ne - 1])
                {
                   count+= Dfs(dict, ne, visited);
                }
            }

            return count + 1;

        }
    }
}
