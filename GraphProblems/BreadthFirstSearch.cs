using GraphProblems.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphProblems
{
    public class BreadthFirstSearch
    {
        public static void Traverse(DirectedGraph g)
        {

            //for (int i = 0; i < g.Vertices.Length; i++)
            //{
            //    if (!g.Vertices[i].IsVisited)
            //        BFS(g.Vertices[i]);
            //}

            BFS(g.Vertices[5]);
        }

        private static void BFS(Vertex vertex)
        {
            vertex.IsVisited = true;
            Queue<Vertex> q = new Queue<Vertex>();
            q.Enqueue(vertex);

            while (q.Count() != 0)
            {
                var v = q.Dequeue();
                Console.Write($"{v.Label}({v.Value}) ");

                var edges = v.Edges;
                foreach(var edge in edges)
                {
                    var neighbourVertex = edge.Destination;
                    if (!neighbourVertex.IsVisited)
                    {
                        neighbourVertex.IsVisited = true;
                        q.Enqueue(neighbourVertex);

                    }

                }
            }

            

        }
    }
}
