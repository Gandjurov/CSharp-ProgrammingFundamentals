using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._RandomArray
{
    class RandomArray
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .Split(' ')
                .ToArray();

            var random = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                var currentWord = words[i];

                var randomIndex = random.Next(0, words.Length);
                var randomWord = words[randomIndex];

                words[i] = randomWord;
                words[randomIndex] = currentWord;
            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
