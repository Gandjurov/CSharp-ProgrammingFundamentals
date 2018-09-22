using System;
using System.Linq;

namespace CommandInterpreter
{
    class CommandInterpreter
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                string[] commandParts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                switch (commandParts[0])
                {
                    case "reverse":
                        int start = int.Parse(commandParts[2]);
                        int count = int.Parse(commandParts[4]);
                        array = Reverse(array, start, count);
                        break;
                    case "sort":
                        start = int.Parse(commandParts[2]);
                        count = int.Parse(commandParts[4]);
                        array = Sort(array, start, count);
                        break;
                    case "rollLeft":
                        count = int.Parse(commandParts[1]);
                        array = RollLeft(array, count);
                        break;
                    case "rollRight":
                        count = int.Parse(commandParts[1]);
                        array = RollRight(array, count);
                        break;
                }
            }

            Console.WriteLine($"[{string.Join(", ", array)}]");
        }
        // ----------- Reverse ---------------
        static string[] Reverse(string[] array, int start, int count)
        {
            if (start < 0 || start >= array.Length)
            {
                Console.WriteLine("Invalid input parameters.");
                return array;
            }

            //check if count == 0
            if (start + count < 0 || count < 0 || start + count - 1 >= array.Length)
            {
                Console.WriteLine("Invalid input parameters.");
                return array;
            }

            string[] firstPart = array.Take(start).ToArray();
            string[] reversedPart = array.Skip(start).Take(count).Reverse().ToArray();
            string[] lastPart = array.Skip(start + count).ToArray();

            return firstPart.Concat(reversedPart).Concat(lastPart).ToArray();
        }

        // ----------- Sort ------------
        static string[] Sort(string[] array, int start, int count)
        {
            if (start < 0 || start >= array.Length)
            {
                Console.WriteLine("Invalid input parameters.");
                return array;
            }

            //check if count == 0
            if (start + count < 0 || count < 0 || start + count - 1 >= array.Length)
            {
                Console.WriteLine("Invalid input parameters.");
                return array;
            }

            string[] firstPart = array.Take(start).ToArray();
            string[] sortedPart = array.Skip(start).Take(count).OrderBy(s => s).ToArray();
            string[] lastPart = array.Skip(start + count).ToArray();

            return firstPart.Concat(sortedPart).Concat(lastPart).ToArray();
        }

        static string[] RollLeft(string[] array, int count)
        {
            
            //check if count == 0
            if (count < 0)
            {
                Console.WriteLine("Invalid input parameters.");
                return array;
            }

            count %= array.Length;
            string[] firstPart = array.Take(count).ToArray();
            string[] secondPart = array.Skip(count).ToArray();

            return secondPart.Concat(firstPart).ToArray();
        }

        static string[] RollRight(string[] array, int count)
        {

            //check if count == 0
            if (count < 0)
            {
                Console.WriteLine("Invalid input parameters.");
                return array;
            }

            count %= array.Length;
            string[] firstPart = array.Skip(array.Length - count).ToArray();
            string[] secondPart = array.Take(array.Length - count).ToArray();

            return firstPart.Concat(secondPart).ToArray();
        }
    }
}
