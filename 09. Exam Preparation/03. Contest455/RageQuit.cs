using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RageQuit
{
    class RageQuit
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            List<char> uniques = new List<char>();
            StringBuilder result = new StringBuilder();
            
            string pattern = @"(\D+)(\d+)";

            var matches = Regex.Matches(inputText, pattern);
            
            foreach (Match m in matches)
            {
                var symbol = m.Groups[1].Value.ToUpper();
                var countIncrease = int.Parse(m.Groups[2].Value);

                for (int i = 0; i < countIncrease; i++)
                {
                    result.Append(symbol);
                    
                }
                if (countIncrease != 0)
                {
                    uniques.AddRange(symbol);
                }
                
            }

            Console.WriteLine($"Unique symbols used: {uniques.Distinct().Count()}");
            Console.WriteLine(result);
        }
    }
}
