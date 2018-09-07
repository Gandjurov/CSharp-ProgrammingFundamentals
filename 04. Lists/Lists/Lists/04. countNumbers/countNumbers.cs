using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._countNumbers
{
    class countNumbers
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            // 8 2 2 8 2 2 3 7
            // 2 2 2 2 3 7 8 8 

            //variant 1

            numbers.Sort();
            numbers.Add(int.MaxValue);

            var currentNumber = numbers[0];
            var currentCount = 1;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (currentNumber == numbers[i])
                {
                    currentCount++;
                }
                else
                {
                    Console.WriteLine($"{currentNumber} -> {currentCount}");
                    currentNumber = numbers[i];
                    currentCount = 1;
                }
            }

            //variant 2

            int[] numbersCount = new int[1001];

            for (int i = 0; i < numbers.Count; i++)
            {
                var currentNum = numbers[i];

                numbersCount[currentNum]++;
            }

            for (int i = 0; i < numbersCount.Length; i++)
            {
                var currentNum = numbersCount[i];
                if (currentNum > 0)
                {
                    Console.WriteLine($"{i} -> {currentNum}");
                }
            }
        }
    }
}
