using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AnonymousVox
{
    class AnonymousVox
    {
        static void Main()
        {
            string encodedText = Console.ReadLine();
            string[] placeholders = Console.ReadLine().Split("{}".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            string pattern = @"([A-Za-z]+)(.+)(\1)";

            var matches = Regex.Matches(encodedText, pattern);

            int count = 0;
            foreach (Match match in matches)
            {
                string decodedMessage = match.Groups[1] + placeholders[count++] + match.Groups[3];
                encodedText = encodedText.Replace(match.Value, decodedMessage);
            }
            Console.WriteLine(encodedText);

        }
    }
}
