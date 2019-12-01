using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    public class LexicoGraphicSort
    {
        public static void ExcecuteLexoGraphicSort(TrieNode root)
        {
            ExcecuteLexoGraphicSortHelper(root, new StringBuilder());
        }

        private  static void ExcecuteLexoGraphicSortHelper(TrieNode root,StringBuilder sb)
        {
            if(root.FindChildNode('$')!=null)
            {
                Console.WriteLine(sb.ToString());
                return;
            }

            for(char c='a';c<='z';c++)
            {
                var node = root.FindChildNode(c);
                if(node!=null)
                {
                    sb.Append(node.Value);
                    ExcecuteLexoGraphicSortHelper(node, sb);
                    sb.Remove(sb.Length - 1, 1);
                }
            }
        }
    }
}
