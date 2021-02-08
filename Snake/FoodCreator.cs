using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class FoodCreator
    {
	    private int _mapWidht;
	    private int _mapHeight;
	    private char _sym;
	    private Random _random = new Random();

	    public FoodCreator(int mapWidht, int mapHeight, char sym)
	    {
		    _mapWidht = mapWidht;
		    _mapHeight = mapHeight;
		    _sym = sym;
	    }

	    public Point CreatorFood()
	    {
		    int x = _random.Next(2, _mapWidht - 2);
		    int y = _random.Next(2, _mapHeight - 2);
		    return new Point(x, y, _sym);
	    }
    }
}
