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
           //var result= SmallestNumberRemoveKDigits.RemoveKdigits("12345", 2);

            Trie.InsertRange(new string[] { "tree", "trie", "assoc", "all", "also" });
            bool found =  Trie.Search("all");

            RabinKarpSubstringSearch.SearchString("HelloWorldThisIsaTest", "Tes");

        }
}
}
