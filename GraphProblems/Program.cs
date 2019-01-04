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


            Console.Write("Minimum spnning tree Kruskal: ");
            MinimumSpanningTreeKruskal.FindMinimumSpaningTree(graph1);
            Console.WriteLine();

            Console.Write("Minimum spnning tree Prim's: ");
            var matUndirectedGraph = GetMatGraph();
            MinimumSpanningTreePrims.GetMinimumspanningTree(matUndirectedGraph);
            Console.WriteLine();

            Console.Write("Shortest path: ");
            var g = GetMatGraph1();
            DijkstraShortestPath.FindShortestPath(g,0);
            Console.WriteLine();

            FloydWarshall.FindShortestPathToEveryVertexPair();
            Console.WriteLine();

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

        private static GraphMatrix GetMatGraph(GraphMatrix graph = null)
        {
            var matGraph = new GraphMatrix(6);
            Vertex v0 = new Vertex(0, "A");
            Vertex v1 = new Vertex(1, "B");
            Vertex v2 = new Vertex(2, "C");
            Vertex v3 = new Vertex(3, "D");
            Vertex v4 = new Vertex(4, "E");
            Vertex v5 = new Vertex(5, "F");

            Vertex[] vertices = new Vertex[] { v0, v1, v2, v3,v4,v5 };
            matGraph.AddVertices(vertices);
            matGraph.AddUnDirectedEdge(v0, v3, 1);
            matGraph.AddUnDirectedEdge(v0, v1, 3);
            matGraph.AddUnDirectedEdge(v1, v2, 1);
            matGraph.AddUnDirectedEdge(v1, v3, 3);
            matGraph.AddUnDirectedEdge(v2, v3, 1);
            matGraph.AddUnDirectedEdge(v2, v5, 4);
            matGraph.AddUnDirectedEdge(v2, v4,1);
            matGraph.AddUnDirectedEdge(v3, v4, 6);
            matGraph.AddUnDirectedEdge(v4, v5, 2);
           
            return matGraph;

        }

        private static GraphMatrix GetMatGraph1(GraphMatrix graph = null)
        {
            var matGraph = new GraphMatrix(8);
            Vertex v0 = new Vertex(0, "A");
            Vertex v1 = new Vertex(1, "B");
            Vertex v2 = new Vertex(2, "C");
            Vertex v3 = new Vertex(3, "D");
            Vertex v4 = new Vertex(4, "E");
            Vertex v5 = new Vertex(5, "F");
            Vertex v6 = new Vertex(6, "G");
            Vertex v7 = new Vertex(7, "H");

            Vertex[] vertices = new Vertex[] { v0, v1, v2, v3, v4, v5 ,v6,v7};
            matGraph.AddVertices(vertices);
            matGraph.AddEdge(v0, v1,20);
            matGraph.AddEdge(v0, v3, 80);
            matGraph.AddEdge(v0, v6, 90);
            matGraph.AddEdge(v1, v5, 10);
            matGraph.AddEdge(v2, v3, 10);
            matGraph.AddEdge(v2, v5, 50);
            matGraph.AddEdge(v2, v7, 20);
            matGraph.AddEdge(v3, v2, 10);
            matGraph.AddEdge(v3, v6, 20);

            matGraph.AddEdge(v4, v1, 50);
            matGraph.AddEdge(v4, v6, 30);

            matGraph.AddEdge(v5, v2, 10);
            matGraph.AddEdge(v5, v3, 40);

            matGraph.AddEdge(v6, v0, 20);

            return matGraph;

        }
    }
}
