using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonProblems
{

    // O(i * j * k * l) to O(i * j * k * log l)  where n, m , i, j are the lengths of the respective lists.
    public class ShoppingOption
    {
        public static long soltuion4(List<int> priceOfJeans, List<int> priceOfShoes, List<int> priceOfSkirts,
                                       List<int> priceOfTops, int dollars)
        {
            long res = 0;
            List<long> list1 = new List<long>();
            List<long> list2 = new List<long>();
            foreach (int jean in  priceOfJeans)
            {
                foreach (int shoe in priceOfShoes)
                {
                    if (jean + shoe < dollars)
                    {
                        list1.Add((long)(jean + shoe));
                    }
                }
            }

            foreach (int skirt in  priceOfSkirts)
            {
                foreach (int top in  priceOfTops)
                {
                    if (skirt + top < dollars)
                    {
                        list2.Add((long)(skirt + top));
                    }
                }
            }

            list1.Sort();
            list2.Sort();
            foreach (long count1 in list1)
            {
                res += CountSmaller(dollars - count1, list2);
            }


            return res;
        }


        public static int CountSmaller(long k, List<long> list)
        { // find how many numbers equal or smaller than k in sorted list
            int left = 0, right = list.Count - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (list[mid] == k)
                {
                    //if matches keep looking right for duplicates
                    while (mid<=right && list[mid] == k)
                    {
                        mid++;
                    }
                    left = mid;
                    //mid will be equal to number of elements less thatn or equal k
                    break;
                }
                if (list[mid] < k)
                {
                    left = mid + 1;
                }
                else if (list[mid] > k)
                {
                    right = mid - 1;
                }
            }
            //left will allways conatin number of elements less than k
            return left;
        }


    }
}

