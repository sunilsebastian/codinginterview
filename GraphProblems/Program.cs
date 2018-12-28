using GraphProblems.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphProblems
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DirectedGraph graph = new DirectedGraph();
            Vertex v0 = new Vertex(0, "A");
            Vertex v1 = new Vertex(1, "B");
            Vertex v2 = new Vertex(2, "C");
            Vertex v3 = new Vertex(3, "D");
            Vertex v4 = new Vertex(4, "E");
            Vertex v5 = new Vertex(5, "E");

            Vertex[] vertices = new Vertex[] {v0, v1, v2, v3, v4, v5 };
            graph.AddVertices(vertices);
            graph.AddEdge(v5, v2);
            graph.AddEdge(v5, v0);
            graph.AddEdge(v4, v0);
            graph.AddEdge(v4, v1);
            graph.AddEdge(v2, v3);
            graph.AddEdge(v3, v1);

            Console.WriteLine("Depth First Traversal:");
            DeapthFirstSearch.Traverse(graph);
            Console.WriteLine();

            Console.Write("Topological Sort(Khan's Algorithm: ");
            TopologicalSortKhan.ExceuteTopologicalSort(graph);
            Console.ReadLine();


        }
    }
}
