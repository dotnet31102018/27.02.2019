using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2702
{
    class Point
    {
        public int X { get; set; }

        public int Y { get; set; }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public static bool operator ==(Point p1, Point p2)
        {
            if (ReferenceEquals(p1 , null)  && ReferenceEquals(p2 , null))
            {
                return true;
            }

            if (ReferenceEquals(p1 , null) || ReferenceEquals(p2 , null))
            {
                return false;
            }

            if (p1.X == p2.X && p1.Y == p2.Y)
                return true;

            return false;
        }

        public static bool operator !=(Point p1, Point p2)
        {
            return !(p1 == p2);
        }

        public static bool operator >(Point p1, Point p2)
        {
            if (p1 == p2)
                return false;

            return (Math.Sqrt(Math.Pow(p1.X, 2) + Math.Pow(p1.Y, 2)) >
                    Math.Sqrt(Math.Pow(p2.X, 2) + Math.Pow(p2.Y, 2)));
        }

        public static bool operator <(Point p1, Point p2)
        {
            if (p1 == p2)
                return false;

            return !(p1 > p2);
        }

        public static bool operator >=(Point p1, Point p2)
        {
            //return !(p1 < p2);
            return (p1 == p2 || p1 > p2);
        }

        public static bool operator <=(Point p1, Point p2)
        {
            //return !(p1 > p2);
            return (p1 == p2 || p1 < p2);
        }

        public override string ToString()
        {
            return $"Point: ( {X}, {Y} )";
        }

        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y);
        }

        public static Point operator -(Point p1, Point p2)
        {
            return new Point(p1.X - p2.X, p1.Y - p2.Y);
        }

        public static Point operator *(Point p1, Point p2)
        {
            return new Point(p1.X * p2.X, p1.Y * p2.Y);
        }
        public override bool Equals(object obj)
        {
            Point otherPoint = obj as Point;

            return this == otherPoint;
        }
    }
}

