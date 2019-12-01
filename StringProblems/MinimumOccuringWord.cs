using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    public class MinimumOccuringWord
    {
        public static string GetMinimumOccuringWord(TrieNode root)
        {
            StringBuilder sb = new StringBuilder();
            String word = string.Empty;
            int count = Int32.MaxValue;

            GetMinimumOccuringWordHelper(root, ref word,ref count, sb);
            return word;

        }

        public static void  GetMinimumOccuringWordHelper(TrieNode root,ref String word,ref int count ,StringBuilder sb)
        {

            if(root.FindChildNode('$')!=null)
            {
               if(root.Count<count)
                {
                    count = root.Count;
                    word = sb.ToString();
                }
                return;
            }
            foreach(var node in root.Children)
            {
                sb.Append(node.Key);
                GetMinimumOccuringWordHelper(node.Value,ref  word,ref count,sb);
                sb.Remove(sb.Length - 1, 1);
            }
        }
    }
}
