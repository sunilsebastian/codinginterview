using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortProblems
{
    //Divide and Conquor
    public class CountNumbersSmallerThanSelf
    {
        private static int[] res;

        class Pair
        {
            public int val;
            public int idx;

            public Pair(int val, int idx)
            {
                this.val = val;
                this.idx = idx;
            }
        }

        public IList<int> CountSmaller(int[] nums)
        {
            res = new int[nums.Length];
            Pair[] pair = new Pair[nums.Length];

            for (int i = 0; i < pair.Length; i++)
            {
                pair[i] = new Pair(nums[i], i);
            }

            MergeSort(pair, 0, nums.Length - 1);
            return res.ToList();
        }

        private static void MergeSort(Pair[] nums, int left, int right)
        {
            if (left >= right)
                return;
            int mid = left + (right - left) / 2;

            MergeSort(nums, left, mid);
            MergeSort(nums, mid + 1, right);

            int count = 0;

            int leftStart = left;
            int rightStart = mid + 1;


            while (leftStart <= mid)
            {
                if (rightStart <= right && nums[leftStart].val > nums[rightStart].val)
                {
                    count++;
                    rightStart++;
                }
                else
                {
                    res[nums[leftStart].idx] += count;
                    leftStart++;
                }
            }

            // merge

            int rightIndex = mid + 1;
            int leftIndex = left;
            int resultIndex = 0;
            Pair[] temp = new Pair[right - left + 1];
            while ((leftIndex <= mid) && (rightIndex <= right))
            {
                //mid is the first element of the second compartment
                if (nums[leftIndex].val <= nums[rightIndex].val)
                {
                    temp[resultIndex++] = nums[leftIndex++];
                }
                else
                {
                    temp[resultIndex++] = nums[rightIndex++];

                }
            }
            while (leftIndex <= mid)
            {
                temp[resultIndex++] = nums[leftIndex++];
            }
            while (rightIndex <= right)
            {
                temp[resultIndex++] = nums[rightIndex++];
            }

            //placing temp array to input
            int index = 0;
            for (int i = left; i <= right; i++)
            {
                nums[i] = temp[index++];
            }

        }

    }
}
