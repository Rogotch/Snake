using System;
using System.Collections.Generic;

namespace Snake
{
    /// <summary>
    /// Вертикальная линия
    /// </summary>
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
        /// <summary>
        /// Отрисовка стены другим цветом
        /// </summary>
        public override void Draw()
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            base.Draw();
            Console.ResetColor();
        }
    }
}