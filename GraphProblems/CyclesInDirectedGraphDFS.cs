using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphProblems
{
    //https://www.geeksforgeeks.org/detect-cycle-in-a-graph/
    public class CyclesInDirectedGraphDFS
    {
        private  int V;
        private  List<int>[] adj;

        public CyclesInDirectedGraphDFS(int V)
        {
            this.V = V;
            adj = new List<int>[V];

            for (int i = 0; i < V; i++)
                adj[i] = new List<int>();
        }
        private bool isCyclicUtil(int i, bool[] visited, bool[] recStack)
        {
            if (recStack[i])
                return true;

            if (visited[i])
                return false;

            visited[i] = true;

            recStack[i] = true;
         
            foreach(var c in adj[i])
                if (isCyclicUtil(c, visited, recStack))
                    return true;

            recStack[i] = false;

            return false;
        }

        private void addEdge(int source, int dest)
        {
            adj[source].Add(dest);
        }

     
        private bool isCyclic()
        {
            bool[] visited = new bool[V];
            bool[] recStack = new bool[V];

            for (int i = 0; i < V; i++)
                if (isCyclicUtil(i, visited, recStack))
                    return true;

            return false;
        }
    }
}
