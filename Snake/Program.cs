using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace Snake
{
	class Program
	{
		static void Main(string[] args)
		{
			Walls walls = new Walls(80, 25);
			walls.Draw();
			

			var point = new Point(4, 5, '*');
			var snake = new Snake(point, 4, Direction.RIGHT);
			snake.Draw();

			FoodCreator foodCreator = new FoodCreator(80, 25, '$');
			Point food = foodCreator.CreatorFood();
			food.Draw();
			
			while (true)
			{
				if(walls.IsHit(snake) || snake.IsHitTail())
					break;

				if (snake.Eat(food))
				{
					food = foodCreator.CreatorFood();
					food.Draw();
				}
				else
					snake.Move();

				Thread.Sleep(100);

				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo key = Console.ReadKey();
					snake.HandleKey(key.Key);
				}

				Thread.Sleep(100);
				snake.Move();
			}
			

			Console.ReadLine();
		}
	}
}
