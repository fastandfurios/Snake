using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Figure
    {
	    protected List<Point> _pointsList;

	    public void Draw()
	    {
		    foreach (var point in _pointsList)
			    point.Draw();
	    }

	    internal bool IsHit(Figure figure)
	    {
		    foreach (var point in _pointsList)
		    {
			    if (figure.IsHit(point))
				    return true;
		    }

		    return false;
	    }

	    private bool IsHit(Point point)
	    {
		    foreach (var p in _pointsList)
		    {
			    if (p.IsHit(point))
				    return true;
		    }

		    return false;
	    }
	}
}
