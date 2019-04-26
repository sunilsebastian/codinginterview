using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Common
{
    public class RandomNode
    {
        public int val;
        public RandomNode next;
        public RandomNode random;

        public RandomNode() { }
        public RandomNode(int _val, RandomNode _next, RandomNode _random)
        {
            val = _val;
            next = _next;
            random = _random;
        }
    }
}
