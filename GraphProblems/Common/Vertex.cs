using System.Collections.Generic;

namespace GraphProblems.Common
{
    public class Vertex : VertexBase
    {
        public List<Edge> Edges { get; set; }

        public Vertex(int index, string label = null) : base(index, label)
        {
            this.Index = index;
            this.Label = label;
            this.IsVisited = false;
            Edges = new List<Edge>();
        }
    }
}