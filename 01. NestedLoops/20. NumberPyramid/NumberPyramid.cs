using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.NumberPyramid
{
    class NumberPyramid
    {
        static void Main(string[] args)
        {
            int numberRead = int.Parse(Console.ReadLine());


            int num = 0;
            for (int row = 0; ; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    Console.Write($"{++num} ");

                    if (num == numberRead)
                    {
                        return;
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
