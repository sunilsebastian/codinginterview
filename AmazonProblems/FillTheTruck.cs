using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonProblems
{
    public class FillTheTruck
    {
        //Time Complexity :O(nlogn), where n is the number of elements in array boxes.
        //space complexity O(n) is the number of boxes
        public static int fillTheTruck(int num, List<int> boxes, int unitSize, List<int> unitsPerBox, int truckSize)
        {

            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < num; i++)
            {
                dict.Add(boxes[i], unitsPerBox[i]);
            }

            int resultUnits = 0;

            foreach (var item in dict.OrderByDescending(_ => _.Value))
            {
                //as its sorted  take all the boxes 

                if (item.Key <= truckSize)
                {
                    truckSize = truckSize - item.Key;

                    resultUnits += item.Key * item.Value;
                }
                else
                {
                    resultUnits += truckSize * item.Value;
                }
            }

            return resultUnits;

        }
    }
}
