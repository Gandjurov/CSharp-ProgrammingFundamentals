using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Largest3Numbers
{
    class Largest3Numbers
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            numbers = numbers
                .OrderByDescending(n => n)
                .Take(3)
                .ToList();

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
