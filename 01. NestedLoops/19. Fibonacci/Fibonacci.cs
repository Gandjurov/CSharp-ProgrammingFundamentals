using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int numberRead = int.Parse(Console.ReadLine());

            int firstNumber = 0;
            int secondNumber = 1;

            for (int i = 0; i < numberRead; i++)
            {
                int newNumber = firstNumber + secondNumber;

                firstNumber = secondNumber;
                secondNumber = newNumber;

            }

            Console.WriteLine(secondNumber);

        }
    }
}
