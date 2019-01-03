using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphProblems.Common
{
    public class Vertex:VertexBase
    {
        public List<Edge> Edges { get; set; }

        public Vertex(int index, string label=null):base(index,label)
        {
            this.Index = index;
            this.Label = label;
            this.IsVisited = false;
            Edges = new List<Edge>();
        }
    }
}
