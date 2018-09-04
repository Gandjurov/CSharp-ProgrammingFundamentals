using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.SumDigitsWithText
{
    class SumDigitsWithText
    {
        static void Main(string[] args)
        {
            string numberRead = Console.ReadLine();

            int sum = 0;
            for (int i = 0; i <= numberRead.Length - 1; i++)
            {
                char symbol = numberRead[i];
                int parsedNumber = int.Parse(symbol.ToString());

                sum += parsedNumber;
            }

            Console.WriteLine(sum);
        }
    }
}
