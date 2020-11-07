using System.Collections.Generic;

namespace Snake
{
    public class Figure
    {
        protected List<Point> PointList;

        public void Draw()
        {
            foreach (var point in PointList)
            {
                point.Draw();
            }
        }
    }
}