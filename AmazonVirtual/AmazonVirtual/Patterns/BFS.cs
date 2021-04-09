using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonVirtual
{
    public class BFS
    {

        public int MinDepth(TreeNode root)
        {
            if (root == null) return 0;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            int depth = 0;
            queue.Enqueue(root);
            while (queue.Count() != 0)
            {
                depth++;
                int n = queue.Count();
                for (int i = 0; i < n; i++)
                {
                    TreeNode node = queue.Dequeue();
                    if (node.left == null && node.right == null)
                    {
                        return depth;
                    }

                    if (node.right != null) queue.Enqueue(node.right);
                    if (node.left != null) queue.Enqueue(node.left);
                }
            }
            return depth;

        }

        public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
        {
            int[] x = new int[] { -1, 1, 0, 0 };
            int[] y = new int[] { 0, 0, -1, 1 };

            int currentColor = image[sr][sc];
            Queue<(int, int)> q = new Queue<(int, int)>();
            q.Enqueue((sr, sc));
            image[sr][sc] = newColor;

            while (q.Count() != 0)
            {
                var cell = q.Dequeue();
                for (int i = 0; i < 4; i++)
                {
                    int newRow = cell.Item1 + x[i];
                    int newCol = cell.Item2 + y[i];


                    if (newRow < 0 || newRow > image.Length - 1 || newCol < 0 ||
                       newCol > image[0].Length - 1 || image[newRow][newCol] == newColor
                       || image[newRow][newCol] != currentColor)
                        continue;

                    q.Enqueue((newRow, newCol));
                    image[newRow][newCol] = newColor;
                }
            }
            return image;
        }

        public static int GetShortestPath(int[][] mat, int[][] start, int[][] end)
        {
            Queue<(int, int)> q = new Queue<(int, int)>();
            int row = start[0][0];
            int col = start[0][1];
            q.Enqueue((row, col));
            mat[row][col] = 1;
            int[][] cord = new int[4][] { new int[] { -1, 0 }, new int[] { 0, 1 }, new int[] { 1, 0 }, new int[] { 0, -1 } };

            //int level = 0;
            int level = -1;

            while (q.Count() != 0)
            {
                int size = q.Count();
                level++;


                while (size > 0)
                {
                    var current = q.Dequeue();

                    if (end[0][0] == current.Item1 && end[0][1] == current.Item2)
                        return level;
                    for (int i = 0; i < 4; i++)
                    {
                        int newRow = current.Item1 + cord[i][0];
                        int newCol = current.Item2 + cord[i][1];

                        if (newRow < 0 || newRow > mat.Length - 1 || newCol < 0 || newCol > mat[0].Length - 1)
                            continue;

                        if (mat[newRow][newCol] != 1)
                        {
                            mat[newRow][newCol] = 1;
                            q.Enqueue((newRow, newCol));
                        }


                    }
                    size--;
                }
               // level++;

            }
            return -1;
        }
    }
}
