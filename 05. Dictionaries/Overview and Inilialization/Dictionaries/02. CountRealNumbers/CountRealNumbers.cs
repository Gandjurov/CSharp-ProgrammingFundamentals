using System;
using System.Linq;
using System.Collections.Generic;


namespace _02._CountRealNumbers
{
    class CountRealNumbers
    {
        static void Main(string[] args)
        {
            // 8 2.5 2.5 8 2.5
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            SortedDictionary<double, int> numbersCount = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!numbersCount.ContainsKey(number))
                {
                    numbersCount[number] = 1;
                }
                else
                {
                    numbersCount[number]++;
                }
            }

            foreach (var kvp in numbersCount)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
