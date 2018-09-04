using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rhombus
{
    class Rhombus
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int countWhiteSpaces = size - 1;

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < countWhiteSpaces; col++)
                {
                    Console.Write(" ");
                }

                Console.Write("*");
                for (int col = 0; col <= row - 1 ; col++)
                { 
                    Console.Write(" *");
                }
                countWhiteSpaces--;
                Console.WriteLine();
            }

            countWhiteSpaces = 1;
            int countOfStars = size - 1;
            int botRows = countOfStars;

            for (int row = 0; row < botRows; row++)
            {
                for (int col = 0; col < countWhiteSpaces; col++)
                {
                    Console.Write(' ');
                }
                Console.Write("*");
                for (int col = 0; col < countOfStars - 1; col++)
                {
                    Console.Write(" *");
                }
                countWhiteSpaces++;
                countOfStars--;
                Console.WriteLine();
            }



        }
    }
}
