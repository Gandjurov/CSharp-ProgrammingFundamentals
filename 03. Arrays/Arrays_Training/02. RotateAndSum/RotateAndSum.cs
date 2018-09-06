using System;
using System.Linq;

namespace _02._RotateAndSum
{
    class RotateAndSum
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int numberOfRotations = int.Parse(Console.ReadLine());
            int[] sum = new int[numbers.Length];

            for (int i = 0; i < numberOfRotations; i++)
            {
                numbers = Rotate(numbers);
                for (int j = 0; j < numbers.Length; j++)
                {
                    sum[j] += numbers[j];
                }
            }

            Console.WriteLine(string.Join(" ", sum));

            //int[] numbers = Console.ReadLine()
            //    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse)
            //    .ToArray();
            //int rotations = int.Parse(Console.ReadLine());
            //int[] sumRotatedNumbers = new int[numbers.Length];

            //for (int i = 0; i < rotations; i++)
            //{
            //    int[] rotatedNumbers = new int[numbers.Length];
            //    rotatedNumbers[0] = numbers[numbers.Length - 1];
            //    for (int j = 1; j < numbers.Length; j++)
            //        rotatedNumbers[j] = numbers[j - 1];
            //    for (int j = 0; j < numbers.Length; j++)
            //        sumRotatedNumbers[j] += rotatedNumbers[j];
            //    numbers = rotatedNumbers;
            //}
            //Console.WriteLine(string.Join(" ", sumRotatedNumbers));
        }

        static int[] Rotate(int[] numbers)
        {
            int[] rotated = new int[numbers.Length];
            int last = numbers[numbers.Length - 1];

            for (int i = 1; i < rotated.Length; i++)
            {
                rotated[i] = numbers[i - 1];
            }
            rotated[0] = last;
            return rotated;
        }
    }
}
