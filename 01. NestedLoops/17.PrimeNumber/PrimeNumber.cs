using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.PrimeNumber
{
    class PrimeNumber
    {
        static void Main(string[] args)
        {
            int numberRead = int.Parse(Console.ReadLine());

            if (numberRead <= 1 )
            {
                Console.WriteLine("not prime");
                return;
            }

            bool isPrime = true;
            for (int i = 2; i <= numberRead - 1; i++)
            {
                if (numberRead % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            string result = isPrime ? "prime" : "not prime";
            Console.WriteLine(result);
        }
    }
}
