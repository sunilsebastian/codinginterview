using GraphProblems.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphProblems
{
    public class DepthFirstSearch
    {
        public static  void Traverse(DirectedGraph g)
        {
            for(int i=0;i<g.Vertices.Length;i++)
            {
                if (!g.Vertices[i].IsVisited)
                    DFS( g.Vertices[i]);
            }
        }

        private  static void DFS(Vertex vertex)
        {
          
            Console.Write($"{vertex.Label}({vertex.Value}) ");
            vertex.IsVisited = true;

            //var i = vertex.Edges.GetEnumerator();
            //while(i.MoveNext())
            //{
            //    var neighgourVertex = i.Current;
            //}

            var edges = vertex.Edges;
            foreach(var edge in edges)
            {

                var neighgourVertex = edge.Destination;
                if (!neighgourVertex.IsVisited)
                {
                    DFS(neighgourVertex);
                }
            }

        }
    }
}
