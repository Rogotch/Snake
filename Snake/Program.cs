using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //Начальное положение змейки
            Point p1 = new Point(1,3,'*');

            //Создание и отрисовка стен-рамки
            Walls walls = new Walls(Console.WindowWidth, Console.WindowHeight);
            walls.Draw();

            //Создание и отрисовка змейки
            Snake snake = new Snake(p1,4,Direction.Right);
            snake.Draw();

            //Создание генератора еды
            FoodCreator foodCreator = new FoodCreator(Console.WindowWidth-1, Console.WindowHeight-1, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            //Отключение отображения курсора
            Console.CursorVisible = false;
            //Цикл игры
            while (true)
            {
                //Проверка столкновения со стенами или хвостом
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                //Проверка, съедается ли точка с едой
                if (snake.Eat(food)) //Да - змейка растёт
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else                 //Нет - змейка движется дальше    
                {
                    snake.Move();
                }
                //Скорость движения змейки
                Thread.Sleep(100);
                //Определение направления змейки
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    snake.HandleKey(key.Key);
                }
            }

            Console.ReadKey();
        }

    }
}
