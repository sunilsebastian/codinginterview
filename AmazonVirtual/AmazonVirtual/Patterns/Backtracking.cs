using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonVirtual
{
    public  class Backtracking
    {
        //DecodeWays
        //CanBreakWord
             //trackPointer LOOP memoization dictionary based on TrackPointer
        
        
        //LetterCombinationOfPhoneNumbers LOOp
        //here trackindex for looping through  given number string"12"
        
        
        //Backtracking pruning: stop the DFS when the required condition is not met
        
        //Palindrome partitioning
                //TrackPointer LOOP List add palindrome check. bscktrsck the list

        //Combination Sum
            //trackpointer is just i not i+1

        //Include exclude
            //Subset
            //TargetSum



        public static IList<IList<int>> GetCombinationSum(List<int> candidates, int target)
        {
            var result = new List<IList<int>>();

            List<int> pairs = new List<int>();

            GetCombinationSumHelper(candidates, target, pairs, result,0);
            return result;
        }

        //here index is used to avoid duplicates
        public static void GetCombinationSumHelper(List<int> candidates, int target, List<int> pairs, List<IList<int>> result,int index)
        {
            if (target <= 0)
            {
                if (target == 0)
                    result.Add(pairs.ToList());
                return;
            }

           for(int i=index;i<candidates.Count;i++)
            {
                pairs.Add(candidates[i]);
                GetCombinationSumHelper(candidates, target - candidates[i], pairs, result,i);
                pairs.RemoveAt(pairs.Count - 1);

            }


        }



        private static  Dictionary<char, string> dict = new Dictionary<char, string>();
        private static HashSet<string> hs = new HashSet<string>();

        public static  bool WordPatternMatch(string pattern, string s)
        {
            if (pattern.Length == 0)
            {
                if (s.Length == 0)
                    return true;
                else
                    return false;
            }
            
            // pattern has already mapping in dict
            if (dict.ContainsKey(pattern[0]))
            {
                // what was the [matched string]
                //Take the staring from string with the size of [matched string]
                var val = dict[pattern[0]];
                if (s.Length < val.Length || s.Substring(0, val.Length) != val) return false;

                if (WordPatternMatch(pattern.Substring(1), s.Substring(val.Length))) return true;
            }
            else
            {
                for (int i = 1; i <= s.Length; i++)
                { 
                    //avoid duplicates
                    if (hs.Contains(s.Substring(0, i))) continue;
                    dict[pattern[0]] = s.Substring(0, i);
                    hs.Add(s.Substring(0, i));
                    //pattern length reduces 1 by one
                    
                    //for string the window size increases there is no matching
                    if (WordPatternMatch(pattern.Substring(1), s.Substring(i))) return true;

                    //backtrack
                    hs.Remove(s.Substring(0, i));
                    dict.Remove(pattern[0]);
                }
            }
            return false;
        }
    }
}
