using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Number_Table
{
    class NumberTable
    {
        static void Main(string[] args)
        {
            int numberRead = int.Parse(Console.ReadLine());

            for (int row = 1; row <= numberRead; row++)
            {
                for (int col = row; col <= numberRead; col++)
                {
                    Console.Write($"{col} ");
                }

                for (int col = numberRead - 1; col > numberRead - row; col--)
                {
                    Console.Write($"{col} ");
                }

                Console.WriteLine();
            }
        }
    }
}
