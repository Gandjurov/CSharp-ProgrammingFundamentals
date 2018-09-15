using System;
using System.Text.RegularExpressions;


namespace Overview
{
    class Overview
    {
        static void Main(string[] args)
        {
            //Regex regex = new Regex(@"\w+");
            //var text = "This is some text.";

            //bool hasRegexPattern = regex.IsMatch(text);

            //Console.WriteLine(hasRegexPattern);

            Console.WriteLine("------------------------------------------------");

            //Regex pattern = new Regex(@"(\d{2})-(\w{3})-(\d{4})");
            //var text2 = "This text has date: 20-Jan-2018.";

            //var result = pattern.Match(text2);

            //Console.WriteLine(result);
            //Console.WriteLine("Index: " + result.Index);
            //Console.WriteLine("Value: " + result.Value);

            //Console.WriteLine("Groups: " + result.Groups.Count);

            //Console.WriteLine("Year: " + result.Groups[3]);

            //var matches = pattern.Matches(text2);

            //foreach (Match match in matches)
            //{
            //    Console.WriteLine(match.Value);
            //    Console.WriteLine(match.Groups[3].Value);
            //}

            Console.WriteLine("------------------------------------------------");

            ////Replace
            //string text3 = "Nakov: 123, Branson: 456";
            //string pattern = @"\d{3}";
            //string replacement = "999";

            //Regex regex = new Regex(pattern);
            //string result3 = regex.Replace(text3, replacement);

            //Console.WriteLine(result3);
            //// Nakov: 999, Branson: 999
            
            Console.WriteLine("------------------------------------------------");

            //Replace <a> tag

            //from:   <ul><li><a href="http://softuni.bg">SoftUni</a></li></ul> 
            //to:     <ul><li>[URL href="http://softuni.bg"]SoftUni[/URL]</li></ul>

            var text4 = @"<ul> <li> <a href=""http://softuni.bg"">SoftUni</a></li></ul>";

            var regex = new Regex(@"<a.+href=""(.+?)"">(.+?)<\/a>");
            var matches = regex.Matches(text4);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }

            var result5 = regex.Replace(text4, "[URL href = \"$1\"]$2[/URL]");

            Console.WriteLine(result5);
        }
    }
}
