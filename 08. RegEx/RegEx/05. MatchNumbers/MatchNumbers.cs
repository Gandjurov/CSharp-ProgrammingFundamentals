using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace MatchNumbers
{
    class MatchNumbers
    {
        static void Main(string[] args)
        {
            var pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            var inputString = Console.ReadLine();

            var numbers = Regex.Matches(inputString, pattern);

            foreach (Match number in numbers)
            {
                Console.Write(number.Value + " ");
            }

            Console.WriteLine();
        }
    }
}
