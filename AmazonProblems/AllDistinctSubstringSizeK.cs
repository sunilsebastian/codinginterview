using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonProblems
{
    public class AllDistinctSubstringSizeK
    {
        //sliding window
        public static List<String> substrings(String s, int k)
        {

            int left = 0;
            int right = 0;
            HashSet<char> window = new HashSet<char>();

            List<string> result = new List<string>();

            while(right<s.Length)
            {
                
                while(window.Count()>=k || window.Contains(s[right]))
                {
                    window.Remove(s[left++]);
                }

                window.Add(s[right]);

                if (window.Count()==k)
                {
                  var windowString = s.Substring(left, right - left + 1);
                    result.Add(windowString);

                }

                right++;
            }

            return result;
            //HashSet<string> hs = new HashSet<string>();

            //for(int i=0;i<=s.Length-k;i++)
            //{
            //    var substring = s.Substring(i, k);
            //    if (IsUnique(substring))
            //            hs.Add(s.Substring(i, k));
            //}

            //return hs.ToList();

        }

        public static  bool IsUnique(string s)
        {
            int[] arr = new int[128];

            char[] chars = s.ToCharArray();

            foreach( var c in chars)
            {
                if (arr[c] > 0)
                    return false;
                arr[c]++;

            }

            return true;


        }
    }
}
