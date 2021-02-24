using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Example:
//Input:
//logData:

//345366 89921 45
//029323 38239 23
//38239 345366 15
//029323 38239 77
//345366 38239 23
//029323 345366 13
//38239 38239 23
//...
//threshold: 3

//Output: [029323, 345366, 38239]
//Explanation:
//Given the following counts of userids, there are only 3 userids that meet or exceed the threshold of 3.

//345366: 4 times , 38239: 5 times, 029323: 3 times, 89921: 1 time
namespace AmazonProblems
{
    public class TransactionLogs
    {
        public static List<String> getFraudIds(List<String> logData, int threshold)
        {
            List<string> result = new List<string>();
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach(var log in logData)
            {
                string[] items=log.Split(' ');
                string u1 = items[0]; string u2 = items[1];

                if(u1.Equals(u2))
                {
                    if (!dict.ContainsKey(u1))
                        dict.Add(u1, 1);
                    else
                        dict[u1]++;

                }
                else
                {
                    if (!dict.ContainsKey(u1))
                        dict.Add(u1, 1);
                    else
                        dict[u1]++;

                    if (!dict.ContainsKey(u2))
                        dict.Add(u2, 1);
                    else
                        dict[u2]++;
                }
              
               
            }

            foreach(var item in dict.Where(_=>_.Value>= threshold))
            {
                result.Add(item.Key);
            }
            result.Sort();
          
            return result;
        }

    }
}
