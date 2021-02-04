using System;

namespace Snake
{
	class Program
	{
		static void Main(string[] args)
		{
			var p1 = new Point(1, 3, '*');
			p1.Draw();

			var p2 = new Point(4, 5, '#');
			p2.Draw();
		}
	}
}
