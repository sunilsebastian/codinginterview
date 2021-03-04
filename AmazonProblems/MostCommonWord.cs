﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AmazonProblems
{
    public class FrequentWord
    {
        //https://leetcode.com/problems/most-common-word/

//        Time Complexity: O(N+M).

//O(N) time to process each stage of the pipeline as we built.

//In addition, we built a set out of the list of banned words, which would take O(M) time.

//Hence, the overall time complexity of the algorithm is \mathcal{ O}
//        (N + M)O(N+M).

//Space Complexity: O(N+M).
        public string MostCommonWord(string paragraph, string[] banned)
        {
            HashSet<string> hs = new HashSet<string>();
            Dictionary<string, int> dict = new Dictionary<string, int>();
        

            for (int j = 0; j < banned.Length; j++)
                hs.Add(banned[j].ToLower());

            string[] words = Regex.Split(paragraph, @"\W+");
            for (int k = 0; k < words.Length; k++)
            {
                if (hs.Contains(words[k].ToLower())) continue;
                if (dict.ContainsKey(words[k].ToLower()))
                    dict[words[k].ToLower()]++;
                else
                    dict.Add(words[k].ToLower(), 1);
            }


            string result = string.Empty;
            int max = 0;
            foreach (var item in dict)
            {
                if (item.Value > max)
                {
                    max = item.Value;
                    result = item.Key;
                }
            }

            return result;

        }
    }
}
