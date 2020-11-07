using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,3,'*');
            List<Point> pointList = new List<Point>();

            foreach (var point in pointList)
            {
                point.Draw();
            }

            Snake snake = new Snake(p1,4,Direction.Right);
            snake.Draw();

            Console.ReadKey();
        }

        public static void Frame()
        {
            int xEnd = Console.WindowWidth,
                yEnd = Console.WindowHeight;

            List<Figure> FrameBoard = new List<Figure>();
            FrameBoard.Add(new HorizontalLine(0, xEnd, 0, '+'));
            FrameBoard.Add(new HorizontalLine(0, xEnd, yEnd, '+'));
            FrameBoard.Add(new VerticalLine(0, 0, yEnd, '+'));
            FrameBoard.Add(new VerticalLine(xEnd, 0, yEnd, '+'));
            foreach (var figure in FrameBoard)
            {
                figure.Draw();
            }
        }
    }
}
