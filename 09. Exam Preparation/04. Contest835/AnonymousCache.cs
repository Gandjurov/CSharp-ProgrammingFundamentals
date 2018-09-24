using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousCache
{
    class AnonymousCache
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, long>> data = new Dictionary<string, Dictionary<string, long>>();

            while (input != "thetinggoesskrra")
            {
                string[] inputSplit = input.Split(new[] { ' ', '-', '>', '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (inputSplit.Length > 1)
                {
                    string dataKey = inputSplit[0];
                    long dataSize = long.Parse(inputSplit[1]);
                    string dataSet = inputSplit[2];
                    var innerDictData = new Dictionary<string, long>();

                    if (!data.ContainsKey(dataSet))
                    {
                        data.Add(dataSet, innerDictData);
                    }
                    data[dataSet][dataKey] = dataSize;
                    
                }
                input = Console.ReadLine();
            }

            if (data.Count > 1)
            {
                var dataMaxSize = data.OrderByDescending(x => x.Value.Sum(d => d.Value)).First();

                Console.WriteLine($"Data Set: {dataMaxSize.Key}, Total Size: {dataMaxSize.Value.Sum(d => d.Value)}");

                foreach (var inner in dataMaxSize.Value)
                {
                    Console.WriteLine($"$.{inner.Key}");
                }
            }
            
        }
    }
}
