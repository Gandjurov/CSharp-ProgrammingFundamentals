using System;

namespace UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main()
        {
            string input = Console.ReadLine();

            foreach (var symbol in input)
            {
                Console.Write("\\u{0:x4}", (int)symbol);
            }
            Console.WriteLine();
        }
    }
}
