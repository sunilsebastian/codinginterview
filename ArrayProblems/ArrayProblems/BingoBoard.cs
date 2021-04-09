using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{

    //5  15
    //10 90
    public class BingoBoard
    {
        public static int[,] GetUKBingoBoard(int row, int col)
        {
            int i = 0;

            int[,] bingo = new int[row, col];
            int[] arr = new int[9]; 
            for ( i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }

            int count = 0;

            //for (int i = 0; i < 9; i++)
            //{
            //    Shuffle(arr);
            //    for (int j = 0; j < 3; j++)
            //    {
            //        bingo[j, i] = arr[j] + (i * 10);  //15
            //    }
            //}

            i = 0;
            while (count < 15)
            {

                Shuffle(arr);
                int rowrange = rng.Next(1, 3);
                int[] cols = new int[3] { 0, 1, 2 };
                Shuffle(cols);
                int k = 0;
                while (rowrange > 0 && count < 15)
                {
                    bingo[cols[k], i] = arr[cols[k]] + (i * 10);  //15

                    k++;
                    count++;
                    rowrange--;
                }
                i++;
                if (i == 9) 
                    i = 0;
            }

            for (i = 0; i < 3; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(string.Format("{0} ", bingo[i, j]));
                }
                Console.Write("\n" + "\n");
            }
            return bingo;
        }


        public static int[,] GetBingoBoard(int row, int col)
        {

            int[,] bingo = new int[row, col];
            int[] arr = new int[15]; 

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }




            for (int i = 0; i < 5; i++)
            {
                Shuffle(arr);

                for (int j = 0; j < 5; j++)
                {
                    bingo[j, i] = arr[j] + (i * 15);  //15
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(string.Format("{0} ", bingo[i, j]));
                }
                Console.Write("\n" + "\n");
            }
            return bingo;
        }


        private static Random rng = new Random();
        public static void Shuffle(int[] arr)
        {
            int n = arr.Length;

            int i = 0;
            while(i<n)
            {
                int k = rng.Next(i,n);

                int value = arr[k];
                arr[k] = arr[i];
                arr[i] = value;

                i++;
            }
            //int[] arr = Enumerable.Range(1, 10).OrderBy(c => rnd.Next()).ToArray();
        }
    }
}
