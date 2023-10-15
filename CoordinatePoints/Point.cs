using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoordinatePoints
{
    public class Point
    {
        private double _x;

        private double _y;

        public static int Counter;

        /// <summary>
        /// Initializes a new instance of the Point class with the specified coordinates. 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Point(double x, double y)
        {
            _x = x;
            _y = y;
            Counter++;
        }

        /// <summary>
        /// Gets or sets the X-coordinate of the point.
        /// </summary>
        public double X
        { 
            get { return _x; }
            set { _x = value; }
        }

        /// <summary>
        /// Gets or sets the Y-coordinate of the point.
        /// </summary>
        public double Y
        {
            get { return _y; }
            set { _y = value; }
        }

        /// <summary>
        /// Calculates the distance between two points on a 2D coordinate plane.
        /// </summary>
        /// <param name="point1"></param>
        /// <param name="point2"></param>
        /// <returns>An integer value representing the distance between the two points (rounded).</returns>
        public static int GetDestancebetweenPoints(Point point1, Point point2)
        {
            double deltaX = point1.X - point2.X;
            double deltaY = point1.Y - point2.Y;
            double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            return (int)Math.Round(distance);
        }

        /// <summary>
        /// Computes the distance from the current point to another point.
        /// </summary>
        /// <param name="otherPoint">The other point for calculating the distance.</param>
        /// <returns>An integer value representing the distance between the points (rounded)</returns>
        public int GetDistanceToPoint(Point otherPoint)
        {
            double deltaX = X - otherPoint.X;
            double deltaY = Y - otherPoint.Y;
            double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            return (int)Math.Round(distance);
        }
    }
}
