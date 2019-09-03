using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeProblems.Common
{
    public class NAryTreeNode
    {
            public int Data { get; set; }
            public List<NAryTreeNode> children = new List<NAryTreeNode>();
            public NAryTreeNode()
            {
                children.Clear();
            }
 
    }
}
