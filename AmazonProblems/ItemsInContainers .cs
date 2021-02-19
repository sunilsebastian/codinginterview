using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonProblems
{
    public class ItemsInContainers
    {
        public  static int[] NumberOfItems(String str, int[] starts, int[] ends)
        {
            int len = str.Length;
            int[] sTree = new int[4 * len];
            buildSTree(str, 0, len - 1, sTree, 0);
            int[] result = new int[starts.Length], left = new int[len], right = new int[len];
            //        Left array will have the index of close\open located on the left side.
            //        Right array will have the index of close\open located on the right side.
            int closeIdx = Int32.MaxValue;
            for (int i = len - 1; i >= 0; i--)
            {
                if (str[i] == '|') 
                    closeIdx = i;
                right[i] = closeIdx;
            }
            closeIdx = Int32.MaxValue;
            for (int i = 0; i < len; i++)
            {
                if (str[i] == '|') closeIdx = i;
                left[i] = closeIdx;
            }
            for (int i = 0; i < starts.Length; i++)
            {
                int start = starts[i], end = ends[i];
                int startIdx = right[start - 1], endIdx = left[end - 1];
                result[i] = getCount(startIdx, endIdx, str, sTree);
            }
            return result;
        }

        private static void buildSTree(String str, int s, int e, int[] sTree, int i)
        {
            if (s == e)
            {
                sTree[i] = str[s] == '*' ? 1 : 0;
            }
            else
            {
                int m = (s + e) / 2, left = 2 * i + 1, right = 2 * i + 2;
                buildSTree(str, s, m, sTree, left);
                buildSTree(str, m + 1, e, sTree, right);
                sTree[i] = sTree[left] + sTree[right];
            }
        }

        private static int getCount(int startIdx, int endIdx, String str, int[] sTree)
        {
            if (startIdx == Int32.MaxValue || endIdx == Int32.MaxValue || startIdx >= endIdx) return 0;
            int count = 0;
            for (int i = startIdx + 1; i < endIdx; i++)
            {
                count += str[i] == '*' ? 1 : 0;
            }
            return count;
            //        return query(startIdx, endIdx, 0, str.length() - 1, sTree, 0);
        }
    }
}
