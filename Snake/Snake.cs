using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Snake : Figure
    {
	    private Direction _direction;

	    public Snake(Point tail, int length, Direction direction)
	    {
		    _direction = direction;
		    _pointsList = new List<Point>();
		    for (int i = 0; i < length; i++)
		    {
			    var point = new Point(tail);
			    point.Move(i, direction);
			    _pointsList.Add(point);
		    }
	    }

	    internal void Move()
	    {
		    var tail = _pointsList.First();
		    _pointsList.Remove(tail);
		    var head = GetNextPoint();
			_pointsList.Add(head);

			tail.Clear();
			head.Draw();
	    }

	    private Point GetNextPoint()
	    {
		    var head = _pointsList.Last();
		    var nextPoint = new Point(head);
			nextPoint.Move(1, _direction);
			return nextPoint;
	    }

	    internal bool IsHitTail()
	    {
		    var head = _pointsList.Last();
		    for (int i = 0; i < _pointsList.Count; i++)
		    {
			    if (head.IsHit(_pointsList[i]))
				    return true;
		    }

		    return false;
	    }

	    public void HandleKey(ConsoleKey key)
	    {
		    if (key == ConsoleKey.LeftArrow)
			    _direction = Direction.LEFT;
		    else if (key == ConsoleKey.RightArrow)
			    _direction = Direction.RIGHT;
		    else if (key == ConsoleKey.DownArrow)
			    _direction = Direction.DOWN;
		    else if (key == ConsoleKey.UpArrow)
			    _direction = Direction.UP;
		}

	    internal bool Eat(Point food)
	    {
		    Point head = GetNextPoint();
		    if (head.IsHit(food))
		    {
			    food.sym = head.sym;
			    _pointsList.Add(food);
			    return true;
		    }
		    else
			    return false;
	    }
    }
}
