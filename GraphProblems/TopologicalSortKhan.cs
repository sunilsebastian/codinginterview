using GraphProblems.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphProblems
{
    public class TopologicalSortKhan
    {
        public static void ExceuteTopologicalSort(DirectedGraph g)
        {
            Queue<Vertex> q = new Queue<Vertex>();
            for (int i = 0; i < g.Vertices.Length; i++)
            {
                if (g.Vertices[i].InDegree == 0)
                {
                    q.Enqueue(g.Vertices[i]);
                }
            }
            int count = 0;
            while (q.Count() != 0)
            {
                Vertex vertex = q.Dequeue();
                Console.Write($"{vertex.Label}({vertex.Index}) ");

                var edges = vertex.Edges;

                foreach (var edge in edges)
                {
                    var dest = edge.Destination;
                    dest.InDegree--;
                    if (dest.InDegree == 0)
                    {
                        q.Enqueue(dest);
                    }
                }
                count++;
            }
            if (count != g.Vertices.Length)
            {
                Console.WriteLine("There exist a cycle in graph");
            }

        }
    }
}
