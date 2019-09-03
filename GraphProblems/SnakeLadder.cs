using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphProblems
{
   public  class SnakeLadder
    {
        
            public int SnakesAndLadders(int[][] board)
            {
                if (board == null) { return 0; }

                var moves = -1;
                var n = board.Length;
                var visited = new int[(n * n) + 1];

                var q = new Queue<int>();

                q.Enqueue(1);

                while (q.Count > 0)
                {
                    var size = q.Count;
                    moves++;

                    for (var i = 0; i < size; i++)
                    {
                        var c = q.Dequeue();

                        visited[c] = 1;

                        if (c == n * n) { return moves; }

                        for (var step = 1; step <= 6; step++)
                        {
                            var cell = c + step;

                            var bottomRow = (int)Math.Ceiling((double)cell / n) - 1;

                            var rowIdx = ((n - 1) - bottomRow);
                            var colIdx = bottomRow % 2 == 0 ? ((cell - 1) % n) : ((n - 1) - ((cell - 1) % n));

                            if (rowIdx < 0 || colIdx < 0 || rowIdx >= n || colIdx >= n) { continue; }

                            var nextCell = board[rowIdx][colIdx] == -1 ? cell : board[rowIdx][colIdx];

                            if (visited[nextCell] == 0)
                            {
                                q.Enqueue(nextCell);
                            }
                        }
                    }
                }

                return -1;
            }
        }
    
}
