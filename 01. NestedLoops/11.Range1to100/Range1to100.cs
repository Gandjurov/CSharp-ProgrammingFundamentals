using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Range1to100
{
    class Range1to100
    {
        static void Main(string[] args)
        {
            int numberRead = int.Parse(Console.ReadLine());

            while (numberRead < 1 || numberRead > 100)
            {
                Console.Write("Invalid number! Try again: ");
                numberRead = int.Parse(Console.ReadLine());
                
            }

            Console.WriteLine("Valid number: {0}", numberRead);
        }
    }
}
