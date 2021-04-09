using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonVirtual
{
    public class AllDistinctSubstringSizeK
    {
        //sliding window

       //Time O(n) 
       //Space O(n-k+1)
        public static List<String> substrings(String s, int k)
        {
            if (string.IsNullOrWhiteSpace(s) || s.Length == 0)
            {
                return null;
            }
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
                    if(!result.Contains(windowString))
                        result.Add(windowString);

                }

                right++;
            }

            return result;
         
        }

    }
}
