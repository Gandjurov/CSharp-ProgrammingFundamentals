using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._AMinerTask
{
    class AMinerTask
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> mine = new Dictionary<string, int>();
            string commands = Console.ReadLine();
            string metal = "";
            int quantity = 0;

            while (commands != "stop")
            {
                metal = commands;
                quantity = int.Parse(Console.ReadLine());
                if (!mine.ContainsKey(metal))
                {
                    mine.Add(metal, quantity);
                }
                else
                {
                    mine[metal] += quantity;
                }
                commands = Console.ReadLine();
            }

            foreach (var kvp in mine)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
