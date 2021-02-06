using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class HorizontalLine : Figure
    {
	    public HorizontalLine(int xLeft, int xRight, int y, char sym)
	    {
		    _pointsList = new List<Point>();
		    for (int x = xLeft; x < xRight; x++)
		    {
			    var point = new Point(x, y, sym);
				_pointsList.Add(point);
		    }
	    }
    }
}
