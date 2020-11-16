using System;
using System.Collections.Generic;

namespace Snake
{
    /// <summary>
    /// ГОризонтальная линия
    /// </summary>
    public class HorizontalLine : Figure
    {
        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            PointList = new List<Point>();
            for (int x = xLeft; x < xRight; x++)
            {
                Point p = new Point(x, y, sym);
                PointList.Add(p);
            }
        }

        /// <summary>
        /// Отрисовка линии другим цветом
        /// </summary>
        public override void Draw()
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            base.Draw();
            Console.ResetColor();
        }
    }
}