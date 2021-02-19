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

            // var result = LongestCommonPrefixHelper(root, words[0], 0, sb);
            var result = LongestCommonPrefixHelper(root, sb);
            return result;

       }

        //private static string LongestCommonPrefixHelper(TrieNode root,string word, int index,StringBuilder sb)
        private static string LongestCommonPrefixHelper(TrieNode root, StringBuilder sb)
        {
           if(root.Children.Count!=1 || root.FindChildNode('$')!=null)
            {
                return sb.ToString();
            }

            var item = root.Children.FirstOrDefault();

            sb.Append(item.Key);

            //  char c = word[index];
            //var node=root.FindChildNode(c);
            // if (node == null)
            //      return null;
            //  sb.Append(c);

            return LongestCommonPrefixHelper(item.Value, sb);

            //return  LongestCommonPrefixHelper(node, word, index + 1, sb);

        }
    }
}
