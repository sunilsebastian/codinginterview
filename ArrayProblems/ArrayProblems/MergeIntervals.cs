using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class MergeIntervals
    {

        public static void Merge(int[,] intervals)
        {

            var  list = new List<Tuple<int, int>>
            {
                new Tuple<int,int>(intervals[0,0],intervals[0,1]),
                new Tuple<int,int>(intervals[1,0],intervals[1,1]),
                new Tuple<int,int>(intervals[2,0],intervals[2,1]),
                new Tuple<int,int>(intervals[3,0],intervals[3,1]),
            };

            var result = new List<Tuple<int, int>>();
            list = list.OrderBy(_ => _.Item1).ToList();

            var temp = list[0];
            for(int i=1;i<list.Count;i++)
            {
                var current = list[i];

                if(temp.Item2>=current.Item1)
                {
                    temp=new Tuple<int, int>(temp.Item1, Math.Max(temp.Item2, current.Item2));
                }
                else
                {
                    result.Add(temp);
                    temp = current;
                }
            }

            result.Add(temp);


            foreach (var tup in result)
            {
                Console.Write($"({tup.Item1},{tup.Item2}) ");
            }
        }

        public static void Insert(int[,] intervals, int[,] newInterval)
        {
            var list = new List<Tuple<int, int>>
            {
                new Tuple<int,int>(intervals[0,0],intervals[0,1]),
                new Tuple<int,int>(intervals[1,0],intervals[1,1]),
                new Tuple<int,int>(intervals[2,0],intervals[2,1]),
                new Tuple<int,int>(intervals[3,0],intervals[3,1]),
                new Tuple<int,int>(intervals[4,0],intervals[4,1]),
            };


            var newSet=   new Tuple<int, int>(newInterval[0, 0], newInterval[0, 1]);

            var result = new List<Tuple<int, int>>();
            list = list.OrderBy(_ => _.Item1).ToList();

            
            foreach (var inter in list)
            {
                if ((inter.Item2< newSet.Item1)  || (inter.Item1 > newSet.Item2))
                {
                    result.Add(inter);
                }
                //else if (inter.Item1 > newSet.Item2)
                //{
                //    result.Add(newSet);
                
                //}
                else if (inter.Item2 >= newSet.Item1 || inter.Item1 <= newSet.Item2)
                {
                    newSet = new Tuple<int, int>(Math.Min(inter.Item1,newSet.Item1), Math.Max(inter.Item2, newSet.Item2));
                }
            }

            result.Add(newSet);


            foreach (var tup in result)
            {
                Console.Write($"({tup.Item1},{tup.Item2}) ");
            }
        }

        }
}
