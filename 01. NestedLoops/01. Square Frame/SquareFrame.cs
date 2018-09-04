using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Square_Frame
{
    class SquareFrame
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int calcSize = size - 2;

            string topAndBotRow = "+";
            for (int col = 0; col < calcSize; col++)
            {
                topAndBotRow = topAndBotRow + " -";
            }
            topAndBotRow = topAndBotRow + " +";

            Console.WriteLine(topAndBotRow);

            for (int row = 0; row < calcSize; row++)
            {
                string middleRows = "|";
                for (int col = 0; col < calcSize; col++)
                {
                    middleRows = middleRows + " -";
                }
                middleRows = middleRows + " |";

                Console.WriteLine(middleRows);
            }

           
            Console.WriteLine(topAndBotRow);
            
        }
    }
}
