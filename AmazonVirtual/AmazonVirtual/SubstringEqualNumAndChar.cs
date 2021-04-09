using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonVirtual
{
    public class SubstringEqualNumAndChar
    {

        //https://leetcode.com/problems/contiguous-array/
        //SubArraySumUptoZero here cumilative sum
        //largest subarray with equal number of zero and one

        //abcd12

        //ans: cd12   ==> so count is 4
        public static int equalCharAndNumber(string s)
        {
            int sum_so_far = 0;
            string result = string.Empty;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            dict.Add(0, -1);
            int candidate = Int32.MinValue;
            for(int i=0;i<s.Length;i++)
            {
                if ('a' <= s[i] && s[i] <= 'z')
                    sum_so_far += 1;
                else
                    sum_so_far -= 1;
                if (!dict.ContainsKey(sum_so_far))
                    dict[sum_so_far] = i;
                else
                {
                    candidate = Math.Max(candidate, i - dict[sum_so_far]);

                    result = s.Substring(dict[sum_so_far] + 1, i - dict[sum_so_far]);
                }
            }
            return candidate;
        }

       
    }
}
