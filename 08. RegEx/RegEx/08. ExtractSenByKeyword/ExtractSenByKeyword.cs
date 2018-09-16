using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ExtractSenByKeyword
{
    class ExtractSenByKeyword
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string inputText = Console.ReadLine();

            string[] sentences = inputText
                .Split(new char[] { '.', '!', '?', }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string pattern = $@"\b{word}\b";


            foreach (var sentence in sentences)
            {
                if (Regex.IsMatch(sentence, pattern))
                {
                    Console.WriteLine(sentence.Trim());
                }
            }

        }
    }
}
