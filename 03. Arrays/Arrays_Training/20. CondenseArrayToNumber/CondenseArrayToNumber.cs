using System;
using System.Linq;

namespace CondenseArrayToNumber
{
    class CondenseArrayToNumber
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            while (sequence.Length > 1)
            {
                int[] condensedArray = new int[sequence.Length - 1];
                for (int i = 0; i < sequence.Length - 1; i++)
                    condensedArray[i] = sequence[i] + sequence[i + 1];
                sequence = condensedArray;
            }

            Console.WriteLine(sequence[0]);
        }
    }
}
