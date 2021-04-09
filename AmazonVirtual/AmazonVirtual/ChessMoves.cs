using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonVirtual
{

    public class Spot
    {
        public  Piece piece { get; set; }
        public  int X { get; set; }
        public  int Y { get; set; }

        public Spot(int x, int y, Piece p)
        {
            piece = p;
            X = x;
            Y = y;
        }
    }

    public  abstract class Piece
    {
        private bool killed = false;
        private bool white = false;

        public Piece(bool white)
        {   this.SetWhite(white);   }
        public bool IsWhite()
        {   return this.white;  }

        public void SetWhite(bool white)
        { this.white = white; }

        public bool isKilled()
        {  return this.killed; }

        public void setKilled(bool killed)
        {   this.killed = killed;   }

        public abstract bool canMove(Board board,
                                     Spot start, Spot end);

    }

    public class Knight : Piece
    {

        public Knight(bool white) : base(white)
        {  }
        public override bool canMove(Board board, Spot start, Spot end)
        {
            if (end.piece.IsWhite() == this.IsWhite())
            {
                return false;
            }

            int x = Math.Abs(start.X - end.Y);
            int y = Math.Abs(start.Y - end.Y);
            return x * y == 2;
        }
    }

    public class Bishop : Piece
    {

        public Bishop(bool white) : base(white)
        { }
        public override bool canMove(Board board, Spot start, Spot end)
        {
            if (end.piece.IsWhite() == this.IsWhite())
            {
                return false;
            }

            int x = Math.Abs(start.X - end.Y);
            int y = Math.Abs(start.Y - end.Y);
            return x == y;
        }
    }

    public class Pawn : Piece
    {

        public Pawn(bool white) : base(white)
        { }
        public override bool canMove(Board board, Spot start, Spot end)
        {
            if (end.piece.IsWhite() == this.IsWhite())
            {
                return false;
            }
            var color = this.IsWhite();
            int dx = color ? -1 : 1;
            //for white move forward means decreasing rows
            //for black move  forward means increasing rows

            if (end.X == start.X + dx && 
                end.X == start.X && board.boxes[end.X,end.Y]==null )
                return true;

            //diagonal 
            if (end.X == start.X + dx && end.X == start.X-1)
                return true;
            if (end.X == start.X + dx && end.X == start.X +1)
                return true;

            return false;

        }
    }

    public class Board
    {
       public  Spot[,] boxes { get; set; }
        public Board()
        {
            boxes = new Spot[8, 8];
            resetBoard();
        }



        public void resetBoard()
        {

            // initialize white pieces 
            //boxes[0,0] = new Spot(0, 0, new Rook(true));
            //boxes[0,1] = new Spot(0, 1, new Knight(true));
            //         //... 
            //boxes[1][0] = new Spot(1, 0, new Pawn(true));
            //boxes[1][1] = new Spot(1, 1, new Pawn(true));
            //... 

            for (int i = 2; i < 6; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    boxes[i,j] = new Spot(i, j, null);
                }
            }
        }

    }


        //public minMove(x1, y1, x2, y2)
        //{
        //    if (isWhite(x1, y1) != isWhite(x2, y2)) return -1;
        //    else if (x1 == x2 && y1 == y2) return 0;
        //    else if (Math.abs(x1 - x2) == Math.abs(y1 - y2)) return 1;
        //    else return 2;
        //}

        //private boolean isWhite(int x, int y)
        //{
        //    return x % 2 == y % 2;
        //}
    }
