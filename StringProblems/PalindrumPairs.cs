using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    public class PalindrumPairs
    {
        //https://www.youtube.com/watch?v=-vdScGc8ebI&t=322s
        public static string[] join_words_to_make_a_palindrome(string[] words) {

             TrNode root = new TrNode('^');
             bool flag=false;
            var ans = new List<IList<int>>();
          
            for (int i = 0; i < words.Length; i++)
            {
                Build(root, words[i], i);
            }

            for (int i = 0; i < words.Length; i++)
            {
                List<int> result = new List<int>();
                Search(root, words[i], result);
                foreach (int ids in result)
                {
                    if (ids == i) continue;
                    List<int> pair = new List<int>();
                    pair.Add(i);
                    pair.Add(ids);
                    ans.Add(pair);
                }
                
                if(ans.Count>0)
                {
                    flag=true;
                    break;
                }
               
            }
            
            if(flag==true)
            {
                return new string[] { words[ans[0][0]], words[ans[0][1]] };
            }
            return new string[] {"NOTFOUND","DNUOFTON"};
        }

        public static IList<IList<int>> PalindromePairs(string[] words)
        {
            TrNode root = new TrNode('^');

            var ans = new List<IList<int>>();

            for (int i = 0; i < words.Length; i++)
            {
                Build(root, words[i], i);
            }

            for (int i = 0; i < words.Length; i++)
            {
                List<int> result = new List<int>();
                Search(root, words[i], result);
                foreach (int ids in result)
                {
                    if (ids == i) continue;
                    List<int> pair = new List<int>();
                    pair.Add(i);
                    pair.Add(ids);
                    ans.Add(pair);
                }

            }


            return ans;

        }

        private static void Search(TrNode node, String str, List<int> result)
        {

            if (str.Length == 0)
            {
                CheckPalindrumForMiddleChars(node, "", result);
                return;
            }

            if (node.end && IsPalindrome(str)) result.Add(node.index);
            char c = str[0];
            if (node.children.ContainsKey(c))
            {
                Search(node.children[c], str.Substring(1, str.Length - 1), result);
            }

        }

        private static void CheckPalindrumForMiddleChars(TrNode node, String str, List<int> result)
        {
            if (node.end && IsPalindrome(str)) result.Add(node.index);
            foreach (var child in node.children)
            {
                CheckPalindrumForMiddleChars(child.Value, str + child.Key, result);
            }
        }

        private static  void Build(TrNode node, String str, int index)
        {
            int len = str.Length;

            if (len == 0)
            {
                node.end = true;
                node.index = index;
                return;
            }

            char ch = str[len - 1];

            if (!node.children.ContainsKey(ch))
            {
                node.children.Add(ch, new TrNode(ch));
            }

            Build(node.children[ch], str.Substring(0, len - 1), index);
        }


        private static bool IsPalindrome(string str)
        {
            int i = 0;
            int j = str.Length - 1;
            while (i < j)
            {
                if (str[i] != str[j])
                    return false;
                i++;
                j--;
            }
            return true;

        }
    }

    public class TrNode
    {
        public char Val { get; set; }
        public bool end { get; set; }
        public int index { get; set; }
        public Dictionary<char, TrNode> children;

        public TrNode(char val)
        {
            this.Val = val;
            this.end = false;
            this.index = 0;
            this.children = new Dictionary<char, TrNode>();
        }
    }
}

