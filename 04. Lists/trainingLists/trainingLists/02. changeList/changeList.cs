using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._changeList
{
    class changeList
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            string[] commands = Console.ReadLine().Split(' ').ToArray();

            while (commands[0] != "Odd" && commands[0] != "Even")
            {

                if (commands[0] == "Delete")
                {
                    numbers.RemoveAll(x => x == int.Parse(commands[1]));
                }
                else if (commands[0] == "Insert")
                {
                    int element = int.Parse(commands[1]);
                    int position = int.Parse(commands[2]);
                    numbers.Insert(position, element);
                }
                commands = Console.ReadLine().Split(' ').ToArray();
            }

            if (commands[0] == "Odd")
            {
                //numbers.RemoveAll(x => x % 2 == 0);
                Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 1)));
            }
            else if (commands[0] == "Even")
            {
                //numbers.RemoveAll(x => x % 2 == 1);
                Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 0)));
            }

            //Console.WriteLine(string.Join(" ", numbers));

























            //string[] commands = Console.ReadLine().Split(' ').ToArray();

            //while (commands[0] != "Odd" && commands[0] != "Even")
            //{
            //    if (commands[0] == "Delete")
            //    {
            //        numbers.RemoveAll(num => num == int.Parse(commands[1]));
            //    }
            //    else if (commands[0] == "Insert")
            //    {
            //        int element = int.Parse(commands[1]);
            //        int position = int.Parse(commands[2]);
            //        numbers.Insert(position, element);
            //    }
            //    commands = Console.ReadLine().Split(' ').ToArray();
            //}
            //if (commands[0] == "Odd")
            //{
            //    numbers.RemoveAll(x => x%2==0);
            //}
            //else if (commands[0] == "Even")
            //{
            //    numbers.RemoveAll(x => x % 2 == 1);
            //}

            //Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
