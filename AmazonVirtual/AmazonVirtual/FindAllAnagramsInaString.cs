using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonVirtual
{
    public class FindAllAnagramsInaString
    {

        public static List<string> FindAllAnagramsInString(string s)
        {
            List<string> result = new List<string>();
            var substrings = FindAllSubstrings(s);
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            foreach(var str in substrings)
            {
                char[] c = str.ToArray();
                Array.Sort(c);
                string hash = new String(c);
                if (!dict.ContainsKey(hash))
                {
                    dict.Add(hash, new List<string>());
                }
                dict[hash].Add(str);
            }

            foreach(var item in dict.Where(_=>_.Value.Count>1))
            {
                result.AddRange(item.Value);
            }

            return result;
        }

        private static List<string> FindAllSubstrings(string s)
        {
            List<string> substrings = new List<string>();
          
            //loop for substring length
            for (int length = 2; length < s.Length; length++)
            {
                //All substrings of length L;
                for (int start = 0; start <= s.Length - length; start++)
                {
                    var substring = s.Substring(start, length);
                    substrings.Add(substring);
                }

            }
            return substrings;
        }


    }
}
