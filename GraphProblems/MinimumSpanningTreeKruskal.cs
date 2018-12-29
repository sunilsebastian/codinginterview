using GraphProblems.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphProblems
{
    public class MinimumSpanningTreeKruskal
    {
        public static void FindMinimumSpaningTree(UnDirectedGraph g)
        {
            DisJointSets dj = new DisJointSets();
            Subset[] subsets = new Subset[g.Vertices.Length];
            List<Edge> edgeList = new List<Edge>();

            dj.MakeSet(subsets);

            for(int i=0;i<g.Vertices.Length;i++)
            {
                edgeList.AddRange(g.Vertices[i].Edges);
            }
            edgeList=edgeList.OrderBy(o => o.Weight).ToList();

            foreach (var edge in edgeList)
            {
                int x = dj.FindSet(subsets,edge.Source.Value);
                int y = dj.FindSet(subsets, edge.Destination.Value);

                if(x!=y)
                {
                    Console.Write($"({edge.Source.Value},{edge.Destination.Value}) ");
                    dj.Union(subsets, x, y);

                }
            }
        }

    }
}
