using System;

namespace ReverseArrayOfIntegers
{
    class ReverseArrayOfIntegers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numArr = new int[n];
            int[] reversedArr = new int[n];

            for (int i = 0; i < n; i++)
            {
                int inputNumbers = int.Parse(Console.ReadLine());

                numArr[i] = inputNumbers;
            }

            for (int i = 0; i < n; i++)
            {
                reversedArr[i] = numArr[n - 1 - i];
            }

            foreach (var item in reversedArr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
