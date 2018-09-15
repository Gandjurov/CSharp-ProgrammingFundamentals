using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace ReplaceATag
{
    class ReplaceATag
    {
        static void Main()
        {
            int rowCounter = 0;
            string input = "";
            string pattern = @"(<a.*?\w*?.*?)=(.*?)>(.*?)(<\/a>)";

            List<string> list = new List<string>();

            while (rowCounter < 100)
            {
                input = Console.ReadLine();

                //if input is end then break
                if (input == "end")
                {
                    break;
                }
                else
                {
                    var matches = Regex.Matches(input, pattern);

                    string replacer = "[URL href=$2]$3[/URL]";
                    var replaced = Regex.Replace(input, pattern, replacer);

                    input = replaced;
                    list.Add(input);
                    rowCounter++;
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, list));
            Console.WriteLine();
        }
    }
}
