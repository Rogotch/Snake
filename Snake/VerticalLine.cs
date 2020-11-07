using System.Collections.Generic;

namespace Snake
{
    public class VerticalLine : Figure
    {
        public VerticalLine(int x, int yTop, int yBottom, char sym)
        {
            PointList = new List<Point>();
            for (int y = yTop; y < yBottom; y++)
            {
                Point p = new Point(x, y, sym);
                PointList.Add(p);
            }
        }
    }
}