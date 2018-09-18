using System;

namespace CharityMarathon
{
    class CharityMarathon
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            long numberOfRunners = long.Parse(Console.ReadLine());
            long avgNumLaps = long.Parse(Console.ReadLine());
            long lenOfTrack = long.Parse(Console.ReadLine());
            int capacityOfTrack = int.Parse(Console.ReadLine());
            double amountOfMoney = double.Parse(Console.ReadLine());
            long totalRunners = 0;

            if (numberOfRunners <= capacityOfTrack * days)
            {
                totalRunners = numberOfRunners;
            }
            else
            {
                totalRunners = capacityOfTrack * days;
            }

            long totalMeters = totalRunners * avgNumLaps * lenOfTrack;
            long totalKM = totalMeters / 1000;

            double money = totalKM * amountOfMoney;

            Console.WriteLine($"Money raised: {money:F2}");
        }
    }
}
