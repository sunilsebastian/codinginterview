using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class ValidPalindrome
    {
        // ",[, "
        // Input: "A man, a plan, a canal: Panama"
        // Output: true
        public static bool IsPalindrome(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return true;

            int start = 0;
            int end = s.Length - 1;

            while (start < end)
            {
                while (start < end && !char.IsLetterOrDigit(s[start]))
                {
                    start++;
                }

                while (start < end && !char.IsLetterOrDigit(s[end]))
                {
                    end--;
                }

                if (start < end && char.ToUpper(s[start]) != char.ToUpper(s[end]))
                    return false;

                start++;
                end--;
            }
            return true;
        }
    }
}
