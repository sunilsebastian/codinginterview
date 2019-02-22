using System;
using System.Collections.Generic;

namespace GraphProblems
{
    public class TopologicalKhanAdjlist
    {
        private List<int>[] adjList = null;
        private int[] inDegree = null;
        private int count = 0;
        private int V;

        public TopologicalKhanAdjlist(int v)
        {
            int V = v;
            adjList = new List<int>[v];
            inDegree = new int[V];
            for (int i = 0; i < V; i++)
            {
                adjList[i] = new List<int>();
            }
        }

        public void AddEdge(int u, int v)
        {
            adjList[u].Add(V);
            inDegree[v]++;
        }

        public void PrintNodes()
        {
            Queue<int> q = new Queue<int>();

            for (int i = 0; i < inDegree.Length; i++)
            {
                if (inDegree[i] == 0)
                {
                    q.Enqueue(i);
                }
            }

            while (q.Count > 0)
            {
                int v1 = q.Dequeue();
                Console.Write(v1 + " ");
                count++;
                foreach (var neighbour in adjList[v1])
                {
                    inDegree[neighbour]--;
                    if (inDegree[neighbour] == 0)
                    {
                        q.Enqueue(neighbour);
                    }
                }
            }

            if (count != V)
            {
                Console.Write("Graph has cycles");
            }
        }
    }
}