using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    public class LongestRepeatedSubstring
    {
        public static String GetCommonPrefix(String s, String t)
        {
            int n = Math.Min(s.Length, t.Length);
            for (int i = 0; i < n; i++)
            {
                if (s[i] != t[i])
                    return s.Substring(0, i);
            }
            return s.Substring(0, n);
        }


        public static String LongestCommonSubstring(String s)
        {

            // form the N suffixes
            int N = s.Length;
            String[] suffixes = new String[N];
            for (int i = 0; i < N; i++)
            {
                suffixes[i] = s.Substring(i, N - i);
            }

            // sort them
            Array.Sort(suffixes);

            String lrs = "";
            for (int i = 0; i < N - 1; i++)
            {
                String x = GetCommonPrefix(suffixes[i], suffixes[i + 1]);
                if (x.Length > lrs.Length)
                    lrs = x;
            }
            return lrs;
        }


        public static String LongestCommonSubstringTrie(String s)
        {
            int N = s.Length;
           
            Trie trie = new Trie();
            for (int i = 0; i < N; i++)
            {
               trie.Insert(s.Substring(i, N - i));
            }
            StringBuilder sb = new StringBuilder();
            int maxDepth = 0;
            string mostRepeatedString = string.Empty;
            LongestCommonSubstringHelper(trie.root, sb, ref maxDepth, ref mostRepeatedString);

            return mostRepeatedString;

        }

        public static void LongestCommonSubstringHelper(TrieNode root, StringBuilder sb, ref int maxDepth, ref string maxRepeatString)
        {
            if (root.Depth != 0 && root.Count < 2)
            {
                if (root.Depth - 1 > maxDepth)
                {
                    maxRepeatString = sb.ToString(0, sb.Length - 1);
                    maxDepth = root.Depth - 1;
                }
                return;
            }

            if (root.FindChildNode('$') != null )
            {
                if (root.Depth > maxDepth)
                {
                    maxRepeatString = sb.ToString();
                    maxDepth = root.Depth;
                }
                if(root.Children.Count==1)
                  return;

            }

            foreach (var child in root.Children)
            {
                if (child.Key == '$') continue;
                sb.Append(child.Key);
                LongestCommonSubstringHelper(child.Value, sb, ref maxDepth, ref maxRepeatString);
                sb.Remove(sb.Length - 1, 1);

            }
        }
    }

}
