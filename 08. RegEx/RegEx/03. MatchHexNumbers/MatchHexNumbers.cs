using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace MatchHexNumbers
{
    class MatchHexNumbers
    {
        static void Main(string[] args)
        {
            var regex = @"\b(?:0x)?([0-9A-F]+\b)";

            var inputString = Console.ReadLine();

            var matches = Regex.Matches(inputString, regex)
                .Cast<Match>()
                .Select(a => a.Value)
                .ToArray();

            Console.WriteLine(string.Join(" ", matches));
        }
    }
}
