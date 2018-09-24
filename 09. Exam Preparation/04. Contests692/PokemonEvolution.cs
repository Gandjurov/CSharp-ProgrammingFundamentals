using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonEvolution
{
    class PokemonEvolution
    {
        static void Main()
        {
            Dictionary<string, List<Evolution>> pokeEvoDict = new Dictionary<string, List<Evolution>>();
            var input = Console.ReadLine()
                    .Split(new[] { '-', ' ', '>' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            string pokeName = "";

            while (input[0] != "wubbalubbadubdub")
            {
                if (input.Length > 1)
                {
                    Evolution evolution = new Evolution();
                    pokeName = input[0];
                    evolution.Type = input[1];
                    evolution.Index = int.Parse(input[2]);

                    if (!pokeEvoDict.ContainsKey(pokeName))
                    {
                        List<Evolution> listEvo = new List<Evolution>() { evolution };
                        pokeEvoDict.Add(pokeName, listEvo);
                    }
                    else
                    {
                        pokeEvoDict[pokeName].Add(evolution);
                    }
                }
                else
                {
                    pokeName = input[0];

                    if (pokeEvoDict.ContainsKey(pokeName))
                    {
                        Console.WriteLine($"# {pokeName}");
                        foreach (var ev in pokeEvoDict[pokeName])
                        {
                            Console.WriteLine($"{ev.Type} <-> {ev.Index}");
                        }
                    }
                }
                input = Console.ReadLine()
                    .Split(new[] { '-', ' ', '>' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }

            foreach (var kvp in pokeEvoDict)
            {
                Console.WriteLine($"# {kvp.Key}");
                foreach (var ev in kvp.Value.OrderByDescending(x => x.Index))
                {
                    Console.WriteLine($"{ev.Type} <-> {ev.Index}");
                }
            }

            //=============================================================================================================

            //var input = Console.ReadLine()
            //        .Split(new[] { '-', ' ', '>' }, StringSplitOptions.RemoveEmptyEntries)
            //        .ToArray();
            //string pokeName = "";
            //string evolution = "";

            //Dictionary<string, List<string>> pokemons = new Dictionary<string, List<string>>();

            //while (input[0] != "wubbalubbadubdub")
            //{
            //    if (input.Length > 1)
            //    {
            //        pokeName = input[0];
            //        evolution = input[1] + " <-> " + input[2];

            //        if (!pokemons.ContainsKey(pokeName))
            //        {
            //            List<string> currentList = new List<string>() { evolution };
            //            pokemons.Add(pokeName, currentList);
            //        }
            //        else
            //        {
            //            pokemons[pokeName].Add(evolution);
            //        }
            //    }
            //    else
            //    {
            //        pokeName = input[0];

            //        if (pokemons.ContainsKey(pokeName))
            //        {
            //            Console.WriteLine($"# {pokeName}");
            //            foreach (var ev in pokemons[pokeName])
            //            {
            //                Console.WriteLine($"{ev}");
            //            }
            //        }
            //    }
            //    input = Console.ReadLine()
            //        .Split(new[] { '-', ' ', '>' }, StringSplitOptions.RemoveEmptyEntries)
            //        .ToArray();
            //}

            //foreach (var kvp in pokemons)
            //{
            //    Console.WriteLine($"# {kvp.Key}");

            //    foreach (var ev in kvp.Value.
            //      OrderByDescending(x => int.Parse(x.Split(new[] { '<', '-', ' ', '>' }, StringSplitOptions.RemoveEmptyEntries)
            //      .Skip(1)
            //      .First())))
            //    {
            //        Console.WriteLine($"{ev}");
            //    }
            //}
        }
    }
}
