using GraphProblems.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphProblems
{
    public class DijkstraShortestPath
    {
        public static void FindShortestPath(GraphMatrix g,int src)
        {
            int[] Dist = new int[g.Vertices.Length];
            int[] Parent = new int[g.Vertices.Length];


            for (int k = 0; k < Dist.Length; k++)
            {
                Dist[k] = Int32.MaxValue;
            }

            Dist[src] = 0;
            Parent[0] = -1;

            for(int i=0;i< g.Vertices.Length-1;i++)
            {
                var u = FindMin(g, Dist);

                g.Vertices[u].IsVisited = true;

                for(int v=0;v < g.Vertices.Length;v++)
                {
                    if(Dist[u]!=Int32.MaxValue 
                        && g.Vertices[v].IsVisited==false 
                        && g.AdjMatrix[u,v]!=Int32.MaxValue
                        && (Dist[u]+ g.AdjMatrix[u, v])< Dist[v]
                        )
                    {
                        Dist[v] = Dist[u] + g.AdjMatrix[u, v];
                        Parent[v] = u;
                    }

                }

            }

            PrintPath(g, Dist, Parent);

        }

        private static void PrintPath(GraphMatrix g, int[] Dist, int[] Parent)
        {
            for( int i=0;i<g.Vertices.Length;i++)
            {
                Console.WriteLine($"shortest path from  0 to {i} is {Dist[i]}");
                var p = Parent[i];

                //while (p!=-1 && Parent[p]!=-1)
                //{
                //    Console.Write($"{Parent[p]} -> {p}{g.AdjMatrix[Parent[p],p]}");
                //    p = Parent[p];
                //}

            }
        }

        private static int FindMin(GraphMatrix g, int[] Dist)
        {
            int index = -1;
            int min = Int32.MaxValue;

            for(int v=0;v< g.Vertices.Length;v++)
            {
                if (g.Vertices[v].IsVisited == false && Dist[v]<min)
                {
                    min = Dist[v];
                    index = v;
                }
            }
            return index;
        }
    }
}
