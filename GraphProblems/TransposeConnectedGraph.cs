using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphProblems
{
    public class GNode
    {
        public int val;
        public List<GNode> neighbours = new List<GNode>();

        public GNode(int _val)
        {
            val = _val;
            neighbours.Clear();
        }

    };



    public class TransposeConnectedGraph
    {
        public static GNode MakeGraph()
        {
            GNode g1 = new GNode(1);
            GNode g2 = new GNode(2);
            GNode g3 = new GNode(3);

            g3.neighbours.Add(g1);
            g2.neighbours.Add(g3);
            g1.neighbours.Add(g2);
            return g1;
        }


        public static GNode build_other_graph(GNode node)
        {
            Dictionary<int, GNode> dict = new Dictionary<int, GNode>();
            
            return DFSHelper(node, dict);
        }

        public static  GNode DFSHelper(GNode node, Dictionary<int, GNode> dict)
        {
            if (dict.ContainsKey(node.val))
                return dict[node.val];

            int n1 = node.val;
            var newNode = new GNode(n1);
            if (!dict.ContainsKey(n1))
            {
               
                dict.Add(n1,newNode);
                foreach (var neighbour in node.neighbours)
                {
                    var result = DFSHelper(neighbour, dict);

                    result.neighbours.Add(newNode);
                }

            }
            return newNode;

        }
    }


}
