using System;

namespace Snake
{
    /// <summary>
    /// Класс точки на экране, который описывает символ, который эта точка представляет и её положение в консоли
    /// </summary>
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

        /// <summary>
        /// Класс движения точки в консоли
        /// </summary>
        /// <param name="offset">размер сдвига</param>
        /// <param name="direction">направление</param>
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
        /// <summary>
        /// Очистка точки представляет из себя простую замену символа точки на пробел и повторную отрисовку
        /// </summary>
        internal void Clear()
        {
            Sym = ' ';
            Draw();
        }

        /// <summary>
        /// Отрисовка точки
        /// </summary>
        public void Draw()
        {
            //Курсор ставится по координатам...
            Console.SetCursorPosition(X, Y);
            //...и выводится нужный символ
            Console.WriteLine(Sym);
        }
        /// <summary>
        /// Определяет, соприкасаются ли точки, путём сравнения их координат и вывода true или false
        /// </summary>
        /// <param name="food">Точка, с которой идёт сравнение</param>
        /// <returns>Результат сравнения</returns>
        internal bool IsHit(Point food)
        {
            return food.X == this.X && food.Y == this.Y;
        }
    }
}