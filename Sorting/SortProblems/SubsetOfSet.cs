using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortProblems
{
    public class SubsetOfSet
    {
        static List<string> result = new List<string>();

        //Using binary string
        public static string[] Generate_all_subsets1(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return new string[1];
            }
            int len = s.Length;
            List<string> result = new List<string>();
            string str = string.Empty;
            for (int i = 0; i < (1 << len); i++)
            {
                for (int j = 0; j < len; j++)
                {

                    if ((i & (1 << j)) > 0)
                    {
                        str += s[j];
                    }

                }
                result.Add(str);
                str = string.Empty;
            }
            return result.ToArray();
        }

      //using inclusion/exclusion
       public  static string[] GeneratSubset(string s)
        {
            if (s == null || s.Length == 0)
            {
                result.Add(string.Empty);
                return result.ToArray();
            }
            char[] temp = new char[s.Length];
            GeneratSubsetHelper(s.ToCharArray(), 0, temp, 0);
            return result.ToArray();
        }

        static void GeneratSubsetHelper(char[] s, int i, char[] subset, int j)
        {
            if (i == s.Length)
            {
                AddToResult(subset, j);
                return;
            }
            GeneratSubsetHelper(s, i + 1, subset, j);
            subset[j] = s[i];
            GeneratSubsetHelper(s, i + 1, subset, j + 1);
        }

        static void AddToResult(char[] subset, int j)
        {
            char[] t = new char[j];
            for (int i = 0; i < j; i++)
            {
                t[i] = subset[i];
            }

            if (t.Length > 0) result.Add(new string(t));
            else result.Add(string.Empty);
        }
    }


}
