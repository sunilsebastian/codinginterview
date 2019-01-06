using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphProblems
{
    public class LevelGolfCourseField
    {

        public static void LevelField(int[,] field)
        {
            int row = field.GetLength(0);
            int column = field.GetLength(1);

            int[] X = { 0, -1, 0, 1 };
            int[] y = { -1, 0, 1, 0 };

            bool[,] visited = new bool[row, column];

            var cell = FindCornerWithFlatCell(field, row, column);
            visited[cell.Item1, cell.Item2] = true;
            Console.Write($"({cell.Item1},{cell.Item2}) ");

            if (cell.Item1 == -1)
                return;

            var min = FindMinHeightTree(field);

            while (min != Int32.MaxValue)
            {
                bool isProgressed = false;
                int r1 = 0;
                int c1 = 0;
                for (int i = 0; i < X.Length; i++)
                {

                    r1 = cell.Item1 + X[i];
                    c1 = cell.Item2 + y[i];

                    if (r1 >= 0 && r1 <= row - 1 && c1 >= 0 && c1 <= column - 1 && visited[r1, c1] != true)
                    {
                        if (field[r1, c1] == min)
                        {

                            field[r1, c1] = 1;
                            cell = new Tuple<int, int>(r1, c1);
                            Console.Write($"({cell.Item1},{cell.Item2}) ");
                            visited[r1, c1] = true;
                            isProgressed = true;
                            break;
                        }
                        else if ((field[r1, c1] == 1))
                        {

                            //finding neighour in trap
                            bool traped = false;
                            for (int k = 0; k < X.Length; k++)
                            {
                                var r2 = r1 + X[k];
                                var c2 = c1 + y[k];

                                if (r2 >= 0 && r2 <= row - 1 && c2 >= 0 && c2 <= column - 1)
                                {
                                    if (visited[r2, c2] == true || field[r2, c2] == 0 || (field[r2, c2]!= min && field[r2, c2] != 1))
                                    {
                                        traped = true;
                                    }
                                    else
                                    {
                                        traped = false;
                                        break;
                                    }

                                }
                            }
                            //finding neighour in trap ends

                            if (traped == false)
                            {
                                cell = new Tuple<int, int>(r1, c1);
                                isProgressed = true;
                                visited[r1, c1] = true;
                                Console.Write($"({cell.Item1},{cell.Item2}) ");
                            }
                        }

                    }
       
                }
                if (isProgressed == false)
                {
                    break;
                }
                min = FindMinHeightTree(field);
            }
        }


        private static int FindMinHeightTree(int[,] field)
        {
            int min = Int32.MaxValue;
            for(int i=0;i< field.GetLength(0);i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if(field[i,j]>1 && field[i, j]<min)
                    {
                        min = field[i, j];
                    }
                }
            }

            return min;
        }

        private  static Tuple<int,int> FindCornerWithFlatCell(int[,] field, int row,int column)
        {
            if (field[0, 0] == 1)
                return new Tuple<int, int>(0, 0);
            else if(field[0, column-1] == 1)
                {
                return new Tuple<int, int>(0,column-1);
            }

            else if (field[0, column - 1] == 1)
            {
                return new Tuple<int, int>(0, column - 1);
            }
            else if (field[row-1, column - 1] == 1)
            {
                return new Tuple<int, int>(row-1, column - 1);
            }
            else if (field[row - 1, 0] == 1)
            {
                return new Tuple<int, int>(row - 1, column - 1);
            }
            else
            {
                return new Tuple<int, int>(-1,-1);
            }
        }
    }
}
