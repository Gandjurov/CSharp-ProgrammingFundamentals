using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._SquareNumbers
{
    class squareNumbers
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> squares = new List<int>();


            for (int i = 0; i < numbers.Count; i++)
            {
                var currentNumber = numbers[i];
                var square = Math.Sqrt(currentNumber);

                if (square == (int)square)
                {
                    squares.Add(currentNumber);
                }
            }

            squares.Sort();
            squares.Reverse();

            Console.WriteLine(string.Join(" ", squares));
        }
    }
}
