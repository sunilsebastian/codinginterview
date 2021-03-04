using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonProblems
{

    #region mysolution
    public class MinimumCostToConstructNewRoad
    {
        public static int getMinimumCostToConstruct(int n, List<List<int>> edges, List<List<int>> newEdges)
        {
            if (n == 0) return 0;
            HashSet<int> hs = new HashSet<int>();
            var edgeList = new List<(int, int, int)>();
            DisJointSets djs = new DisJointSets();
            Subset[] subsets = new Subset[n+1];

            int totalCost = 0;


            //get all the edges from the adjecency list
            foreach (var item in edges)
            {
                edgeList.Add((item[0], item[1],0));
                edgeList.Add((item[1], item[0],0));

                hs.Add(item[0]);
                hs.Add(item[1]);
            }

            foreach (var newIitem in newEdges)
            {
                edgeList.Add((newIitem[0], newIitem[1], newIitem[2]));
                edgeList.Add((newIitem[1], newIitem[0], newIitem[2]));
                hs.Add(newIitem[0]);
                hs.Add(newIitem[1]);
            }

            //All nodes are not connected by the available edges;
            //if (hs.Count != n) return -1; 

            edgeList.Sort((a, b) => a.Item3 - b.Item3);


            djs.MakeSet(subsets);

            foreach (var edge in edgeList)
            {
                int x = djs.FindSet(subsets, edge.Item1);
                int y = djs.FindSet(subsets, edge.Item2);

                //exclude the edge if the reperesenting vertex is equal
                //it means there is a cycle so do not need to include in spanning tree
                if (x != y)
                {
                    totalCost += edge.Item3;
                    djs.Union(subsets, x, y);
                }
            }
            return totalCost;
        }
    }

    public class Subset
    {
        public int Parent { get; set; }
        public int Rank { get; set; }
    }

    public class DisJointSets
    {
        public void MakeSet(Subset[] subsets)
        {
            for (int i = 1; i <subsets.Length; i++)
            {
                subsets[i] = new Subset();
                subsets[i].Parent = i;
                subsets[i].Rank = 0;
            }
        }

        public int FindSet(Subset[] subsets, int i)
        {
            if (subsets[i].Parent != i)
                subsets[i].Parent = FindSet(subsets, subsets[i].Parent);

            return subsets[i].Parent;
        }
        public void Union(Subset[] subsets, int x, int y)
        {
            int xpos = FindSet(subsets, x);
            int ypos = FindSet(subsets, y);

            if (subsets[xpos].Rank > subsets[ypos].Rank)
            {
                subsets[ypos].Parent = xpos;
            }
            else if (subsets[xpos].Rank < subsets[ypos].Rank)
            {
                subsets[xpos].Parent = ypos;
            }
            else
            {
                subsets[xpos].Parent = ypos;
                subsets[ypos].Rank++;
            }
        }


    }

    #endregion


    #region algomonster solution
    //time complexity is O(E log V),
    //space complexity O(V)
    public class MinCostToConstructNewRoad
    {
        public static int minCostToConnectNodes(int n, List<List<int>> edges, List<List<int>> newEdges)
        {
            UnionFind uf = new UnionFind();
            foreach (var uv in edges)
                uf.Union(uv[0], uv[1]);
            int cost = 0;
            foreach (var  edge in newEdges.OrderBy(e=>e[2]))
            {
                int s = uf.Find(edge[0]);
                int t = uf.Find(edge[1]);
                if (s == t)
                    continue;
                cost += edge[2];
                uf.Union(s, t);
            }
            return cost;
        }
    }
    public  class UnionFind
    {
        private Dictionary<int, int> dict= new Dictionary<int, int>();
       
        public int Find(int x)
        {
           int parent = dict.ContainsKey(x) ? dict[x] : x;
            if (parent != x)
            {
                parent = Find(parent);
                dict[x]= parent;
            }
            return parent;
        }
        public void Union(int x, int y)
        {
            dict.Add(Find(x), Find(y));
        }
    }
    #endregion
}

