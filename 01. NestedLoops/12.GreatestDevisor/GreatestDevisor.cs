using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.GreatestDevisor
{
    class GreatestDevisor
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            while (secondNumber != 0)
            {
                int result = firstNumber % secondNumber;
                firstNumber = secondNumber;
                secondNumber = result;

            }

            Console.WriteLine(firstNumber);
        }
    }
}
