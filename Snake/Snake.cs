using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Snake : Figure
    {
	    public Snake(Point tail, int length, Direction direction)
	    {
		    _pointsList = new List<Point>();
		    for (int i = 0; i < length; i++)
		    {
			    var point = new Point(tail);
			    point.Move(i, direction);
			    _pointsList.Add(point);
		    }
	    }
    }
}
