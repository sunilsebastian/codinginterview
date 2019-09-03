using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphProblems
{

//    A bipartite graph is possible if the graph coloring is possible using two colors such that vertices in a set are colored with the same color.
//Initialize a colorOfNode[] array for each node. Here are three states for colors array:

//-1: Not Colored.
//0: Color 1.
//1: Color 2.
//For each node

//If it hasn't been colored, use a color to color it. Then use the other color to color all its adjacent nodes (DFS).
//If it has been colored, check if the current color is the same as the color that is going to be used to color it.

    public class BipartiteGraph
    {
        public enum Colors
        {
            Red,
            Blue
        }

        public bool IsBipartite(IList<IList<int>> graph)
        {
            Dictionary<int, Colors> colors = new Dictionary<int, Colors>();
            Queue<int> nodes = new Queue<int>();
            nodes.Enqueue(0);
            colors.Add(0, Colors.Blue);

            while (true)
            {
                while (nodes.Count > 0)
                {
                    int node = nodes.Dequeue();
                    Colors nodeColor = colors[node];
                    Colors childColor = nodeColor == Colors.Red ? Colors.Blue : Colors.Red;

                    List<int> children = (List<int>)graph[node];
                    foreach (var child in children)
                    {
                        if (colors.ContainsKey(child))
                        {
                            if (colors[child] == nodeColor)
                            {
                                return false;
                            }
                        }
                        else
                        {
                            nodes.Enqueue(child);
                            colors.Add(child, childColor);
                        }
                    }
                }

                if (colors.Keys.Count == graph.Count)
                {
                    break;
                }
                else
                {
                    for (int i = 0; i < graph.Count; i++)
                    {
                        if (!colors.ContainsKey(i))
                        {
                            nodes.Enqueue(i);
                            colors.Add(i, Colors.Blue);
                            break;
                        }
                    }
                }
            }

            return true;

        }
    }
}
    
    
