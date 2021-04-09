 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class IsoMorphic
    {
        public bool isIsomorphic(String s, String t)
        {
            if (s == null || t == null)
                return false;

            if (s.Length != t.Length)
                return false;

            Dictionary<char, char> map = new Dictionary<char, char>();


            for (int i = 0; i < s.Length; i++)
            {
                char c1 = s[i];
                char c2 = t[i];

                if (map.ContainsKey(c1))
                {
                    if (map[c1] != c2)// if not consistant with previous ones
                        return false;
                }
                else
                {
                    if (map.ContainsValue(c2)) //if c2 is already being mapped. Time complexity O(n) here
                        return false;
                    map.Add(c1, c2);
                }
            }

            return true;
        }

        public bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length) { return false; }

            int[] sMap = new int[128];
            int[] tMap = new int[128];

            for (int i = 0; i < s.Length; i++)
            {
                if (sMap[s[i]] == 0 && tMap[t[i]] == 0)
                {
                    sMap[s[i]] = t[i];
                    tMap[t[i]] = s[i];
                }
                else if (sMap[s[i]] != t[i] || tMap[t[i]] != s[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
