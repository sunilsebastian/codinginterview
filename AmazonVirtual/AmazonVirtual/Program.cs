using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonVirtual
{
    class Program
    {
        static void Main(string[] args)
        {

            SnakeGame s = new SnakeGame(2, 2, new int[1][] { new int[] { 1, 0 } });
            string[] arr = new string[5] { "R", "D", "L", "U", "R" };
            for (int i = 0; i < arr.Length; i++)
                Console.Write(s.Move(arr[i]) + " ");

            var anagrams=   FindAllAnagramsInaString.FindAllAnagramsInString("abcbca");

            TaskSchedulingIdleTime.leastInterval(new char[] { 'A', 'A', 'A', 'B', 'B', 'B' }, 2);

            List<List<char>> letters = new List<List<char>> {new List<char> { 'A', 'B' } ,new List<char>{ 'B', 'A' },
            new List<char>{ 'B', 'X' },  new List<char>{'Y', 'C'}};
            var canFormWord=  LetterCombinationOfPhoneNumber.CheckWordCanBeMade(letters, "ABYC");

         
            AllwordsWithPrefix allprefix = new AllwordsWithPrefix();

            allprefix.InsertWords(new List<string> { "car", "cart", "carpool", "bus", "apple", "ape","apex","cargo" });
            var WordsWithPrefix= allprefix.SearchStringsWithPrefix("ap");

            PrintBSTInRange.GetBstKeysInRange();

            SubstringEqualNumAndChar.equalCharAndNumber("abcd12xyzq5789");

            //-----PATTERNS--------------
            BinarySearch.FindSqrRootOfnumber(9);
            BinarySearch.FindSqrRootOfnumber(0,8,8);
            BinarySearch.FirstElemtentNotSmallerThanTarget(new int[] { 1, 3, 5, 7,9, 9, 10, 11, 12 }, 0, 8, 8);
            // BinarySearch.FindMinSortedRotated(new int[] { 30, 40, 50, 20,20,20, 20 });
            BinarySearch.FindMinSortedRotated(new int[] { 1,2,3,4});

            var pivot=BinarySearch.FindPivot(new int[] { 3, 1, 3 }, 0, 2);


            Backtracking.GetCombinationSum(new List<int> { 2, 3, 6, 7 }, 7);

            Backtracking.WordPatternMatch( "abab", "redblueredblue");
            // Backtracking.WordPatternMatch("aaaa", "asdasdasdasd");
            // Backtracking.WordPatternMatch("aabb", "xyzabcxzyabc");

            int[][] mat = new int[5][]
                { new int[] { 0, 0,0,0,0 }, 
                    new int[] { 0,0,0,0, 0 },
                    new int[] { 0, 0,0,0,0 }, 
                    new int[] { 0, 0,0,0,0 },
                    new int[] { 0, 0,0,0,0 }};
            int[][] start = new int[1][] { new int[] { 0, 0 } };
            int[][] end = new int[1][] { new int[] { 1, 2 } };
            BFS.GetShortestPath(mat, start, end);


            Console.ReadLine();
        }
    }
}
