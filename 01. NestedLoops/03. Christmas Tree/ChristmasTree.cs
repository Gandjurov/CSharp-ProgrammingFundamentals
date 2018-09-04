using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Christmas_Tree
{
    class ChristmasTree
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int rows = size + 1;
            int countWhiteSpaces = size;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < countWhiteSpaces; col++)
                {
                    Console.Write(' ');
                }

                for (int col = 0; col < row; col++)
                {
                    Console.Write('*');
                }

                Console.Write(" | ");

                for (int col = 0; col < row; col++)
                {
                    Console.Write('*');
                }

                countWhiteSpaces--;
                Console.WriteLine();
            }


        }
    }
}
