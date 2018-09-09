using System;
using System.Collections.Generic;
using System.Linq;
namespace _14._LogsAggregator
{
    class LogsAggregator
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> report = new Dictionary<string, Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());
            int duration = 0;
            string name = "";
            string ip = "";


            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();

                string[] input = line.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                ip = input[0];
                name = input[1];
                duration = int.Parse(input[2]);

                if (!report.ContainsKey(name))
                {
                    report.Add(name, new Dictionary<string, int>());
                }
                if (!report[name].ContainsKey(ip))
                {
                    report[name].Add(ip, duration);
                }
                else
                {
                    report[name][ip] += duration;
                }
                
            }

            foreach (var user in report.OrderBy(u => u.Key))
            {
                string username = user.Key;
                int totalDuration = user.Value.Sum(i => i.Value);

                string[] ips = user.Value
                    .Keys
                    .OrderBy(i => i)
                    .ToArray();
                Console.WriteLine($"{username}: {totalDuration} [{string.Join(", ", ips)}]");
            }           

        }
    }
}
