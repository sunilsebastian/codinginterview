using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonProblems
{
    public class GroupProductIdPairCategories
    {

        //This is purely graph connected component problem use DFS

        //Given a list of Product Id pairs, group them according to their categories and return the new list containing categorized Product Ids.

        //Input: ((1,2), (2,5), (3,4), (4,6), (6,8), (5,7), (5,2), (5,2))

        //Output: ((1,2,5,7), (3,4,6,8))

        //Test case I came up with:

        //Input: ((1,2), (2,5), (3,4), (4,6), (6,8), (5,7), (5,2), (3,1))

        //Output: ((1,2,5,7,3,4,6,8))


        public static List<List<int>> groupProductIdPairCategories(List<List<int>> pairs)
        {
            Dictionary<int, List<int>> adjList = new Dictionary<int, List<int>>();
            foreach( var pair in pairs)
            {
                if (!adjList.ContainsKey(pair[0]))
                    adjList.Add(pair[0], new List<int>());
                adjList[pair[0]].Add(pair[1]);

                if (!adjList.ContainsKey(pair[1]))
                    adjList.Add(pair[1], new List<int>());
                adjList[pair[1]].Add(pair[0]);

            }

            List<List<int>> disconnected = new List<List<int>>();
            bool[] visited = new bool[adjList.Keys.Count];

            foreach (int i in adjList.Keys)
            {
                List<int> lst = new List<int>();
                if (!visited[i - 1])
                {
                    Dfs(adjList, i, visited, lst);
                    disconnected.Add(lst);
                }
            }
            return disconnected;
        }

        private static void Dfs(Dictionary<int, List<int>> dict, int index, bool[] visited, List<int> lst)
        {
            visited[index - 1] = true;
            lst.Add(index);

            //if (!dict.ContainsKey(index)) return;
            foreach (var ne in dict[index])
            {
                if (!visited[ne - 1])
                {
                    Dfs(dict, ne, visited, lst);
                }
            }

        }

       

    }
}
