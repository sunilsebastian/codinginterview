namespace ArrayProblems
{
    public class MissingPositiveNumber
    {
        public static  int FindFirstMissingPositiveNumber(int[] nums)
        {
            int[] hash = new int[nums.Length];
            foreach (int num in nums)
            {
                if (num > 0 && num <= nums.Length)
                {
                    hash[num - 1] = num;
                }
            }
            for (int i = 0; i <= hash.Length - 1; i++)
            {
                if (hash[i] == 0)
                {
                    return i + 1;
                }
            }
            return nums.Length + 1;
        }


        public static int FirstMissingPositive1(int[] arr)
        {
            int i = 0;
            while (i < arr.Length)
            {
                if (arr[i] <= 0 || 
                    arr[i] > arr.Length ||
                    arr[arr[i] - 1] == arr[i])
                {
                    i++;
                }
                else
                {
                    swap(arr, i, arr[i] - 1);
                }
            }
            i = 0;
            while (i < arr.Length && arr[i] == i + 1)
            {
                i++;
            }
            return i + 1;
        }

        private static  void swap(int[] arr, int i, int j)
        {
            arr[i] = arr[i] ^ arr[j];
            arr[j] = arr[i] ^ arr[j];
            arr[i] = arr[i] ^ arr[j];
        }
    }
}