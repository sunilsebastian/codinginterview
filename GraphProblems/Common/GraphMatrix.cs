using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphProblems.Common
{
    public class GraphMatrix
    {
        public int[,] AdjMatrix { get; set; }
        public VertexBase[] Vertices { get; set; }

        private int nVertices;

        private const int Infinity = Int32.MaxValue;
        public GraphMatrix(int vetices)
        {
            nVertices = vetices;
            Vertices = new VertexBase[vetices];
            AdjMatrix = new int[vetices, vetices];
            for(int i=0;i< vetices;i++)
            {
                for(int j=0;j<nVertices;j++)
                {
                    AdjMatrix[i, j] = Infinity;
                }
            }
        }

        public void AddVertex(int index,string label)
        {
            Vertices[index] = new VertexBase(index, label);
        }

        public void AddVertices(VertexBase[] vertices)
        {
            Vertices = vertices;
        }

        public void AddEdge(Vertex startVertex, Vertex endVertex, int weight)
        {
            AdjMatrix[startVertex.Index, endVertex.Index] = weight;
        }

        public void AddUnDirectedEdge(Vertex startVertex, Vertex endVertex, int weight)
        {
            AdjMatrix[startVertex.Index, endVertex.Index] = weight;
            AdjMatrix[endVertex.Index, startVertex.Index] = weight;
        }
    }
}
