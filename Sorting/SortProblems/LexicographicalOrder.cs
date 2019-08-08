using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortProblems
{
    public class LexicographicalOrder
    {
        //public static string[] Solve(string[] arr)
        //{
        //    var dictionary = new SortedDictionary<string, List<string>>(Comparer<string>.Create((x, y) => y.CompareTo(x)));
        //    List<string> result = new List<string>();
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        string[] values = arr[i].Split(' ');

        //        if (!dictionary.ContainsKey(values[0]))
        //        {
        //            dictionary.Add(values[0], new List<string>());
        //        }
        //        dictionary[values[0]].Add(values[1]);
        //    }

        //    foreach (var item in dictionary)
        //    {
        //        var list = item.Value;
        //        var listFirst = (list.Count > 1) ? list.OrderByDescending(x => x).First() : list.First();
        //        result.Add($"{item.Key}:{list.Count},{listFirst}");
        //    }

        //    return result.ToArray();
        // }

        public static string[] Solve(string[] arr)
        {
            var dictionary = new SortedDictionary<string, Tuple<int,string>>(Comparer<string>.Create((x, y) => y.CompareTo(x)));
            List<string> result = new List<string>();
            for (int i = 0; i < arr.Length; i++)
            {
                string[] values = arr[i].Split(' ');

                if (!dictionary.ContainsKey(values[0]))
                {
                    dictionary.Add(values[0],new Tuple<int,string>(1,values[1]));
                }
                else
                {
                    
                    var currentval = dictionary[values[0]];
                    if(values[1].CompareTo(currentval.Item2)>0)
                    {
                        dictionary[values[0]] = new Tuple<int, string>(currentval.Item1 + 1, values[1]);
                    }
                    else
                    {
                        dictionary[values[0]]=new Tuple<int, string>(currentval.Item1 + 1, currentval.Item2);
                    }
                }
              
            }

            foreach (var item in dictionary)
            {
                var list = item.Value;
                //var listFirst = (list.Count > 1) ? list.OrderByDescending(x => x).First() : list.First();
                result.Add($"{item.Key}:{list.Item1},{list.Item2}");
            }

            return result.ToArray();
        }

    }
}
