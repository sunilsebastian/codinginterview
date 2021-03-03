using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonProblems
{
    public class ChooseAFlask
    {

        private static int flaskLoss(List<int> requirements, List<int> markings)
        {
            int loss = 0;
            IEnumerator<int> mark = markings.GetEnumerator();
            mark.MoveNext();
            foreach (var  r in requirements)
            {
               
                while (mark.Current < r)
                {
                    if (!mark.MoveNext())
                        return -1;
                  
                }
                loss += mark.Current - r;
            }
            return loss;
        }
        public static int chooseAFlask()
        {

           // int numOrders = 4;

           // List<int> requirements = new List<int>() { 4, 6, 6, 7 };
            List<int> requirements = new List<int>() { 5,9,3 };

            //  int flaskTypes = 3;

            // int totalMarks = 9;

            List<List<int>> markings = new List<List<int>> { new List<int> { 0, 1 }, new List<int> { 0, 4 }, new List<int> { 0, 7 }, new List<int> { 1, 2 } };
            //List<List<int>> markings = new List<List<int>> { new List<int> { 0, 3 }, new List<int> { 0, 5 }, new List<int> { 0, 7 }, new List<int> { 1,6 }
            //, new List<int> { 1,8}, new List<int> {1,9 }, new List<int> { 2, 3 }, new List<int> {2,5 },new List<int> {2,6 }};

            //int numOrders, List<int> requirements, int flaskTypes, List<List<int>> markings


            Dictionary<int, List<List<int>>> flasks = new Dictionary<int, List<List<int>>>();
            requirements.Sort();
         
            int minLoss = Int32.MaxValue;
            int minFlask = -1;

            foreach (var item in markings)
            {
               if(! flasks.ContainsKey(item[0]))
                {
                    flasks.Add(item[0], new List<List<int>> ());
                }
                flasks[item[0]].Add(item);
            }
          
            foreach (var  e in  flasks)
            {
                int flask = e.Key;
                List<int> marks = e.Value.Select(p => p[1]).ToList();
                int loss = flaskLoss(requirements, marks);
                if (loss < 0 || loss >= minLoss)
                    continue;
                minLoss = loss;
                minFlask = flask;
            }
            return minFlask;
        }

        public static int throttlingGateway(List<int> requestTime)
        {
            int ans = 0;
          
            for (int i = 0; i < requestTime.Count; i++)
            {

                if (i > 2 && requestTime[i] == requestTime[i - 3])
                {
                    ans++;
                }
                else if (i > 19 && (requestTime[i] - requestTime[i - 20]) < 10)
                {
                    ans++;
                }
                else if (i > 59 && (requestTime[i] - requestTime[i - 60]) < 60)
                {
                    ans++;
                }

            }
            return ans;
        }
    }
}
