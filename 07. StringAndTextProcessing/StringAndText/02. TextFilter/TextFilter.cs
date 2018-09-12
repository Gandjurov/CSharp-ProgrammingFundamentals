using System;

namespace TextFilter
{
    class TextFilter
    {
        static void Main()
        {
            var words = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var text = Console.ReadLine();

            foreach (var word in words)
            {
                var replacement = new string('*', word.Length);
                text = text.Replace(word, replacement);
            }
        }
    }
}
