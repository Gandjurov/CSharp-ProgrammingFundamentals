using System;
using System.Collections.Generic;

namespace _01._OddOccurrences
{
    class OddOccurrences
    {
        static void Main()
        {
            var words = Console.ReadLine().Split(' ');

            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                var wordToLower = word.ToLower();
                if (wordCount.ContainsKey(wordToLower))
                {
                    wordCount[wordToLower]++;
                }
                else
                {
                    wordCount[wordToLower] = 1;
                }
            }

            var result = new List<string>();

            foreach (var kvp in wordCount)
            {
                var word = kvp.Key;
                var count = kvp.Value;

                if (kvp.Value % 2 == 1)
                {
                    result.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ", result));

            
        }
    }
}
