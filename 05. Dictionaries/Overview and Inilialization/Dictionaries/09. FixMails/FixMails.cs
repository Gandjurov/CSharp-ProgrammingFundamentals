using System;
using System.Linq;
using System.Collections.Generic;

namespace _09._FixMails
{
    class FixMails
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            string commands = Console.ReadLine();
            string name = "";
            string mail = "";

            while (commands != "stop")
            {
                name = commands;
                mail = Console.ReadLine();
                if (!dict.ContainsKey(name))
                {
                    dict.Add(name, mail);
                }
                //else
                //{
                //    dict[name] += mail;
                //}
                commands = Console.ReadLine();
            }

            foreach (var kvp in dict.Where(x => !x.Value.EndsWith(".us") && !x.Value.EndsWith(".uk")))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
