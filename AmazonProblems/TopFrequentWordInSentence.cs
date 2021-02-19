using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AmazonProblems
{
    public class TopFrequentWordInSentence
    {

        public static List<String> PopMentioned(int k, List<String> keywords, List<String> reviews)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            List<string> result = new List<string>();

            foreach(var sentence in reviews)
            {
                var sentence1=Regex.Replace(sentence, @"[^a-zA-Z\s]", string.Empty);

                string[] words = sentence1.Split(' ');

                foreach(var word in words)
                {
                    string word1 = word.ToLower();
                    if (!keywords.Contains(word1)) continue;
                    if(!dict.ContainsKey(word1))
                    {
                        dict.Add(word1, 1);
                    }
                    else
                    {
                        dict[word1]++;
                    }

                }
            }

            PQ<string> pq = new PQ<string>(Comparer<string>.Create((a, b) => dict[a] - dict[b]));

            foreach(var item in dict)
            {
                if(pq.Count()<k)
                {
                    pq.Enqueue(item.Key);
                }
                else
                {
                    if(item.Value>dict[pq.Peek()])
                    {
                        pq.Dequeue();
                        pq.Enqueue(item.Key);
                    }
                }
            }

            while(pq.Count()!=0)
            {
                result.Add(pq.Dequeue());

            }

            return result;

        }
    }
}
