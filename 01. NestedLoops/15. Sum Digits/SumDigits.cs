using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Sum_Digits
{
    class SumDigits
    {
        static void Main(string[] args)
        {
            int numberRead = int.Parse(Console.ReadLine());

            int sum = 0;
            while (numberRead > 0)
            {
                int lastDigit = numberRead % 10;
                sum += lastDigit;

                numberRead = numberRead / 10;

            }

            Console.WriteLine(sum);
        }
    }
}
