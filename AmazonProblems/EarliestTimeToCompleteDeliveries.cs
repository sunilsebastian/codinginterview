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

        public  static int EarliestTime(int numOfBuildings, int[] buildingOpenTime, int[] offloadTime)
        {
            PQ<int> loads = new PQ<int>(false);
            PQ<int> docks = new PQ<int>(true);

            foreach(var l in offloadTime)
            {
                loads.Enqueue(l);
            }

            foreach (var d  in buildingOpenTime)
            {
                docks.Enqueue(d);
            }


            int max = 0;
            while (docks.Count()!=0)
            {
                //            Starting time of each building
                int poll = docks.Dequeue();
                for (int i = 0; i < 4 && loads.Count()!=0; i++)
                {

                    //Unload the 4 loads, and get the max time to finish all the loads to the building.
                    max = Math.Max(max, poll + loads.Dequeue());
                }
            }
            return max;
        }
    }
}
