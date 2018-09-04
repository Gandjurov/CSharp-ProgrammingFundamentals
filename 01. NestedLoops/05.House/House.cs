using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.House
{
    class House
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int roofTopRows = (size + 1) / 2;
            int bodyRows = size / 2;
            int countOfStars = size % 2 == 0 ? 2 : 1;
            //int countOfStars = 1;
            //if (size % 2 == 0)
            //{
            //    countOfStars = 2;
            //}
            int countOfUnderscore = (size - countOfStars) / 2;

            for (int row = 0; row < roofTopRows; row++)
            {
                string underscores = new string('-', countOfUnderscore);
                string stars = new string('*', countOfStars);

                Console.WriteLine("{0}{1}{0}", underscores, stars);

                countOfUnderscore--;
                countOfStars += 2;
            }

            for (int row = 0; row < bodyRows; row++)
            {
                string stars = new string('*', size - 2);

                Console.WriteLine("|{0}|", stars);
            }

        }
    }
}
