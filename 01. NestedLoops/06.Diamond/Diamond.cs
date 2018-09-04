using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Diamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int countOfStars = size % 2 == 0 ? 2 : 1;

            int countOfSideDashes = (size - countOfStars) / 2;

            string topAndBotDashes = new string('-', countOfSideDashes);
            string stars = new string('*', countOfStars);

            Console.WriteLine("{0}{1}{0}", topAndBotDashes, stars);

            countOfSideDashes--;
            int countOfMiddleDashes = countOfStars;
            int rows = (size - 1) / 2;

            for (int row = 0; row < rows; row++)
            {
                string sideDashes = new string('-', countOfSideDashes);
                string middleDashes = new string('-', countOfMiddleDashes);

                Console.WriteLine("{0}*{1}*{0}", sideDashes, middleDashes);

                countOfSideDashes--;
                countOfMiddleDashes += 2;
            }

            rows--;
            countOfSideDashes += 2;
            countOfMiddleDashes -= 4;

            for (int row = 0; row < rows; row++)
            {
                string sideDashes = new string('-', countOfSideDashes);
                string middleDashes = new string('-', countOfMiddleDashes);

                Console.WriteLine("{0}*{1}*{0}", sideDashes, middleDashes);

                countOfSideDashes++;
                countOfMiddleDashes -= 2;
            }

            if (size > 2)
            {
                Console.WriteLine("{0}{1}{0}", topAndBotDashes, stars);
            }
            
        }
    }
}
