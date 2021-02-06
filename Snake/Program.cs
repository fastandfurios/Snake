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

			var line = new HorizontalLine(5, 10, 8, '+');
			line.Draw();

			var vLine = new VerticalLine(5, 10, 10, '+');
			vLine.Draw();

			Console.ReadLine();
		}
	}
}
