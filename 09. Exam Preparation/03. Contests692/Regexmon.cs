using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Regexmon
{
    class Regexmon
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string didiPattern = @"[^A-Za-z-]+";
            string bojoPattern = @"[A-Za-z]+-[A-Za-z]+";
            int round = 1;

            while (true)
            {
                if (round % 2 == 1)
                {
                    if (!Regex.IsMatch(input, didiPattern))
                    {
                        return;
                    }
                    else
                    {
                        Match current = Regex.Match(input, didiPattern);
                        input = input.Substring(current.Index + current.Length);
                        Console.WriteLine(current.ToString());
                    }
                }
                else
                {
                    if (!Regex.IsMatch(input, bojoPattern))
                    {
                        return;
                    }
                    else
                    {
                        Match current = Regex.Match(input, bojoPattern);
                        input = input.Substring(current.Index + current.Length);
                        Console.WriteLine(current.ToString());
                    }
                }
                round++;
            }
        }
    }
}
