using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems

{
    public class WordLadder
    {
        //BFS
        //start = "hit"
        //end = "cog"
        //dict = ["hot","dot","dog","lot","log"]
        public static  int LadderLength(String beginWord, String endWord, List<String> wordDict)
        {
            Queue<WordNode> queue = new Queue<WordNode>();
            queue.Enqueue(new WordNode(beginWord, 1));

            wordDict.Add(endWord);

            while (queue.Count!=0)
            {
                WordNode top = queue.Dequeue();
                String word = top.word;

                if (word.Equals(endWord))
                {
                    return top.numSteps;
                }

                char[] arr = word.ToCharArray();
                for (int i = 0; i < arr.Length; i++)
                {
                    for (char c = 'a'; c <= 'z'; c++)
                    {
                        char temp = arr[i];
                        if (arr[i] != c)
                        {
                            arr[i] = c;
                        }

                        String newWord = new String(arr);
                        if (wordDict.Contains(newWord))
                        {
                            queue.Enqueue(new WordNode(newWord, top.numSteps + 1));
                            wordDict.Remove(newWord);
                        }

                        arr[i] = temp;
                    }
                }
            }

            return 0;
        }
        public static string[] string_transformation(string[] words, string start, string stop)
        {
            Dictionary<string, string> parent = new Dictionary<string, string>();
            Stack<string> st = new Stack<string>();
            bool flag = true;
            List<string> wordDict = words.ToList();
            if (!wordDict.Contains(stop))
            {
                wordDict.Add(stop);
            }
            int dictCount = wordDict.Count;

            if (words.Length == 0 && start == stop)
                return new string[] { "-1" };

            if (words.Length == 0)
                return new string[] { start, stop };

            parent.Add(start, "-1");

            Queue<string> queue = new Queue<string>();
            queue.Enqueue(start);

            while (queue.Count != 0)
            {
                string word1 = queue.Dequeue();

                if (word1.Equals(stop) && flag == false)
                {

                    string s = stop;
                    st.Push(s);
                    while (parent[s] != "-1")
                    {
                        st.Push(parent[s]);
                        s = parent[s];
                    }
                    break;
                }

                flag = false;

                List<string> valid = new List<string>();
                for (int i = 0; i < wordDict.Count; i++)
                {
                    string word = wordDict[i];
                    if (Diff(word, word1) == 1)
                    {
                        valid.Add(word);
                        queue.Enqueue(word);
                        if (!parent.ContainsKey(word))
                        {
                            parent.Add(word, word1);
                        }
                        if (start == stop || dictCount == 1)
                        {
                            st.Clear();
                            st.Push(stop);
                            st.Push(word);
                            st.Push(start);

                            return st.ToArray();
                        }
                    }
                }
                for (int i = 0; i < valid.Count; i++)
                {
                    wordDict.Remove(valid[i]);
                }
            }
            return (st.Count == 0) ? new string[] { "-1" } : st.ToArray();
        }


        private static int Diff(string word1, string word2)
        {
            int diff = 0;
            for (int i = 0; i < word1.Length; i++)
            {
                if (word1[i] != word2[i])
                    diff++;
            }
            return diff;
        }
    }

    public class WordNode
    {
        public String word { get; set; }
        public int numSteps { get; set; }

        public WordNode(String word, int numSteps)
        {
            this.word = word;
            this.numSteps = numSteps;
        }
    }


}
