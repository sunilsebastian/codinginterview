using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Trie.InsertRange(new string[] { "car", "cars", "cap", "clap", "bot"});
            Autocomplete.GetAutoCompleteText(Trie.root, "clap");
            Trie.root = null;

            Trie.InsertRange(new string[] { "apple", "ape", "apple","ape","mango","ape" });
            MinimumOccuringWord.GetMinimumOccuringWord(Trie.root);
            Trie.root = null;

            Trie.InsertRange(new string[] { "apple", "ape", "april" });
            LongestCommonPrefix.GetLongestCommonPrefix(Trie.root, new string[] { "apple", "ape", "april" });
            LexicoGraphicSort.ExcecuteLexoGraphicSort(Trie.root);
            Trie.root = null;

            var result = SmallestNumberRemoveKDigits.RemoveKdigits("12345", 2);

            Trie.InsertRange(new string[] { "tree", "trie", "assoc", "all", "also" });
            bool found = Trie.Search("all");

            //Trie.InsertRange(new string[] { "geeksgeeks", "geeksquiz", "geeksforgeeks" });
            //var shortestPrefix = ShortestUniquePrefixToRepWord.GetShortestUniquePrefixToRepWord(Trie.root, new string[] { "geeksgeeks", "geeksquiz", "geeksforgeeks" });
            var shortestPrefix = ShortestUniquePrefixToRepWord.GetShortestUniquePrefixToRepWord(Trie.root, new string[] { "tree", "trie", "assoc", "all", "also" });

            Trie.Delete("tree");
            
            RabinKarpSubstringSearch.SearchString("HelloWorldThisIsaTest", "Tes");

        }
}
}
