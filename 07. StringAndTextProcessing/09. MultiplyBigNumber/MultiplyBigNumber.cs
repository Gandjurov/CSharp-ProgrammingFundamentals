using System;
using System.Linq;
using System.Text;

namespace MultiplyBigNumber
{
    class MultiplyBigNumber
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());
            if (num2 == 0)
            {
                Console.WriteLine("0");
                return;
            }
            int multiplyer = 0;
            int reminder = 0;
            int num = 0;
            StringBuilder sb = new StringBuilder();

            for (int i = num1.Length-1; i >= 0; i--)
            {
                multiplyer = (num1[i] - '0') * num2 + reminder;
                num = multiplyer % 10;
                if (multiplyer > 0)
                {
                    reminder = multiplyer / 10;
                }
                else
                {
                    reminder = 0;
                }
                sb.Append(num);
            }
            if (reminder > 0)
            {
                sb.Append(reminder);
            }
            Console.WriteLine(sb.ToString().TrimEnd('0').ToCharArray().Reverse().ToArray());
        }
    }
}
