using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CameraView
{
    class CameraView
    {
        static void Main()
        {
            int[] inputNumbers = Console.ReadLine().
                Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
             
            int toSkip = inputNumbers[0];
            int toTake = inputNumbers[1];

            var inputString = Console.ReadLine();
            string pattern = @"\|<([\w]{" + toSkip + @"})([\w]{0," + toTake + @"})";

            var myMatches = Regex.Matches(inputString, pattern);
            List<string> result = new List<string>();

            foreach (Match m in myMatches)
            {
                result.Add(m.Groups[2].Value);
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
