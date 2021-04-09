using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonVirtual
{
    public class SnakeGame
    {


        //["SnakeGame","move","move","move","move","move","move"]
        //[[3,2,[[1,2],[0,1]]],["R"],["D"],["R"],["U"],["L"],["U"]]


        int curr_row;
        int curr_col;

        int total_row;
        int total_col;

        int length;

        Queue<int[]> queue_food;
        List<int[]> snake_path;
        public SnakeGame(int width, int height, int[][] food)
        {
            //current cell row column
            curr_row = 0;
            curr_col = 0;

            //initial length of snake
            length = 0;

            //total number of rows and columns
            total_row = height;
            total_col = width;

            //Put food in Queue.
            queue_food = new Queue<int[]>();
            foreach (int[] curr_food in food)
                queue_food.Enqueue(curr_food);

            //To check if snake is collides with himself
            snake_path = new List<int[]>();
            snake_path.Add(new int[] { 0, 0 });
        }

        public int Move(string direction)
        {
            switch (direction)
            {
                case "R":
                    curr_col++;
                    break;
                case "L":
                    curr_col--;
                    break;
                case "U":
                    curr_row--;
                    break;
                case "D":
                    curr_row++;
                    break;
            }

            if (curr_row < 0 || curr_col < 0 || curr_row >= total_row || curr_col >= total_col)
                return -1;
            
            //check if snake is collides with himself
            //here check if new path is any of the last paths untill length of snake
            for (int i = snake_path.Count() - 1; i >= snake_path.Count() - length; i--)
            {
                if (snake_path[i][0] == curr_row && snake_path[i][1] == curr_col)
                    return -1;
            }
            //check if there is food at new_row and new_col
            if (queue_food.Count != 0)
            {
                if (curr_row == queue_food.Peek()[0] && curr_col == queue_food.Peek()[1])
                {
                    queue_food.Dequeue();//eat the food
                    length++;//increase the length
                }
            }


            snake_path.Add(new int[] { curr_row, curr_col });
            //finally return length
            return length;
        }
    }
}
