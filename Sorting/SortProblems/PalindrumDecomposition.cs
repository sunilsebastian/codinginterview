using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortProblems
{
    public class PalindrumDecomposition
    {
        public  static void PalPartitions(String input)
        {
            int n = input.Length;
            List<string> palindrums = new List<string>();

          
            List<string> current = new List<string>();

            PalindrumPartitonsUtil(palindrums, current, 0, n, input);

        }

    
        private static void PalindrumPartitonsUtil(List<string> palindrums,
                List<string> current, int trackPointer, int n, String input)
        {
            if (trackPointer == n)
            {
                palindrums.Add(string.Join("|", current));
                return;
            }

            
            for (int i = trackPointer; i < n; i++)
            {
                if (isPalindrome(input, trackPointer, i))
                {
                    current.Add(input.Substring(trackPointer, (i-trackPointer) + 1));
                    PalindrumPartitonsUtil(palindrums, current, i + 1, n, input);
                    current.RemoveAt(current.Count - 1);
                }
            }
        }

        private static bool isPalindrome(string input,int start, int end)
        {
            while (start < end)
            {
                if (input[start++] != input[end--])
                    return false;
            }
            return true;
        }
    }
}
