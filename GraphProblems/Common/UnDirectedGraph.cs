using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphProblems.Common
{
    public class UnDirectedGraph
    {
        public Vertex[] Vertices { get; set; }

        public void AddVertices(Vertex[] vertices)
        {
            Vertices = vertices;
        }

        public void AddEdge(Vertex stratVertex, Vertex endVertex, int weight = 0)
        {
            var edge = new Edge(stratVertex, endVertex, weight);
            stratVertex.Edges.Add(edge);
        }
    }
}
