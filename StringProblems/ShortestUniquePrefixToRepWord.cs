using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    public class ShortestUniquePrefixToRepWord
    {
        public static Dictionary<string,string> GetShortestUniquePrefixToRepWord(TrieNode trieNode, string[] words)
        {

            var prefixMapping = new Dictionary<string, string>();

            for(int i=0;i<words.Length;i++)
            {
                StringBuilder sb = new StringBuilder();
                var result = GetWordHelper(trieNode, words[i], 0, sb);
                prefixMapping.Add(result, words[i]);

            }
            return prefixMapping;
        }


        public static string GetWordHelper(TrieNode trieNode, string word,int index,StringBuilder sb)
        {
            if(trieNode.Count==1 || trieNode.FindChildNode('$')!=null)
            {
                return sb.ToString();
            }
            char c = word[index];
            var node = trieNode.FindChildNode(c);
            if(node==null)
            {
                return null;
            }

            sb.Append(c);

            return GetWordHelper(node, word, index + 1, sb);
        }

    }
}
