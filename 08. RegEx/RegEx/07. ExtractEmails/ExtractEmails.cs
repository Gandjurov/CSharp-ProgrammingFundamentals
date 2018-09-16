using System;
using System.Text.RegularExpressions;

namespace ExtractEmails
{
    class ExtractEmails
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"(^|(?<=\s))([a-z0-9]+)([_\.-]?[a-z0-9])*@([a-z0-9])+([-.][a-z0-9]+)*\.([a-z0-9]+)([-.][a-z0-9]+)*";

            var matches = Regex.Matches(input, pattern);

            foreach (Match m in matches)
            {
                Console.WriteLine(m.Value);
            }
        }
    }
}
