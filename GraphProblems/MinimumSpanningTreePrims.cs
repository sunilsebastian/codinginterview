using GraphProblems.Common;
using System;

namespace GraphProblems
{
    public class MinimumSpanningTreePrims
    {
        public static void GetMinimumspanningTree(GraphMatrix g)
        {
            int[] Keys = new int[g.Vertices.Length];

            for (int k = 0; k < Keys.Length; k++)
            {
                Keys[k] = Int32.MaxValue;
            }

            int[] Parent = new int[g.Vertices.Length];
            Parent[0] = -1;
            Keys[0] = 0;

            //take v-1 iterations
            for (int i = 0; i < g.Vertices.Length - 1; i++)
            {
                //find the minimum value in key array
                var u = FindMin(g, Keys);
                g.Vertices[u].IsVisited = true;

                for (int v = 0; v < g.Vertices.Length; v++)
                {
                    if (g.AdjMatrix[u, v] != Int32.MaxValue
                        && g.Vertices[v].IsVisited == false
                        && g.AdjMatrix[u, v] < Keys[v])
                    {
                        Keys[v] = g.AdjMatrix[u, v];
                        Parent[v] = u;
                    }
                }
            }

            //Print the Minimum spanning tree
            for (int j = 1; j < Parent.Length; j++)
            {
                Console.Write($"{Parent[j]}-{j}({g.AdjMatrix[Parent[j], j]}) ");
            }
        }

        private static int FindMin(GraphMatrix g, int[] Keys)
        {
            int min = Int32.MaxValue; int index = -1;
            for (int i = 0; i < Keys.Length; i++)
            {
                if (g.Vertices[i].IsVisited == false && Keys[i] < min)
                {
                    min = Keys[i];
                    index = i;
                }
            }
            return index;
        }
    }
}