using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    public class TrieNode
    {
        public char Value { get; set; }
        public Dictionary<char, TrieNode> Children { get; set; }
        public int Depth { get; set; }

        public TrieNode(char value, int depth)
        {
            Value = value;
            Children = new Dictionary<char,TrieNode>();
            Depth = depth;
        }

        public TrieNode FindChildNode(char c)
        {
            Children.TryGetValue(c, out TrieNode value);
            return value;
        }

        public void DeleteChildNode(char c)
        {
            Children.Remove(c);
        }


    }
}
