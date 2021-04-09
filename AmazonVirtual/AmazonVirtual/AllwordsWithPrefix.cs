using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonVirtual
{

//    Implement operations for an AutoComplete feature.

//InsertWords(words) - Given a stream of words, store the words
//CheckPrefix(prefix) - Returns if the prefix exists
//SearchPrefix(prefix) Given a prefix string, return words starting with the prefix string.
//Eg: Insert Words { car, cart, carpool, bus, apple, cargo }
//    SearchPrefix(car) -> car, cart, carpool, cargo
//   Follow up questions – SearchPrefix() return in sorted order/ top k results
    public class AllwordsWithPrefix
    {
        Trie trie = null;
        public  void InsertWords(List<string> words)
        {
            trie = new Trie();
            foreach (var word in words)
            {
                trie.Insert(trie.root, word);
            }

        }

      public List<string>  SearchStringsWithPrefix(string prefix)
      {
            List<string> result = new List<string>();
            var node= trie.CheckPrefix(trie.root, prefix);
            if (node == null) return result;

            trie.SearchPrefix(node, prefix, result,prefix);

            return result;


      }

    }

    public class TrieNode
    {
        public char Val { get; set; }
        public int Depth { get; set; }

        public int Count { get; set; }
        public bool IsLeaf { get; set; }

        public Dictionary<char, TrieNode> children = null;
        public TrieNode(char val, int depth)
        {
            Val = val;
            Depth = depth;
            children = new Dictionary<char, TrieNode>();

        }
    }

    public class Trie
    {
        public TrieNode root { get; set; }
        public Trie()
        {
            root = new TrieNode('^', 0);
        }

        public void Insert(TrieNode root,string s)
        {
            if(string.IsNullOrWhiteSpace(s))
            {
                root.IsLeaf = true;
                return;
            }

            if (!root.children.TryGetValue(s[0], out TrieNode n))
            {
                n = new TrieNode(s[0], root.Depth + 1);
                root.children.Add(s[0], n);
            }
            n.Count++;

            Insert(n, s.Substring(1));
        }

        public   void  SearchPrefix(TrieNode root,string s,List<string> result,string prefix)
        {
            if(root.IsLeaf==true)
            {
                result.Add(s);
                if(!s.Equals(prefix)  && root.children.Count==0)
                   return;
            }

            foreach( var childNode  in root.children)
            {
                SearchPrefix(childNode.Value, s + childNode.Key, result,prefix);
            }
        }


        public   TrieNode CheckPrefix(TrieNode root, string s)
        {

            if (string.IsNullOrWhiteSpace(s))
            {
                return root;
            }

            if (!root.children.TryGetValue(s[0], out TrieNode n))
            {
                return null;
            }
          

           return CheckPrefix(n, s.Substring(1));
        }

        public void Insert1(TrieNode root, string s,int trackingIndex)
        {
            if (s.Length==trackingIndex)
            {
                root.IsLeaf = true;
                return;
            }

            // s[trackingIndex], or   s.Substring(trackingIndex, 1);
            if (!root.children.TryGetValue(s[trackingIndex], out TrieNode n))
            {
                n = new TrieNode(s[0], root.Depth + 1);
                root.children.Add(s[0], n);
            }
            n.Count++;

            Insert1(n,s,trackingIndex+1);
        }
    }
}
