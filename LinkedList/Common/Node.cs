using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Common
{
    public class Node
    {
        public int Val { get; set; }

        public Node Next { get; set; }

        public Node(int val)
        {
            this.Val = val;
        }
    }
}
