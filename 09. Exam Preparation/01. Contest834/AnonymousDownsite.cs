using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace AnonymousDownsite
{
    class AnonymousDownsite
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int secKey = int.Parse(Console.ReadLine());
            decimal sum = 0.0m;
            
            for (int i = 0; i < n; i++)
            {
                string[] dataWebSites = Console.ReadLine().Split(' ').ToArray();

                var siteName = dataWebSites[0];

                decimal siteVisits = decimal.Parse(dataWebSites[1]);
                decimal siteCommPricePerVisit = decimal.Parse(dataWebSites[2]);
                decimal siteLoss = siteVisits * siteCommPricePerVisit;
                sum += siteLoss;
                Console.WriteLine(siteName);
            }

            BigInteger secToken = BigInteger.Pow(secKey, n);
            
            Console.WriteLine($"Total Loss: {sum:F20}");
            Console.WriteLine($"Security Token: {secToken}");
        }
    }
}
