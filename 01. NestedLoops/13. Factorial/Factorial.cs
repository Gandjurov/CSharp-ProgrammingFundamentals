using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int numberRead = int.Parse(Console.ReadLine());

            int fact = 1;
            do
            {
                fact = fact * numberRead;
                numberRead--;
            } while (numberRead > 1);

            Console.WriteLine(fact);
        }
    }
}
