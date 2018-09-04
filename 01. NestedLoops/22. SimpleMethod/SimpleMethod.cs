using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.SimpleMethod
{
    class SimpleMethod
    {
        static void Main(string[] args)
        {
            string readText = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            string result = RepeatString(readText, count);
            Console.WriteLine(result);

        }

        private static string RepeatString(string textToRepeat, int count)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                result.Append($" {textToRepeat}");
            }

            return result.ToString();

        }

    }
}
