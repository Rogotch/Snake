using System;
using System.Collections.Generic;
using System.Linq;

namespace Snake
{
    /// <summary>
    /// Змейка, персонаж, которым управляет игрок
    /// </summary>
    public class Snake : Figure
    {
        /// <summary>
        /// Направление движения змейки
        /// </summary>
        private Direction directionMove;
        public Snake(Point tail, int lenght, Direction direction)
        {
            this.directionMove = direction;
            PointList = new List<Point>();
            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, directionMove);
                PointList.Add(p);
            }
        }

        /// <summary>
        /// Движение змейки с отрисовкой новых точек спереди и удаления точек сзади
        /// </summary>
        internal void Move()
        {
            Point tail = PointList.First();
            PointList.Remove(tail);
            Point head = GetNextPoint();
            PointList.Add(head);

            tail.Clear();
            head.Draw();
        }
        /// <summary>
        /// Определяет следующую точку
        /// </summary>
        /// <returns></returns>
        private Point GetNextPoint()
        {
            Point head = PointList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, directionMove);
            return nextPoint;
        }

        /// <summary>
        /// Проверяет столкновение с хвостом
        /// </summary>
        /// <returns></returns>
        internal bool IsHitTail()
        {
            var head = PointList.Last();
            for (int i = 0; i < PointList.Count-2; i++)
            {
                if (head.IsHit(PointList[i]))
                {
                    return true;
                }
            }

            return false;
        }
        /// <summary>
        /// Контроллер, определяющий управление змейкой игроком
        /// </summary>
        /// <param name="key">Зажатая клавиша</param>
        public void HandleKey(ConsoleKey key)
        {

            switch (key)
            {
                case ConsoleKey.LeftArrow:
                case ConsoleKey.A:
                    if (directionMove == Direction.Right)
                    {
                        break;
                    }
                    directionMove = Direction.Left;
                    break;
                case ConsoleKey.RightArrow:
                case ConsoleKey.D:
                    if (directionMove == Direction.Left)
                    {
                        break;
                    }
                    directionMove = Direction.Right;
                    break;
                case ConsoleKey.UpArrow:
                case ConsoleKey.W:
                    if (directionMove == Direction.Down)
                    {
                        break;
                    }
                    directionMove = Direction.Up;
                    break;
                case ConsoleKey.DownArrow:
                case ConsoleKey.S:
                    if (directionMove == Direction.Up)
                    {
                        break;
                    }
                    directionMove = Direction.Down;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Определяет и описывает поедание еды змейкой
        /// </summary>
        /// <param name="food">Точка еды</param>
        /// <returns></returns>
        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.Sym = head.Sym;
                PointList.Add(food);
                food.Draw();
                return true;
            }
            else
                return false;
        }
    }
}