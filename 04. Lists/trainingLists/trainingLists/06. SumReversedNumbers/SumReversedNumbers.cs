using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._SumReversedNumbers
{
    class SumReversedNumbers
    {
        static void Main(string[] args)
        {
            //List<int> numbers = Console.ReadLine()
            //    .Split(' ')
            //    .Select(int.Parse)
            //    .ToList();
            //int sum = 0;

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    List<char> num = numbers[i].ToString().ToList();
            //    num.Reverse();
            //    sum += int.Parse(string.Join("", num));
            //}
            //Console.WriteLine(sum);

            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int sum = 0;
            int count = numbers.Count;

            for (int i = 0; i < numbers.Count; i++)
            {
                List<char> num = numbers[i].ToString().ToList();
                num.Reverse();
                numbers.Add(int.Parse(string.Join("", num)));
            }
            numbers.RemoveRange(0, count);
            Console.WriteLine(numbers.Sum());

        }
    }
}
