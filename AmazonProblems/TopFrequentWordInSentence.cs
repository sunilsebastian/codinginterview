using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AmazonProblems
{

    //Time Complexity O(nlog(K)) K is the sixe of heap
    //Space complexity O(n)  number of keyword matching review
    public class TopFrequentWordInSentence
    {
        public static List<String> topMentioned(int k, List<String> keywords, List<String> reviews)
        {
            List<string> result = new List<string>();

           //:? non capturing expression
           //\\b \\b  match a block of word not word part of other string or punctuation;

           string s = "\\b(:?" + String.Join("|", keywords) + ")\\b";
            Regex r = new Regex(s, RegexOptions.IgnoreCase);

            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (string review in reviews)
            {
                MatchCollection matches = r.Matches(review);

                HashSet<string> words = new HashSet<string>();
                foreach (Match m in   matches)
                {
                    words.Add(m.Value.ToLower());
                }
                foreach(string w in words)
                {
                    if (!dict.ContainsKey(w))
                    {
                        dict.Add(w, 1);
                    }
                    else
                        dict[w]++;
                }

            }

            PQ<string> pq = new PQ<string>(Comparer<string>.Create((a, b) =>(dict[a] == dict[b])? a.CompareTo(b): dict[a] - dict[b]));

            foreach (var item in dict)
            {
                if (pq.Count() < k)
                {
                    pq.Enqueue(item.Key);
                }
                else
                {
                    if (item.Value > dict[pq.Peek()])
                    {
                        pq.Dequeue();
                        pq.Enqueue(item.Key);
                    }
                }
            }

            while (pq.Count() != 0)
            {
                result.Insert(0,pq.Dequeue());

            }

            return result;
        }
    }
}

