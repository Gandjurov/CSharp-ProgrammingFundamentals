using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SingOfIntNumber
{
    static void Main(string[] args)
    {
        var number = int.Parse(Console.ReadLine());
        PrintSign(number);
    }    

    static void PrintSign(int number)
    {
        if (number > 0)
        {
            Console.WriteLine("The number {0} is positive.", number);
        }
        else if (number < 0)
        {
            Console.WriteLine("The number {0} is negative.", number);
        }
        else
        {
            Console.WriteLine("The number {0} is zero.", number);
        }
    }
 
}

