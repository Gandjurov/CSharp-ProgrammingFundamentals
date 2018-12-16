using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MathPower
{
    static void Main(string[] args)
    {
        var baseNumber = double.Parse(Console.ReadLine());
        var power = int.Parse(Console.ReadLine());
        Console.WriteLine(Pow(baseNumber, power));
    }

    public static double Pow(double baseNumber, int power)
    {
        double result = 1;

        for (int i = 0; i < power; i++)
        {
            result *= baseNumber;
        }

        return result;
    }
}