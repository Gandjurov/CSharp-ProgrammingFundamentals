using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonDontGO
{
    class PokemonDontGO
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int sum = 0;
            int index = 0;
            int current = 0;

            while (numbers.Count > 0)
            {
                index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    current = numbers[0];
                    numbers[0] = numbers[numbers.Count - 1];
                    //numbers.RemoveAt(0);
                    //numbers.Insert(0, numbers.Last());
                }
                else if (index > numbers.Count - 1)
                {
                    current = numbers[numbers.Count - 1];
                    numbers[numbers.Count - 1] = numbers[0];
                    //numbers.Remove(numbers.Last());
                    //numbers.Add(numbers.First());
                }
                else
                {
                    current = numbers[index];
                    numbers.RemoveAt(index);
                }

                sum += current;

                // to be corrections...
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] <= current)
                    {
                        numbers[i] += current;
                    }
                    else
                    {
                        numbers[i] -= current;
                    }
                }
                

            }
            Console.WriteLine(sum);
        }
    }
}
