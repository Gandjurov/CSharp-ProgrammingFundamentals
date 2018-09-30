using System;
using System.Linq;

namespace SumsLastKNumbers
{
    class SumsLastKNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            long[] sequence = new long[n];
            sequence[0] = 1;
            for (int i = 1; i < n; i++)
                for (int prev = i - 1; prev >= Math.Max(0, i - k); prev--)
                    sequence[i] += sequence[prev];
            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}
