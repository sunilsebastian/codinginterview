using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeProblems.Common
{
    public class NodeN
    {
        public int Data { get; set; }

        public NodeN Left { get; set; }

        public NodeN Right { get; set; }

        public NodeN Next { get; set; }

        public NodeN(int data)
        {
            this.Data = data;
        }
    }
}
