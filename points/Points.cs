using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Разработать классы Point (точка на плоскости) и Points
//(множество точек на плоскости). Перегрузить операции + (точка) —
//добавляет точку в множество, - (точка) — убирает точку из множества,
//если она в нем присутствует, + (множество точек) — объединение
//множеств, - (множество точек) — вычитание множеств, == - для точки и
//для множества, != - для точки и для множества.
//добавить обработчики исключений (не менее трёх
//исключительных ситуаций).

namespace points
{
    class Point
    {
        public int x;
        public int y;

        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        public static bool operator ==(Point left, Point right)
        {
            if (left.x == right.x && left.y == right.y) return true;
            return false;
        }

        public static bool operator !=(Point left, Point right)
        {
            if(left == right) return false;
            return true;
        }
    }
    class Points
    {
        public List<Point> points = new();

		public static Points operator +(Points left, Point right)
		{
            left.points.Add(right);
            return left;
		}

        public static Points operator -(Points left, Point right)
        {
            if(left.points.Contains(right)) left.points.Remove(right);
            return left;
        }

        public static Points operator +(Points left, Points right)
        {
            left.points.AddRange(right.points);
            return left;
        }

        public static Points operator -(Points left, Points right)
        {
            //Points result = new Points();
            //result.points.AddRange(left.points);
            //result.points.AddRange(right.points);
            //return result;
            foreach (var point in right.points)
            {
                if (left.points.Contains(point)) left.points.Remove(point);
            };
            return left;
        }

        public static bool operator ==(Points left, Points right)
        {
            if (left == right && left == right) return true;
            return false;
        }

        public static bool operator !=(Points left, Points right)
        {
            if (left == right) return false;
            return true;
        }
    }
}
