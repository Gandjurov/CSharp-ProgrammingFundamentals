using System;
using System.Collections.Generic;
using System.Linq;

namespace _00._Dictionaries
{
    class Dictionaries
    {
        static void Main()
        {
            Dictionary<string, double> marks = new Dictionary<string, double>();
            marks["Ivan"] = 6.00;  // marks.Add("Ivan", 5) - tova ne prezapisva kato pyrviq variant, i s nego mojem da se podsigurim za unikalni elementi.
            marks["Gosho"] = 5.50;
            marks["Pesho"] = 3.00;

            double ivanMark = marks["Ivan"];
            Console.WriteLine(ivanMark);

            double goshoMark = marks["Gosho"];
            Console.WriteLine(goshoMark);
            Console.WriteLine("=========================================================================");
            //=========================================================================
            //example:

            Dictionary<char, int> letterCount = new Dictionary<char, int>();

            letterCount['a'] = 100;
            letterCount['t'] = 2568;
            letterCount['z'] = 3;

            Console.WriteLine(letterCount['t']); // Attention: this is case sensitive!!!
            Console.WriteLine("=========================================================================");


            //foreach example:

            foreach (var mark in marks)
            {
                var key = mark.Key;
                var value = mark.Value;
                Console.WriteLine($"Student: {key} - Mark: {value}");
            }
            Console.WriteLine("=========================================================================");

            //example: nested list in dictionary

            Dictionary<string, List<double>> marksList = new Dictionary<string, List<double>>();

            marksList["Ivan"] = new List<double>();
            marksList["Ivan"].Add(5);
            marksList["Ivan"].Add(6);
            marksList["Ivan"].Add(4);

            marksList["Gosho"] = new List<double>();
            marksList["Gosho"].Add(3);

            foreach (var mark in marksList["Ivan"])
            {
                Console.WriteLine(mark);
            }
            Console.WriteLine("=========================================================================");


            //example: Sorded Dictionary
            var dict = new SortedDictionary<string, int>();

            dict["Pesho"] = 5;
            dict["Ivan"] = 10;
            dict["Gosho"] = 100;

            foreach (var mark in dict)
            {
                Console.WriteLine(mark);
            }

            foreach (var kvp in dict)
            {
                Console.WriteLine(kvp.Key);
                Console.WriteLine(kvp.Value);
            }
            Console.WriteLine("=========================================================================");

            // remove and clear:
            // dict.Remove("Ivan");
            // dict.Clear();

            Dictionary<string, int> someDict = new Dictionary<string, int>();

            someDict["Ivan"] = 10;
            someDict["Gosho"] = 100;

            // ContainsKey()
            // ContainsValue()
            bool hasIvan = someDict.ContainsKey("Ivan");
            Console.WriteLine(hasIvan);

            if (!someDict.ContainsKey("Ivan"))
            {
                someDict.Add("Ivan", 100);
            }

            // TryGetValue()  - safe variant da byrkam v rechnika i da go proverqvam

            int theValue;
            bool hasValue = someDict.TryGetValue("Ivan2", out theValue);

            if (hasValue)
            {
                Console.WriteLine(theValue);
            }

            // LAMBDA --->

            var numbers = new List<int>();

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);

            var numberAsArray = numbers.Select(n => n * 2).ToList();

            Console.WriteLine(string.Join(", ", numbers));

            // orderBy/orderByDescending using lambda too:

            var names = new List<string>();

            names.Add("Pesho");
            names.Add("Gosho");
            names.Add("Ivan");
            names.Add("Myri");
            names.Add("Traqnka");

            var sortedByLengthNames = names
                .OrderBy(n => n.Length)
                .ThenBy(n => n)
                .ToList();

            Console.WriteLine(string.Join(",", sortedByLengthNames));

            // Dictionary order by value

            var dict2 = new Dictionary<string, int>();

            dict2["Ivan"] = 15;
            dict2["Gosho"] = 1;
            dict2["Pesho"] = 100;

            var sortedByValueDict = dict2
                .OrderBy(kvp => kvp.Value);

            foreach (var kvp in sortedByValueDict)
            {
                Console.WriteLine(kvp.Key);
            }

            // ToDictionary

            var dict3 = new Dictionary<string, int>();

            dict2["Ivan"] = 15;
            dict2["Gosho"] = 1;
            dict2["Pesho"] = 100;

            var sortedByValueDict3 = dict3
                .OrderBy(kvp => kvp.Value)
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            //because we don't make this as dictionary:
            var ivanValue = sortedByValueDict3["Ivan"];

            foreach (var kvp in sortedByValueDict3)
            {
                Console.WriteLine(kvp.Key);
            }

            // more examples:

            var listOfWords = new List<string>
            {
                "Ivan", "Myri", "Gosho", "Traqnka"
            };

            Dictionary<string, int> wordToLength = listOfWords
                .ToDictionary(word => word, word => word.Length);

            var lengthOfIvan = wordToLength["Ivan"];

            Console.WriteLine(lengthOfIvan);


            // Skip

            var numbers4 = new List<int>
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9
            };

            numbers4 = numbers4
                .Skip(5)   /// example: skip first 5 elements
                .ToList();

            Console.WriteLine(string.Join(", ", numbers4));

            // Take

            var numbers5 = new List<int>
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9
            };

            numbers5 = numbers5
                .Take(5)   /// example: take first 5 elements
                .ToList();

            Console.WriteLine(string.Join(", ", numbers5));

            // RANDOM

            var random = new Random();
            var first = random.Next(0, 101);     // 0 - 100
            var second = random.Next(0, 101);
            var third = random.Next(0, 101);

            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);

            // random string:

            var result = "";

            for (int i = 0; i < random.Next(6, 20); i++)
            {
                result += (char)random.Next(65, 91);
            }
            Console.WriteLine(result);

            // random element from given array

            var words = new[] { "Ivan", "Myri", "Gosho", "Traqnka" };

            var index = random.Next(0, words.Length);
            var randomWord = words[index];

            Console.WriteLine(randomWord);

            // Where and Count

            var list = new List<int>
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9
            };

            list = list
                .Where(x => x % 2 == 0)             // Where
                .ToList();


            foreach (var number in list)
            {
                Console.WriteLine(number);
            }

            var resultCount = list                  // Count
                .Count(x => x % 2 != 0);

            Console.WriteLine(string.Join(", ", resultCount));

            // .Distinct() return only unique elements

            // First, Last and Single.... FirstOrDefault(), LastOrDefault()

            var list2 = new List<int> { 1, 2, 3, 4, 5 };

            var first2 = list2.First();
            var last2 = list2.Last();
            var single2 = list2.Single(x => x > 3);  // will return only one element refer to given condition, otherwise will throw exeption.

            Console.WriteLine(first2);
            Console.WriteLine(last2);
            Console.WriteLine(single2);

            // .Reverse()
            // .Concat will unite two collections

            var list3 = new List<int> { 1, 2, 3, 4, 5, 6 };
            var list4 = new List<int> { 7, 8, 9, 10 };

            var result3 = list3.Concat(list4);

            Console.WriteLine(string.Join(", ", result));

        }
    }
}
