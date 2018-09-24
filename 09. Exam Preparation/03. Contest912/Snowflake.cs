using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Snowflake
{
    class Snowflake
    {
        static void Main(string[] args)
        {
            string surface = Console.ReadLine();
            string mantle = Console.ReadLine();
            string middle = Console.ReadLine();
            string secondMantle = Console.ReadLine();
            string secondSurface = Console.ReadLine();

            //surface
            string surfacePattern = @"[^A-Za-z0-9]+";
            var surfaceRegex = new Regex($"^{surfacePattern}$");

            if (!surfaceRegex.IsMatch(surface))
            {
                Console.WriteLine("Invalid");
                return;
            }

            //secondSurface
            if (!surfaceRegex.IsMatch(secondSurface))
            {
                Console.WriteLine("Invalid");
                return;
            }

            //mantle
            string mantlePattern = @"[\d_]+";
            var mantleRegex = new Regex($"^{mantlePattern}$");
            if (!mantleRegex.IsMatch(mantle))
            {
                Console.WriteLine("Invalid");
                return;
            }

            //secondMantle
            if (!mantleRegex.IsMatch(secondMantle))
            {
                Console.WriteLine("Invalid");
                return;
            }

            //core
            string corePattern = @"[A-Za-z]+";
            var middleRegex = new Regex($"^{surfacePattern}{mantlePattern}({corePattern}){mantlePattern}{surfacePattern}$");
            if (!middleRegex.IsMatch(middle))
            {
                Console.WriteLine("Invalid");
                return;
            }

            Console.WriteLine("Valid");
            var match = middleRegex.Match(middle);
            Console.WriteLine(match.Groups[1].Value.Length);
        }
    }
}
