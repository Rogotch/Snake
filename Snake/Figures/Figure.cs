using System.Collections.Generic;

namespace Snake
{
    /// <summary>
    /// Базовыйкласс фигур, от которого наследуются остальные фигуры
    /// </summary>
    public class Figure
    {
        /// <summary>
        /// Так как размер фигуры может меняться и состоит из нескольких точек, то все точки будут храниться в списке
        /// </summary>
        protected List<Point> PointList;

        /// <summary>
        /// Отрисовка всей фигуры через цикл
        /// </summary>
        public virtual void Draw()
        {
            foreach (var point in PointList)
            {
                point.Draw();
            }
        }

        /// <summary>
        /// ПРоверяет, соприкасаются ли фигуры
        /// </summary>
        /// <param name="figure">фигура, с которой идёт сравнение</param>
        /// <returns></returns>
        internal bool IsHit(Figure figure)
        {
            foreach (var p in PointList)
            {
                if (figure.IsHit(p))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Сравнивает, соприкасается ли фигура с точкой
        /// </summary>
        /// <param name="point">точка, с которой идёт сравнение</param>
        /// <returns></returns>
        private bool IsHit(Point point)
        {
            foreach (var p in PointList)
            {
                if (p.IsHit(point))
                {
                    return true;
                }
            }

            return false;
        }

    }
}