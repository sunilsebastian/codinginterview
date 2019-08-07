namespace SortProblems
{
    public class MergeKSortedArrays
    {
      

        public int[] MergeArrays(int[,] arr)
        {
            PriorityQueue<DataNode> pq;
            int resIndex = 0;
            if (arr == null) return null;
            int resultSize = arr.GetLength(0) * arr.GetLength(1);
            int[] result = new int[resultSize];

            pq = GetPriorityQueue(arr);

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                pq.Enqueue(arr[i, 0], new DataNode(arr[i, 0], i, 0));
            }

            while (pq.map.Count > 0)
            {
                DataNode dn = pq.Dequeue();
                result[resIndex++] = dn.Num;
                var currentRow = dn.Row;
                var currentCol = dn.Column;
                currentCol++;
                if (currentCol < arr.GetLength(1))
                {
                    pq.Enqueue(arr[currentRow, currentCol], new DataNode(arr[currentRow, currentCol], currentRow, currentCol));
                }
            }
            return result;
        }

        public PriorityQueue<DataNode> GetPriorityQueue(int[,] arr)
        {
            if (arr[0, 0] < arr[0, arr.GetLength(0) - 1])
            {
                return new PriorityQueue<DataNode>(true);
            }
            return new PriorityQueue<DataNode>(false);
        }
    }

    public class DataNode
    {
        public int Num { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }

        public DataNode(int num, int row, int column)
        {
            Num = num;
            Row = row;
            Column = column;
        }
    }
}