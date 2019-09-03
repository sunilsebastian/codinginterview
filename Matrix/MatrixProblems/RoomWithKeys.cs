using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixProblems
{
    public class RoomWithKeys
    {
        public static int[][] find_shortest_path(string[] grid)
        {

            var result = new List<int[]>();
            int startRow=0;
            int startColumn=0;
            bool[,] visited = new bool[grid.Length, grid[0].Length];

            int[] x = new int[] { 0, -1, 0, 1 };
            int[] y = new int[] { -1, 0, 1, 0 };

            Dictionary<MatCell, MatCell> parent = new Dictionary<MatCell, MatCell>();


            for (int i = 0; i < grid.Length; i++)
            {
                if (grid[i].IndexOf("@") != -1)
                {
                    startRow = i;
                    startColumn = grid[i].IndexOf("@");
                }

            }

            visited[startRow, startColumn] = true;

            Queue<MatCell> queue = new Queue<MatCell>();
            var m = new MatCell(startRow, startColumn, new List<char>());
            queue.Enqueue(m);
            parent.Add(m, null);
            while (queue.Count != 0)
            {
                var matCell = queue.Dequeue();
                visited[matCell.Row, matCell.Col] = true;
                if (grid[matCell.Row][matCell.Col] == '+')
                {

                    var s = matCell;

                    while (parent[s] != null)
                    {
                        result.Add(new int[] { s.Row, s.Col });
                        s = parent[s];
                    }
                    result.Add(new int[] { s.Row, s.Col });
                    result.Reverse();
                    break;
                }

                for (int i = 0; i < 4; i++)
                {
                    var newKey = new List<Char>();
                    int r = matCell.Row + x[i];
                    int c = matCell.Col + y[i];
                    if(matCell.Keys.Count!=0)
                    {
                        newKey.AddRange(matCell.Keys);
                    }
                    
                    if (BoundaryCheck(grid, visited, r, c, newKey))
                    {
                      
                        var mt = new MatCell(r, c, newKey);
                        queue.Enqueue(mt);
                        parent.Add(mt, matCell);
                    }

                }

            }
            return result.ToArray();

        }
     
        public static bool BoundaryCheck(string[] grid, bool[,] visited, int row, int col, List<char> Keys)
        {
            int rows = grid.Length;
            int cols = grid[0].Length;

            var keys = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };
            var rooms = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };

           // || visited[row, col] == true
            if (row < 0 || row >= rows || col < 0 || col >= cols||grid[row][col] == '#')
            {
                return false;
            }
            if(grid[row][col] == '+')
            {
                return true;
            }
            if (keys.Contains(grid[row][col]))
            {
                Keys.Add(grid[row][col]);
                return true;
            }

            if (rooms.Contains(grid[row][col]))
            {
                if (Keys.Contains(char.ToLower(grid[row][col])))
                    return true;
                else
                    return false;

            }

            return true;
        }



        public class MatCell
        {
            public int Row { get; set; }
            public int Col { get; set; }

            public List<char> Keys { get; set; }

            public MatCell(int row, int col, List<char> keys)
            {
                Row = row;
                Col = col;
                Keys = keys;
            }

        }

    }
}
