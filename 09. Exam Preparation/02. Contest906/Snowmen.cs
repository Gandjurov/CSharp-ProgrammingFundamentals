using System;
using System.Linq;

namespace Snowmen
{
    class Snowmen
    {
        static void Main()
        {
            var snowmen = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (snowmen.Count > 1)
            {
                for (int i = 0; i < snowmen.Count; i++)
                {
                    if (snowmen.Count(x => x != -1) == 1)
                    {
                        break;
                    }
                    
                    if (snowmen[i] == -1) //snowmen[i] is value of i
                    {
                        continue;
                    }

                    int attacker = i; // when we call only 'i' that means index of 'i'
                    int target = snowmen[i] % snowmen.Count;
                    int diff = Math.Abs(attacker - target);
                    
                    if (attacker == target)
                    {
                        //suicide
                        snowmen[attacker] = -1;
                        Console.WriteLine($"{attacker} performed harakiri");
                    }
                    //attaker wins
                    else if (diff % 2 == 0)
                    {
                        snowmen[target] = -1;
                        Console.WriteLine($"{attacker} x {target} -> {attacker} wins");
                    }
                    else
                    {
                        //target wins
                        snowmen[attacker] = -1;
                        Console.WriteLine($"{attacker} x {target} -> {target} wins");
                    }
                }

                snowmen = snowmen
                    .Where(x => x != -1)
                    .ToList();
            }
        }
    }
}
