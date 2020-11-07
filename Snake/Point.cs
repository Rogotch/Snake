using System;

namespace Snake
{
    public class Point
    {
        public int X;
        public int Y;
        public char Sym;

        public Point(int x, int y, char sym)
        {
            this.X = x;
            this.Y = y;
            this.Sym = sym; 
        }

        public Point(Point p) :
            this(p.X, p.Y, p.Sym) { }

        public void Move(int offset, Direction direction)
        {
            switch (direction)
            {
                case Direction.Down:
                    Y = Y + offset;
                    break;
                case Direction.Up:
                    Y = Y - offset;
                    break;
                case Direction.Right:
                    X = X + offset;
                    break;
                case Direction.Left:
                    X = X - offset;
                    break;
            }
        }

        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.WriteLine(Sym);
        }
    }
}