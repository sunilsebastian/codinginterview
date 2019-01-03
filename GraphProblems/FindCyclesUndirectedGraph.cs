using GraphProblems.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphProblems
{
    public class FindCyclesUndirectedGraph
    {
        public static bool IsCycle(UnDirectedGraph g)
        {
            DisJointSets dj = new DisJointSets();
            Subset[] subsets = new Subset[g.Vertices.Length];

            dj.MakeSet(subsets);
            for (int i=0;i< g.Vertices.Length;i++)
            {
                int u = i;
                foreach(var edge in g.Vertices[i].Edges)
                {
                    int v = edge.Destination.Index;

                    int x = dj.FindSet(subsets, u);
                    int y = dj.FindSet(subsets, v);

                    if (x == y)
                    {
                        return true;
                    }

                    dj.Union(subsets, x, y);
                }
            }
            return false;
        }

    }
}
