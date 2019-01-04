using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphProblems
{
    public class FloydWarshall
    {
        public static void  FindShortestPathToEveryVertexPair()
        {
            const int INF = Int32.MaxValue;

            int[,] graph = {
                        { 0, 5, INF, 10}, 
                        { INF, 0, 3, INF}, 
                        { INF, INF, 0, 1}, 
                        { INF, INF, INF, 0}
            };

            int V = graph.GetLength(0);

            for (int k=0;k<V; k++)
            {
                for (int i = 0; i < V; i++)
                {
                    for (int j = 0; j < V; j++)
                    {
                      if (graph[i, k] != INF &&
                         graph[k, j] != INF && 
                         graph[i, j]> (graph[i, k] + graph[k, j]))
                         {
                            graph[i, j] = (graph[i, k] + graph[k, j]);
                         }
                    }

                }

            }

            for (int i = 0; i < V; ++i)
            {
                for (int j = 0; j < V; ++j)
                {
                    if (graph[i, j] == INF)
                    {
                        Console.Write("INF ");
                    }
                    else
                    {
                        Console.Write(graph[i, j] + " ");
                    }
                }

                Console.WriteLine();
            }

        }
    }
}
