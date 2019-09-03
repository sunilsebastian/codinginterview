using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphProblems
{
    public class AlienLanguage
    {
        public static string find_order(string[] words)
        {
            string result = "";
            
            Dictionary<char, List<char>> adjList = new Dictionary<char, List<char>>();
            Dictionary<char, int> inDegree = new Dictionary<char, int>();

            for (int i = 0; i < words.Length - 1; i++)
            {
                string word1 = words[i];
                string word2 = words[i + 1];

                for (int j = 0; j < Math.Min(word1.Length, word2.Length); j++)
                {
                    if (word1[j] != word2[j])
                    {
                        //Creating adjecency List
                        if(!adjList.ContainsKey(word1[j]))
                        {
                            var lst = new List<char>();
                            adjList.Add(word1[j], lst);
                        }
                        adjList[word1[j]].Add(word2[j]);

                        //Creating Indegress list
                        if(!inDegree.ContainsKey(word2[j]))
                        {
                            inDegree.Add(word2[j], 1);
                        }
                        else
                        {
                            inDegree[word2[j]]++;
                        }
                        if (!inDegree.ContainsKey(word1[j]))
                            inDegree.Add(word1[j], 0);
                        break;
                    }
                }
            }

            Queue<char> q = new Queue<char>();
            foreach (var k in inDegree.Keys)
            {
                if (inDegree[k] == 0)
                {
                    q.Enqueue(k);
                }
            }

            while (q.Count > 0)
            {
                char v1 = q.Dequeue();
                result = result + v1 + " ";

                if (!adjList.ContainsKey(v1)) continue;

                foreach (var neighbour in adjList[v1])
                {
                    inDegree[neighbour]--;
                    if (inDegree[neighbour] == 0)
                    {
                        q.Enqueue(neighbour);
                    }
                }
            }

            return (result == "") ? words[0][0].ToString() : result;

        }

    }
}
