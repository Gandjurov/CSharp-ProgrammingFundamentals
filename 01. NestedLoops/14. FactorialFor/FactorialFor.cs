using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.FactorialFor
{
    class FactorialFor
    {
        static void Main(string[] args)
        {
            int numberRead = int.Parse(Console.ReadLine());

            int fact = 1;
            for (int i = numberRead; i > 1; i--)
            {
                fact = fact * i;
            }

            //int fact = 1;
            //do
            //{
            //    fact = fact * numberRead;
            //    numberRead--;
            //} while (numberRead > 1);

            Console.WriteLine(fact);
        }
    }
}
