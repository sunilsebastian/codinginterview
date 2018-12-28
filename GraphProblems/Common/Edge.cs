using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphProblems.Common
{
    public class Edge
    {
        public Vertex Source { get; set; }
        public Vertex Destination { get; set; }
        public int Weight { get; set; }

        public Edge(Vertex source, Vertex destination, int weight)
        {
            this.Source = source;
            this.Destination = destination;
            this.Weight = weight;
        }
    }
}
