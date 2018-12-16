using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MultiplyEvensbyOdds
{
    static void Main(string[] args)
    {
        int n = Math.Abs(int.Parse(Console.ReadLine()));
        Console.WriteLine($"{ResultOfMultiplecation(n)}");
    }

    public static int GetSumOfOddDigits(int n)
    {
        int sum = 0;
        while (n > 0)
        {
            int lastDigit = n % 10;
            if (lastDigit % 2 != 0)
            {
                sum += lastDigit;
            }

            n /= 10;
        }

        return sum;
    }

    public static int GetSumOfEvenDigits(int n)
    {
        int sum = 0;
        while (n > 0)
        {
            int lastDigit = n % 10;
            if (lastDigit % 2 == 0)
            {
                sum += lastDigit;
            }

            n /= 10;
        }

        return sum;
    }

    static int ResultOfMultiplecation(int n)
    {
        int sumOfEvens = GetSumOfEvenDigits(n);
        int sumOfOdd = GetSumOfOddDigits(n);
        int result = sumOfEvens * sumOfOdd;
        return result;
    }
}
