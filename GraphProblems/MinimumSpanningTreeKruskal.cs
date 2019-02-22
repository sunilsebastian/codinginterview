using GraphProblems.Common;
using System;
using System.Collections.Generic;
using System.Linq;

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

            for (int i = 0; i < g.Vertices.Length; i++)
            {
                edgeList.AddRange(g.Vertices[i].Edges);
            }
            edgeList = edgeList.OrderBy(o => o.Weight).ToList();

            foreach (var edge in edgeList)
            {
                int x = dj.FindSet(subsets, edge.Source.Index);
                int y = dj.FindSet(subsets, edge.Destination.Index);

                if (x != y)
                {
                    Console.Write($"({edge.Source.Index},{edge.Destination.Index}) ");
                    dj.Union(subsets, x, y);
                }
            }
        }
    }
}