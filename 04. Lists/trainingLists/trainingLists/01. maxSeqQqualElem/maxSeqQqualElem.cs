using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._maxSeqQqualElem
{
    class maxSeqQqualElem
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int currentStart = 0;
            int currentLength = 1;
            int bestStart = 0;
            int bestLength = 1;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentLength++;
                    if (currentLength > bestLength)
                    {
                        bestLength = currentLength;
                        bestStart = currentStart;
                    }
                }
                else
                {
                    currentLength = 1;
                    currentStart = i;
                }
            }

            for (int i = bestStart; i < bestStart + bestLength; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();


            //List<int> numbers = Console.ReadLine()
            //    .Split(' ')
            //    .Select(int.Parse)
            //    .ToList();

            //int counter = 1;
            //int counterMax = 0;
            //int numberMax = 0;

            //for (int i = 0; i < numbers.Count - 1; i++)
            //{
            //    if (numbers[i] == numbers[i + 1])
            //    {
            //        counter++;
            //        if (counter > counterMax)
            //        {
            //            counterMax = counter;
            //            numberMax = numbers[i];
            //        }
            //    }
            //    else
            //    {
            //        counter = 1;
            //    }

            //    if (counter > counterMax)
            //    {
            //        counterMax = counter;
            //        numberMax = numbers[i];
            //    }
            //}

            //for (int i = 0; i < counterMax; i++)
            //{
            //    Console.Write(numberMax + " ");
            //}

        }
    }
}
