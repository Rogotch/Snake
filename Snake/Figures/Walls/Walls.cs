using System;
using System.Collections.Generic;

namespace Snake
{
    /// <summary>
    /// Класс, отрисовывающий рамку поля
    /// </summary>
    public class Walls
    {
        /// <summary>
        /// Список, содержащий все стены
        /// </summary>
        private List<Figure> WallList = new List<Figure>();

        /// <summary>
        /// Построение стен по переданным параметрам и занесение их в список фигур
        /// </summary>
        /// <param name="mapWight">ширина карты</param>
        /// <param name="mapHeight">высота карты</param>
        public Walls(int mapWight, int mapHeight)
        {
            HorizontalLine upLine = new HorizontalLine(0, mapWight - 2, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, mapWight - 2, mapHeight - 1, '+');
            VerticalLine leftLine = new VerticalLine(0, 0, mapHeight - 1, '+');
            VerticalLine rightLine = new VerticalLine(mapWight - 2, 0, mapHeight - 1, '+');

            WallList.Add(upLine);
            WallList.Add(downLine);
            WallList.Add(leftLine);
            WallList.Add(rightLine);
        }

        /// <summary>
        /// Проверяет соприкосновение стен с фигурой
        /// </summary>
        /// <param name="figure">Фигура, с которой идёт проверка столкновения</param>
        /// <returns></returns>
        internal bool IsHit(Figure figure)
        {
            foreach (var wall in WallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
                
            }

            return false;
        }

        /// <summary>
        /// Отрисовка стен
        /// </summary>
        public void Draw()
        {
            foreach (var wall in WallList)
            {
                wall.Draw();
            }
        }
    }
}