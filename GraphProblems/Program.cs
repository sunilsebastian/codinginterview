﻿using GraphProblems.Common;
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
            DirectedGraph graph = null;

            graph =GetGraph();
            Console.WriteLine("Depth First Traversal:");
            DepthFirstSearch.Traverse(graph);
            Console.WriteLine();

            graph = GetGraph();
            Console.WriteLine("Breadth First Traversal:");
            BreadthFirstSearch.Traverse(graph);
            Console.WriteLine();

            graph = GetGraph();
            Console.Write("Topological Sort(Khan's Algorithm: ");
            TopologicalSortKhan.ExceuteTopologicalSort(graph);
            Console.WriteLine();

            var graph1 = GetGraph1();
            string  result= FindCyclesUndirectedGraph.IsCycle(graph1)?"Yes":"No";
            Console.Write($"Check Is there Cycle in Undirected Graph DisjointSet: {result}");
            Console.WriteLine();


           
            result = FindCyclesUndirectedDFS.IsCycle(graph1) ? "Yes" : "No";
            Console.Write($"Check Is there Cycle in Undirected Graph DFS: {result}");
            Console.WriteLine();


            Console.Write("Minimum spnning tree: ");
            MinimumSpanningTreeKruskal.FindMinimumSpaningTree(graph1);


            Console.ReadLine();

        }

        private static DirectedGraph GetGraph(DirectedGraph graph=null)
        {
            if (graph == null)
                graph = new DirectedGraph();
            Vertex v0 = new Vertex(0, "A");
            Vertex v1 = new Vertex(1, "B");
            Vertex v2 = new Vertex(2, "C");
            Vertex v3 = new Vertex(3, "D");
            Vertex v4 = new Vertex(4, "E");
            Vertex v5 = new Vertex(5, "E");

            Vertex[] vertices = new Vertex[] { v0, v1, v2, v3, v4, v5 };
            graph.AddVertices(vertices);
            graph.AddEdge(v5, v2);
            graph.AddEdge(v5, v0);
            graph.AddEdge(v4, v0);
            graph.AddEdge(v4, v1);
            graph.AddEdge(v2, v3);
            graph.AddEdge(v3, v1);

            return graph;

        }

        private static UnDirectedGraph GetGraph1(DirectedGraph graph = null)
        {
           
            var graph1 = new UnDirectedGraph();
            Vertex v0 = new Vertex(0, "A");
            Vertex v1 = new Vertex(1, "B");
            Vertex v2 = new Vertex(2, "C");
            Vertex v3 = new Vertex(3, "D");
            
            Vertex[] vertices = new Vertex[] { v0, v1, v2, v3};
            graph1.AddVertices(vertices);
            graph1.AddEdge(v0, v1,5);
            graph1.AddEdge(v1, v2,6);
            graph1.AddEdge(v2, v3,1);
            //graph1.AddEdge(v3, v0,2);


            return graph1;

        }
    }
}
