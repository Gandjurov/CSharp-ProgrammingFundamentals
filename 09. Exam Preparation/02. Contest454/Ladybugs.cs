using System;
using System.Linq;

namespace Ladybugs
{
    class Ladybugs
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());

            var field = new int[size];

            var ladybugsIndexes = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(i => i >= 0 && i < size)
                .ToList();

            foreach (var item in ladybugsIndexes)
            {
                field[item] = 1;
            }

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                var commandParts = input.Split(' ');  // 1 left 5
                var currentLadybugIndex = int.Parse(commandParts[0]);
                var direction = commandParts[1];
                var flyLength = int.Parse(commandParts[2]);

                if (direction == "left")
                {
                    flyLength *= -1;
                }

                //outside of the field
                if (currentLadybugIndex < 0 || currentLadybugIndex >= size)
                {
                    continue;
                }

                //no ladybug here
                if (field[currentLadybugIndex] == 0)
                {
                    continue;
                }

                field[currentLadybugIndex] = 0; //fly away
                var nextIndexToLand = currentLadybugIndex;

                while (true)
                {
                    nextIndexToLand += flyLength;

                    if (nextIndexToLand < 0 || nextIndexToLand >= size)
                    {
                        break;
                    }

                    if (field[nextIndexToLand] == 1) //there is ladybug in this cell
                    {
                        continue;
                    }

                    field[nextIndexToLand] = 1;
                    break;// just landed
                }
                 
            }

            Console.WriteLine(string.Join(" ", field));

        }
    }
}
