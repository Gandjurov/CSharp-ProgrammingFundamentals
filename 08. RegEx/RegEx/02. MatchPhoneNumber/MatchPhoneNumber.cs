using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    class MatchPhoneNumber
    {
        static void Main()
        {
            var regex = @"( ?\+359 2 \d{3} \d{4}\b)|(\+ ?359-2-\d{3}-\d{4}\b)";

            var phones = Console.ReadLine();

            var phoneMatches = Regex.Matches(phones, regex);

            var machedPhones = phoneMatches
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();
            

            Console.WriteLine(string.Join(", ", machedPhones));

        }
    }
}
