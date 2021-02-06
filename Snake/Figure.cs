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
	}
}
