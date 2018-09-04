using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ForestRoad
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        

        for (int row = 0; row < N; row++)
        {
            Console.Write(new string('.', row));
            Console.Write(("*"));
            Console.Write(new string('.', (N - row) - 1));
            Console.WriteLine();
        }

        for (int row = 1; row <= N - 1; row++)
        {
            Console.Write(new string('.', (N - row) - 1));
            Console.Write(("*"));
            Console.Write(new string('.', row));
            Console.WriteLine();
        }

    }
}
