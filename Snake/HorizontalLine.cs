using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class HorizontalLine
    {
	    private List<Point> _pointspList;

	    public HorizontalLine(int xLeft, int xReight, int y, char sym)
	    {
		    _pointspList = new List<Point>();
		    for (int x = xLeft; x < xReight; x++)
		    {
			    var point = new Point(x, y, sym);
				_pointspList.Add(point);
		    }
	    }

	    public void Draw()
	    {
		    foreach (var point in _pointspList)
			    point.Draw();
	    }
    }
}
