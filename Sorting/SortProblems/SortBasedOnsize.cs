using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortProblems
{
    public static class SortBasedOnsize
    {

        public static string Sort(string input)
        {
            string[] arr = input.Split(' ');
            Dictionary<int, List<string>> dict = new Dictionary<int, List<string>>();

            foreach(var item in arr)
            {
                if(!dict.ContainsKey(item.Length))
                {
                    dict.Add(item.Length, new List<string>());
                }
                dict[item.Length].Add(item);
            }
            StringBuilder result = new StringBuilder();
            foreach(var item in dict.OrderBy(_=>_.Key))
            {
               result.Append(string.Join(" ",item.Value)).Append(" ");

            }

            return result.ToString().TrimEnd(' '); ;
        }
        public static string Sort1(string input)
        {
            string[] arr = input.Split(' ');
            int[] countArr = new int[arr.Length];
            for( int i=0;i <arr.Length;i++)
            {
                countArr[i] = arr[i].Length;

            }

            for (int i = 0; i < arr.Length; i++)
            {
                int min = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (countArr[j] < countArr[min])
                    {
                        min = j;

                    }
                }

                var temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;

                var t = countArr[i];
                countArr[i] = countArr[min];
                countArr[min] = t;

            }
            return string.Join(" ", arr);

        }
    }
}
