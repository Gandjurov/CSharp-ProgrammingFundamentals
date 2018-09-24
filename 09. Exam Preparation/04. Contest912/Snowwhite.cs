using System;
using System.Collections.Generic;
using System.Linq;

namespace Snowwhite
{
    class Snowwhite
    {
        static void Main(string[] args)
        {
            var colorsToDwarfs = new Dictionary<string, List<Dwarfs>>();
            var allDwarfs = new List<Dwarfs>();

            while (true)
            {
                var line = Console.ReadLine();

                if (line == "Once upon a time")
                {
                    break;
                }

                var dwarfInfo = line
                    .Split(new[] { ' ', '<', ':', '>' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = dwarfInfo[0];
                string color = dwarfInfo[1];
                int physics = int.Parse(dwarfInfo[2]);
                
                if (!colorsToDwarfs.ContainsKey(color))
                {
                    colorsToDwarfs[color] = new List<Dwarfs>();
                }

                var dwByCurrColor = colorsToDwarfs[color];
                var foundDwarf = dwByCurrColor
                    .FirstOrDefault(d => d.Name == name);

                if (foundDwarf != null)
                {
                    foundDwarf.Physics = Math.Max(physics, foundDwarf.Physics);
                }
                else
                {
                    var dwarf = new Dwarfs
                    {
                        Name = name,
                        Color = color,
                        Physics = physics
                    };

                    dwByCurrColor.Add(dwarf);
                    allDwarfs.Add(dwarf);
                }
            }

            var result = allDwarfs
                .OrderByDescending(d => d.Physics)
                .ThenByDescending(d => colorsToDwarfs[d.Color].Count())
                .ToList();

            foreach (var dwarf in result)
            {
                Console.WriteLine($"({dwarf.Color}) {dwarf.Name} <-> {dwarf.Physics}");
            }
        }
    }
    
}
