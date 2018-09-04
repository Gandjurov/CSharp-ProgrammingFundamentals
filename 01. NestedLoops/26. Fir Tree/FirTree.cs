using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FirTree
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        int dotCount = N - 2;
        int starCount = 1;
        for (int row = 0; row < N - 1; row++)
        {
            Console.Write(new string('.', dotCount));
            Console.Write(new string('*', starCount));
            Console.Write(new string('.', dotCount));
            Console.WriteLine();
            dotCount--;
            starCount += 2;
        }

        int lastDotCount = N - 2;
        int lastStarCount = 1;
        Console.Write(new string('.', lastDotCount));
        Console.Write(new string('*', lastStarCount));
        Console.Write(new string('.', lastDotCount));
        Console.WriteLine();
    }
}

