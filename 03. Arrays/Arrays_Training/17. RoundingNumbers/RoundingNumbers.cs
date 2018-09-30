using System;
using System.Linq;

namespace RoundingNumbers
{
    class RoundingNumbers
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse)
            .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(string.Join(" => ", numbers[i], Math.Round(numbers[i], MidpointRounding.AwayFromZero)));
            }
        }
    }
}
