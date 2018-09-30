using System;
using System.Linq;

namespace SumArrays
{
    class SumArrays
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] array2 = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            int maxLength = Math.Max(array1.Length, array2.Length);
            long[] sumArrays = new long[maxLength];

            for (int i = 0; i < sumArrays.Length; i++)
            {
                sumArrays[i] = array1[i % array1.Length] + array2[i % array2.Length];
            }

            Console.WriteLine(string.Join(" ", sumArrays));
        }
    }
}
