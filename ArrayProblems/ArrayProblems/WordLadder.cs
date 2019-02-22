using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphProblems
{
    public class WordLadder
    {
        public int ladderLength(String beginWord, String endWord, List<String> wordDict)
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
