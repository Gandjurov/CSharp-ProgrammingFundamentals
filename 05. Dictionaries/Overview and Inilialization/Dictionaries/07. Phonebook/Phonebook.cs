using System;
using System.Linq;
using System.Collections.Generic;


namespace _07._Phonebook
{
    class Phonebook
    {
        static void Main( )
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            string[] commands = Console.ReadLine().Split(' ').ToArray();

            while (commands[0] != "END")
            {
                if (commands[0] == "A")
                {
                    if (!phonebook.ContainsKey(commands[1]))
                    {
                        phonebook.Add(commands[1], commands[2]);
                    }
                    else
                    {
                        phonebook[commands[1]] = commands[2];
                    }
                    
                }
                else if (commands[0] == "S")
                {
                    if (!phonebook.ContainsKey(commands[1]))
                    {
                        Console.WriteLine($"Contact {commands[1]} does not exist.");
                    }
                    else
                    {
                        Console.WriteLine($"{commands[1]} -> {phonebook[commands[1]]}");
                    }
                }
                else if (commands[0] == "ListAll")
                {
                    foreach (var pair in phonebook.OrderBy(x => x.Key))
                    {
                        Console.WriteLine($"{pair.Key} -> {pair.Value}");
                    }
                }
                commands = Console.ReadLine().Split(' ').ToArray();
            }




            //Dictionary<string, string> phonebook = new Dictionary<string, string>();
            //string input = "";

            //while ((input = Console.ReadLine()) != "END")
            //{
            //    string[] data = input.Split(' ');
            //    string name = data[1];

            //    switch (data[0])
            //    {
            //        case "A":
            //            {
            //                string phoneNumber = data[2];
            //                if (!phonebook.ContainsKey(name))
            //                {
            //                    phonebook[name] = "";
            //                }
            //                phonebook[name] = phoneNumber;
            //                break;
            //            }
            //        case "S":
            //            {
            //                if (phonebook.ContainsKey(name))
            //                {
            //                    Console.WriteLine(string.Join(" -> ", name, phonebook[name]));
            //                }
            //                else
            //                {
            //                    Console.WriteLine($"Contact {name} does not exist.");
            //                }
            //                break;
            //            }
            //    }

            //}
        }
    }
}
