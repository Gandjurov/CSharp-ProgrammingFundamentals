using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumBigNumbers
{
    class SumBigNumbers
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();

            if (num1.Length > num2.Length)
            {
                num2 = num2.PadLeft(num1.Length, '0');
            }
            else
            {
                num1 = num1.PadLeft(num2.Length, '0');
            }

            int sum = 0;
            int reminder = 0;
            int num = 0;
            StringBuilder sb = new StringBuilder();
            for (int i = num1.Length - 1; i >= 0; i--)
            {
                sum = num1[i] - 48 + num2[i] - 48 + reminder;
                num = sum % 10;
                if (sum > 9)
                {
                    reminder = 1;
                }
                else
                {
                    reminder = 0;
                }
                sb.Append(num);
                if (i==0 && reminder == 1)
                {
                    sb.Append(reminder);
                }
            }
            Console.WriteLine(sb.ToString().TrimEnd('0').ToCharArray().Reverse().ToArray());
        }
    }
}
