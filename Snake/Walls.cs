using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Walls
    {
	    private List<Figure> _wallsList;

	    public Walls(int mapWidth, int mapHeight)
	    {
		    _wallsList = new List<Figure>();

			var upLine = new HorizontalLine(0, mapWidth - 2, 0, '+');
			var downLine = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, '+');
			var leftLine = new VerticalLine(0, mapHeight - 1, 0, '+');
			var rightLine = new VerticalLine(0, mapHeight - 1, mapWidth - 2, '+');
			
			_wallsList.Add(upLine);
			_wallsList.Add(downLine);
			_wallsList.Add(leftLine);
			_wallsList.Add(rightLine);
		}

	    internal bool IsHit(Figure figure)
	    {
		    foreach (var wall in _wallsList)
		    {
			    if (wall.IsHit(figure))
				    return true;
		    }

		    return false;
	    }

	    public void Draw()
	    {
		    foreach (var wall in _wallsList)
			    wall.Draw();
	    }
    }
}
