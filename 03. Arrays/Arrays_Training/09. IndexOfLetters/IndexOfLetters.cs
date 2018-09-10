using System;

namespace _09._IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main()
        {
            string text = Console.ReadLine();
            foreach (var letter in text)
                Console.WriteLine(string.Join(" -> ", letter, letter - 'a'));
        }
    }
}
