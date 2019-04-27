﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixProblems
{
    public class Program
    {
        public static void Main(string[] args)
        {
        
        

            int[,] mat = new int[,] {
                { 0, 1, 2, 3 },
                { 4, 5, 6, 7 },
                { 8, 9, 10,11 },
                { 12,13,14,15 } };
            Console.WriteLine("Roated Matrix 90 Degree:");
            RotateMatrix.RotateMatrix90(mat);

            Console.WriteLine();


            char[,] grid = new char[,]{ {'H','E','L','L','O'},
                                        { 'E','E','L','I','O'},
                                        { 'L','E','L','M','O'},
                                        { 'P','E','L','B','O'}};
            bool isFound = SearchForStringInMatrix.FindString(grid, "HELP");
            Console.WriteLine();

            mat = new int[,] {
                { 0, 1, 2, 3 },
                { 4, 5, 6, 7 },
                { 8, 9, 10,11 },
                { 12,13,14,15 } };

            Console.WriteLine("Print Matrix Diagonally::");
            MatrixDiagonally.PrintMatrixDiagonally(mat);
            Console.WriteLine();

            var mat1 = new int[,] {
                { 11, 12, 13, 14 },
                { 15, 16, 17, 18 },
                { 19, 20, 21, 22 }
                //{ 23, 24, 25, 26 }
                //{ 27, 28, 29, 30 }
            };

            MatrixSpirall.PrintMatrixSpiral(mat1);
            Console.WriteLine();



            Console.WriteLine();

            int[,] mat2 = new int[,] {
                { 16, 1, 2, 3 },
                { 4, 5, 6, 7 },
                { 0, 9, 10,11 },
                { 12,13,14,0 } };
            Console.WriteLine("Matrix after setting zero:");
            MakeRowColumnZero.SetColumRowWhenZeroFound(mat2);
            Console.WriteLine();

            char[,] sudoku = new char[,]   {
                      {'5','3','.','.','7','.','.','.','.'},
                      {'6','.','.','1','9','5','.','.','.'},
                      {'.','9','8','.','.','.','.','6','.'},
                      {'8','.','.','.','6','.','.','.','3'},
                      {'4','.','.','8','.','3','.','.','1'},
                      {'7','.','.','.','2','.','.','.','6'},
                      {'.','6','.','.','.','.','2','8','.'},
                      {'.','.','.','4','1','9','.','.','5'},
                      {'.','.','.','.','8','.','.','7','9'}
                    };
            bool isValid = ValidSudoku.IsValidSudoku(sudoku);


            int[,] meet = new int[,] {
                { 1, 0, 0, 0,1 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 1, 0, 0 } };
          var dist=  MeetingPoint.MinTotalDistance(meet);

            Console.ReadLine();
        }
    }
}
