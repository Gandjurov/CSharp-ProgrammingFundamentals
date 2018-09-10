using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculateDistance
{
    class CalculateDistance
    {
        static void Main(string[] args)
        {
            var firstPoint = ReadPoint();
            var secondPoint = ReadPoint();

            var result = Distance(firstPoint, secondPoint);
            Console.WriteLine($"{result:F3}");


        }

        // Reading all point from console.
        static Point ReadPoint()
        {
            var pointData = Console.ReadLine()
                .Split(' ');

            var point = new Point
            {
                X = int.Parse(pointData[0]),
                Y = int.Parse(pointData[1])
            };

            return point;
        }

        // calculating distance between two points.
        static double Distance(Point first, Point second)
        {
            var xDiff = first.X - second.X;
            var xPow = xDiff * xDiff;

            var yDiff = first.Y - first.Y;
            var yPow = yDiff * yDiff;
            return Math.Sqrt(xPow + yPow);
        }
    }
}
