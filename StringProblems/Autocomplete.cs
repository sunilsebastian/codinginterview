using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    public class Autocomplete
    {
        public static List<string> GetAutoCompleteText(TrieNode root,string inputText)
        {
            List<string> words = new List<string>();
            StringBuilder sb = new StringBuilder();
            int index = 0;

            TrieNode current = root;

            while(index< inputText.Length && current.FindChildNode(inputText[index])!=null)
            {
                sb.Append(inputText[index]);
                current = current.FindChildNode(inputText[index]);
                index++;
            }

            GetAutoCompleteTextHelper(current, sb,words);
    
            return words;

        }

        public static void  GetAutoCompleteTextHelper(TrieNode root, StringBuilder sb, List<string> words)
        {
            if(root.Value=='$')
            {
                words.Add(sb.ToString());
                return;

            }
            foreach(var node in root.Children)
            {
                if(node.Key!='$')
                {
                    sb.Append(node.Key);
                    GetAutoCompleteTextHelper(node.Value, sb, words);
                    sb.Remove(sb.Length-1,1);

                }
                else
                {
                    GetAutoCompleteTextHelper(node.Value, sb, words);
                }

            }
        }

    }
}
