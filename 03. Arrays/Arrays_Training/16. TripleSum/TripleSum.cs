using System;
using System.Linq;

namespace TripleSum
{
    class TripleSum
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
            bool containsTriples = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers.Contains(numbers[i] + numbers[j]))
                    {
                        containsTriples = true;
                        Console.WriteLine("{0} + {1} == {2}", numbers[i], numbers[j], numbers[i] + numbers[j]);
                    }
                }

            }

            if (!containsTriples)
            {
                Console.WriteLine("No");
            }
        }
    }
}
