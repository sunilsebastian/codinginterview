using GraphProblems.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphProblems
{
    public class FindCyclesUndirectedDFS
    {
        public static bool IsCycle(UnDirectedGraph g)
        {
                 return   DFS(g.Vertices[0],null);
          
        }

        private static bool DFS(Vertex vertex,Vertex parent)
        {

            Console.Write($"{vertex.Label}({vertex.Value}) ");
            vertex.IsVisited = true;

            //var i = vertex.Edges.GetEnumerator();
            //while(i.MoveNext())
            //{
            //    var neighgourVertex = i.Current;
            //}

            var edges = vertex.Edges;
            foreach (var edge in edges)
            {

                var destVertex = edge.Destination;
                if (!destVertex.IsVisited)
                {
                    if (DFS(destVertex, edge.Source))
                    {
                        return true;
                    };
                }
                else if(destVertex.Value!=parent.Value)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
