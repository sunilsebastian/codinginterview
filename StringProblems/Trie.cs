using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    public class Trie
    {
        private static TrieNode root;
        private static readonly char endOfWord = '$';
        static Trie()
        {
            root = new TrieNode('^', 0);
        }
        public static void InsertRange(string[] strings)
        {
            for(int i=0;i<strings.Length;i++)
            {
                Insert(strings[i]);
            }
        }
        public static void Insert(string s)
        {
            TrieNode current = root;
            foreach( char c in s)
            {
               TrieNode node = current.FindChildNode(c);
               if(node==null)
                {
                    node = new TrieNode(c, current.Depth+1);
                    current.Children.Add(c,node);
                }
                current = node;
            }
            current.Children.Add(endOfWord,new TrieNode(endOfWord, current.Depth + 1));
        }

        public void Delete(string s)
        {
            DeleteHelper(s, root,0);
        }

        public bool DeleteHelper(string s, TrieNode current,int index)
        {
            if(current.Depth == s.Length)
            {
                if(current.FindChildNode(endOfWord)==null)
                {
                    return false;
                }

                current.DeleteChildNode(endOfWord);

                return (current.Children.Count == 0) ? true : false;
            }

            char c = s[index];
            TrieNode node = current.FindChildNode(c);
            
            var res = DeleteHelper(s, current, index + 1);

            if(res==true)
            {
                current.DeleteChildNode(c);
                return (current.Children.Count == 0) ? true : false;

            }

            return false;
        }

        public static bool Search(string s)
        {
            TrieNode current = root;
            foreach(char c in s)
            {
                TrieNode node = current.FindChildNode(c);
                if ( node == null)
                    return false;

                current = node;
            }
            return (current.FindChildNode(endOfWord) != null);
        }
    }
}
