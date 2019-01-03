using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphProblems.Common
{
    public class VertexBase
    {
        public int Index { get; set; }

        public string Label { get; set; }

        public bool IsVisited { get; set; }

        public int InDegree { get; set; }

        public int OutDegree { get; set; }

        public VertexBase(int index, string label = null)
        {
            this.Index = index;
            this.Label = label;
            this.IsVisited = false;
        }
    }
}
