using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PrintingTriangle
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        PrintTriangle(n);
    }

    public static void PrintColums(int row)
    {
        for (int col = 1; col <= row; col++)
        {
            Console.Write("{0} ", col);
        }

        Console.WriteLine();
    }

    public static void PrintTriangle(int n)
    {
        for (int row = 1; row <= n; row++)
        {
            PrintColums(row);
        }

        for (int row = n - 1; row >= 1; row--)
        {
            PrintColums(row);
        }
    }
}
