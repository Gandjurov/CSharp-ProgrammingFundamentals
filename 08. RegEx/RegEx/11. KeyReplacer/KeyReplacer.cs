using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;

namespace KeyReplacer
{
    class KeyReplacer
    {
        static void Main(string[] args)
        {
            string pattern = @"([A-Za-z]+)([<\|\\])(.*)([<\|\\])([A-Za-z]+)";
            string input = Console.ReadLine();
            Match myMatch = Regex.Match(input, pattern);

            string start = myMatch.Groups[1].Value;
            string end = myMatch.Groups[5].Value;

            string input2 = Console.ReadLine();
            string pattern2 = $@"{start}(.*?){end}";

            StringBuilder builder = new StringBuilder();

            if (Regex.IsMatch(input2, pattern2))
            {
                var results = Regex.Matches(input2, pattern2);

                foreach (Match m in results)
                {
                    builder.Append(m.Groups[1].Value);
                }
                Console.WriteLine(builder.ToString());
            }
            else
            {
                Console.WriteLine("Empty result");
            }
            
        }

    }
}
