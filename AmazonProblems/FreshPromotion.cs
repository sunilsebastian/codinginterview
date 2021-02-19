using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonProblems
{
    public class FreshPromotion
    {
        //Run time: O(n*m). Where "n" is the length of shopping cart and m is the largest group of the codeList.

        //Input: codeList = [[apple, apple], [banana, anything, banana]] shoppingCart = [orange, apple, apple, banana, orange, banana]
        //        Output: 1
        //Explanation:
        //codeList contains two groups - [apple, apple] and[banana, anything, banana].
        //The second group contains 'anything' so any fruit can be ordered in place
        //of 'anything' in the shoppingCart.The customer is a winner as the customer has
        //added fruits in the order of fruits in the groups and the order
        //of groups in the codeList is also maintained in the shoppingCart.

        public static  bool isWinner(List<List<string>> proList, List<String> order)
        {
            int orderIndex = 0, groupIndex = 0;

            while (orderIndex < order.Count)
            {

                List<String> group = proList[groupIndex];

                int currentGroupIndex = 0;

                while (currentGroupIndex < group.Count && orderIndex < order.Count)
                {
                    if (group[currentGroupIndex].Equals(order[orderIndex]) || group[currentGroupIndex].Equals("anything"))
                    {
                        currentGroupIndex++;
                    }
                    else
                    {
                        //if there is no consecutive match reset to start of the currentgroup.
                        currentGroupIndex = 0;
                    }
                    orderIndex++;
                }

                if (currentGroupIndex != group.Count)
                    return false;

                groupIndex++;
            }

            //if we did not match both groups in codelist
            if (groupIndex < proList.Count())
                return false;

            return true;
        }

        public static bool isWinner1(List<List<String>> proList, List<String> order)
        {
            int ordInd = 0, proLsInd = 0;

            while (ordInd < order.Count())
            {

                List<String> pListItem = proList[proLsInd];
                int proLsItemind = 0;
                while (proLsItemind < pListItem.Count && ordInd < order.Count)
                {
                    if (pListItem[proLsItemind].Equals(order[ordInd]) || pListItem[proLsItemind].Equals("anything"))
                    {
                        proLsItemind++;
                    }
                    else
                    {
                        proLsItemind = 0;
                    }
                    ordInd++;
                }
                if (proLsItemind != pListItem.Count)
                    return false;

                proLsInd++;
            }

            if (proLsInd < proList.Count)
                return false;

            return true;
        }
    }
}
