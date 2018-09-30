using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtractMiddleElements
{
    class ExtractMiddleElements
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int startIndex = Math.Max(0, sequence.Length / 2 - 1);
            int endIndex = startIndex + 1;

            if (sequence.Length == 1)
            {
                endIndex = 0;
            }
            else if (sequence.Length % 2 != 0)
            {
                endIndex++;
            }
            
            HashSet<int> middleElements = new HashSet<int>();

            for (int i = startIndex; i <= endIndex; i++)
            {
                middleElements.Add(sequence[i]);
            }

            Console.WriteLine("{ " + string.Join(", ", middleElements) + " }");
        }
    }
}
