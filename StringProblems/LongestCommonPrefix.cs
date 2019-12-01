using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    public class LongestCommonPrefix
    {
       public static string  GetLongestCommonPrefix(TrieNode root,string[] words)
       {
            StringBuilder sb = new StringBuilder();

            var result = LongestCommonPrefixHelper(root, words[0], 0, sb);
            return result;

       }

        private static string LongestCommonPrefixHelper(TrieNode root,string word, int index,StringBuilder sb)
        {
           if(root.Children.Count>1 || root.FindChildNode('$')!=null)
            {
                return sb.ToString();
            }

            char c = word[index];
            var node=root.FindChildNode(c);
            if (node == null)
                return null;
            sb.Append(c);

           return  LongestCommonPrefixHelper(node, word, index + 1, sb);

        }
    }
}
