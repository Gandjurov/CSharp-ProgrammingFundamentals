using System;
using System.Linq;
using System.Collections.Generic;

namespace _13._LegendaryFarming
{
    class LegendaryFarming
    {
        static void Main(string[] args)
        {
            
            bool shadowMourneObtained = false;
            bool valanyrObrained = false;
            bool dragonWrathObtrained = false;

            string resource;
            int quantity = 0;

            Dictionary<string, int> resourcesPrimary = new Dictionary<string, int>();
            Dictionary<string, int> junk = new Dictionary<string, int>();

            resourcesPrimary.Add("fragments", 0);
            resourcesPrimary.Add("shards", 0);
            resourcesPrimary.Add("motes", 0);


            string prize = "";
            while (shadowMourneObtained == false && valanyrObrained == false && dragonWrathObtrained == false)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();

                for (int i = 0; i < input.Length; i+=2)
                {
                    resource = input[i + 1].ToLower();
                    quantity = int.Parse(input[i]);

                    if (resourcesPrimary.ContainsKey(resource))
                    {
                        resourcesPrimary[resource] += quantity;
                    }
                    else if (!junk.ContainsKey(resource))
                    {
                        junk.Add(resource, quantity);
                    }
                    else
                    {
                        junk[resource] += quantity;
                    }

                    if (resourcesPrimary["fragments"] >= 250)
                    {
                        shadowMourneObtained = true;
                        prize = "Valanyr";
                        resourcesPrimary["fragments"] -= 250;
                        break;
                    }
                    else if (resourcesPrimary["shards"] >= 250)
                    {
                        valanyrObrained = true;
                        prize = "Shadowmourne";
                        resourcesPrimary["shards"] -= 250;
                        break;
                    }
                    else if (resourcesPrimary["motes"] >= 250)
                    {
                        dragonWrathObtrained = true;
                        prize = "Dragonwrath";
                        resourcesPrimary["motes"] -= 250;
                        break;
                    }
                }
            }
            
            Console.WriteLine($"{prize} obtained!");
            foreach (var metal in resourcesPrimary.OrderBy(x => x.Key).OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{metal.Key}: {metal.Value}");
            }

            foreach (var metal in junk.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{metal.Key}: {metal.Value}");
            }
            
        }
    }
}
