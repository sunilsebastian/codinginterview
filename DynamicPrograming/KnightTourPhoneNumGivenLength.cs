using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPrograming
{
    public class KnightTourPhoneNumGivenLength
    {

        public  static long GetPhoneNumberGivenLength(int startdigit, int phonenumberlength)
        {
            Dictionary<int, List<int>> adjList = new Dictionary<int, List<int>>();
            adjList.Add(0, new List<int> { 4, 6 });
            adjList.Add(1, new List<int> { 6, 8 });
            adjList.Add(2, new List<int> { 7, 9 });
            adjList.Add(3, new List<int> { 8, 4 });
            adjList.Add(4, new List<int> { 0, 9, 3 });
            adjList.Add(5, new List<int>());
            adjList.Add(6, new List<int> { 1, 7, 0 });
            adjList.Add(7, new List<int> { 6, 2 });
            adjList.Add(8, new List<int> { 1, 3 });
            adjList.Add(9, new List<int> { 2, 4 });

            if (phonenumberlength <= 0)
            {
                return 0;
            }
            if (startdigit == 5 && phonenumberlength > 1)
            {
                return 0;
            }
            long[,] table = new long[10, phonenumberlength + 1];
            for (int i = 0; i <= 9; i++)
            {
                table[i, 0] = 0;
                table[i, 1] = 1;
            }

            for (int j = 2; j <= phonenumberlength; j++)
            {
                //List<int> prevNeighbours = new List<int>();
                for (int i = 0; i <= 9; i++)
                {
                    long num = 0;
                    foreach (int neighbour in adjList[i])
                    {
                        num = num + table[neighbour, j - 1];
                    }
                    table[i, j] = num;
                }
            }

            return table[startdigit, phonenumberlength];


        }


    }
}
