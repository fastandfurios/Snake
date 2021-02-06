using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class VerticalLine
    {
	    private List<Point> _pointsList;

	    public VerticalLine(int yUp, int yDown, int x, char sym)
	    {
		    _pointsList = new List<Point>();
		    for (int y = yUp; y < yDown; y++)
		    {
			    var point = new Point(x, y, sym);
				_pointsList.Add(point);
		    }
	    }

	    public void Draw()
	    {
		    foreach (var point in _pointsList)
			    point.Draw();
	    }
    }
}
