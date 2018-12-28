using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphProblems.Common
{
    public class Vertex
    {
        public int Value { get; set; }

        public string Label { get; set; }

        public bool IsVisited { get; set; }

        public int InDegree { get; set; }

        public int OutDegree { get; set; }

        public List<Edge> Edges { get; set; }

        public Vertex(int value, string label=null)
        {
            this.Value = value;
            this.Label = label;
            this.IsVisited = false;
            Edges = new List<Edge>();
        }
    }
}
