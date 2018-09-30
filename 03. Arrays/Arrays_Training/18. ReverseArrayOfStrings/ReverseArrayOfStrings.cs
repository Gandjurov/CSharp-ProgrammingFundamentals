using System;

namespace ReverseArrayOfStrings
{
    class ReverseArrayOfStrings
    {
        static void Main(string[] args)
        {
            string[] sequence = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            sequence = SwapElements(sequence);
            Console.WriteLine(string.Join(" ", sequence));
        }

        private static string[] SwapElements(string[] sequence)
        {
            for (int i = 0; i < sequence.Length / 2; i++)
            {
                string temp = sequence[i];
                sequence[i] = sequence[sequence.Length - 1 - i];
                sequence[sequence.Length - 1 - i] = temp;
            }
            return sequence;
        }
    }
}
