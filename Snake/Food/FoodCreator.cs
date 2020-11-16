using System;

namespace Snake
{
    /// <summary>
    /// Класс описывающий процесс создания точек с едой и где еда будет создаваться
    /// </summary>
    public class FoodCreator
    {
        private int MapWight;
        private int MapHeight;
        private char Sym;

        Random rand = new Random();

        public FoodCreator(int mapWight, int mapHeight, char sym)
        {
            MapHeight = mapHeight;
            MapWight = mapWight;
            Sym = sym;
        }

        /// <summary>
        /// Создание точки с едой в случайной позиции на карте
        /// </summary>
        /// <returns></returns>
        public Point CreateFood()
        {
            int x = rand.Next(2, MapWight - 2),
                y = rand.Next(2, MapHeight - 2);
            return new Point(x,y,'$');
        }
    }
}