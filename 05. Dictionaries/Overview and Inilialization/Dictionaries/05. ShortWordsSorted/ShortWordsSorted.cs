using System;
using System.Linq;

namespace _05._ShortWordsSorted
{
    class ShortWordsSorted
    {
        static void Main(string[] args)
        {
            var result = Console.ReadLine()
                .Split(
                new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '/', '\\', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Where(w => w.Length < 5)
                .Select(w => w.ToLower())
                .OrderBy(w => w)
                .Distinct()
                .ToList();

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
