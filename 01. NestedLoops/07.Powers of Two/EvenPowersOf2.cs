using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Powers_of_Two
{
    class EvenPowersOf2
    {
        static void Main(string[] args)
        {
            int numberRead = int.Parse(Console.ReadLine());

            for (int i = 0; i <= numberRead; i += 2)
            {
                int power = (int)Math.Pow(2, i);
                Console.WriteLine(power);
            }
        }
    }
}
