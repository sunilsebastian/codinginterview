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
            stratVertex.OutDegree++;
            stratVertex.InDegree++;
            endVertex.InDegree++;
            endVertex.OutDegree++;

            var edge1 = new Edge(stratVertex, endVertex, weight);
            stratVertex.Edges.Add(edge1);

            var edge2 = new Edge(endVertex, stratVertex,weight);
            endVertex.Edges.Add(edge2);
        }
    }
}
