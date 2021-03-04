using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Input
//The input to the function/method consists of four arguments:

//numOfBuildings: an integer representing the number of buildings;

//buildingOpenTime: a list of integers representing the times at which all 4 docks of the ith building become available;

//offloadTime: a list of integers representing the offload time of each intake delivery.

//Output
//Return an integer representing the earliest time at which all the intake deliveries can be offloaded.

//Note
//The length of offloadTime is 4* numOfBuildings.

//Constraints
//1 <= numOfBuildings <= 10^5
//1 <= buildingOpenTime[i] < 10^6
//1 <= offloadTime[j] <= 10^6
//0 <= i<numOfBuildings
//0 <= j< 4 * numOfBuildings
//Examples
//Example 1:
//Input:
//numOfBuildings = 2

//buildingOpenTime = [8, 10]

//offloadTime = [2, 2, 3, 1, 8, 7, 4, 5]

//Output: 16
namespace AmazonProblems
{
    public class EarliestTimeToCompleteDeliveries
    {
     
        //algomonster
        // Time complexity (nlogn)
        //Space :O(1)
        public static int EarliestTime(int numOfBuildings, List<int> buildingOpenTime, List<int> offloadTime)
        {
           
            offloadTime.Sort((a, b) => b - a);
            buildingOpenTime.Sort();
           
            int index = 0;
            int ans = 0;
            foreach (int openTime in buildingOpenTime)
            {
                for (int i = 0; i < 4; i++)
                {
                    ans = Math.Max(ans, openTime + offloadTime[index]);
                    index++;
                }
            }
            return ans;
        }



    }
}
