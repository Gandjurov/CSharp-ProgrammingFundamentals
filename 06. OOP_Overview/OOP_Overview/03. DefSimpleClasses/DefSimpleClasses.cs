using System;

namespace DefSimpleClasses
{
    class DefSimpleClasses
    {
        static void Main(string[] args)
        {
            var point = new Point
            {
                X = 10,
                Y = 20
            };
            Console.WriteLine(point.X);
        }
    }
}
