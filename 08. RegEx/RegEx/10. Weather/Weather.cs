using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace Weather
{
    class Weather
    {
        static void Main()
        {
            string pattern = @"([A-Z]{2})([0-9]+\.[0-9]{1,2})([A-Za-z]+)\|";
            string input = Console.ReadLine();
            List<string> lines = new List<string>();


            while (input != "end")
            {
                lines.Add(input);
                input = Console.ReadLine();
            }

            List<Match> myMatches = new List<Match>();

            foreach (var line in lines)
            {
                var matches = Regex.Matches(line, pattern);
                foreach (Match thisMatch in matches)
                {
                    myMatches.Add(thisMatch);
                }
            }


            Dictionary<string, List<string>> weather = new Dictionary<string, List<string>>();

            foreach (Match current in myMatches)
            {
                var city = current.Groups[1].Value;
                var avgTemp = current.Groups[2].Value;
                var typeOfWeather = current.Groups[3].Value;

                if (!weather.ContainsKey(city))
                {
                    List<string> tempList = new List<string>();
                    tempList.Add(avgTemp);
                    tempList.Add(typeOfWeather);
                    weather.Add(city, tempList);
                }
                else
                {
                    weather[city].Clear();
                    weather[city].Add(avgTemp);
                    weather[city].Add(typeOfWeather);
                }
            }

            foreach (var pair in weather.OrderBy(x => double.Parse(x.Value[0])))
            {
                Console.WriteLine($"{pair.Key} => {double.Parse(pair.Value[0]):F2} => {pair.Value[1]}");
            }
        }
    }
}
