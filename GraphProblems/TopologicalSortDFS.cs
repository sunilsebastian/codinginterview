using GraphProblems.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GraphProblems
{
    public class TopologicalSortDFS
    {
        public static void ExceuteTopologicalSort(DirectedGraph g)
        {
            //543210
            Stack<int> stk = new Stack<int>();
            for (int i = 0; i < g.Vertices.Length; i++)
            {
                if (!g.Vertices[i].IsVisited)
                    DFS(g.Vertices[i], stk);
            }
            int count = 0;

            while (stk.Count() != 0)
            {
                Console.Write(stk.Pop() + " ");
                count++;
            }

            if (count != g.Vertices.Length)
            {
                Console.WriteLine("There exist a cycle in graph");
            }
        }

        private static void DFS(Vertex vertex, Stack<int> stk)
        {
            vertex.IsVisited = true;
            var edges = vertex.Edges;
            foreach (var edge in edges)
            {
                var neighgourVertex = edge.Destination;
                if (!neighgourVertex.IsVisited)
                {
                    DFS(neighgourVertex, stk);
                }
            }
            stk.Push(vertex.Index);
        }
    }
}