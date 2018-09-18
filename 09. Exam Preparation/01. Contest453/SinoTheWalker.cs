using System;
using System.Globalization;

namespace SinoTheWalker
{
    class SinoTheWalker
    {
        static void Main(string[] args)
        {
            var timeFormat = "HH:mm:ss";
            
            var startingTime = DateTime.ParseExact(
                Console.ReadLine(),
                timeFormat,
                CultureInfo.InvariantCulture);

            var numberOfSteps = int.Parse(Console.ReadLine());
            var secondsOfStep = int.Parse(Console.ReadLine());

            long initialSeconds = startingTime.Hour * 60 * 60 + startingTime.Minute * 60 + startingTime.Second;
            ulong secondsToAdd = (ulong)numberOfSteps * (ulong)secondsOfStep;
            ulong totalSeconds = (ulong)initialSeconds + (ulong)secondsToAdd;

            var seconds = totalSeconds % 60;
            var totalMinutes = totalSeconds / 60;
            var minutes = totalMinutes % 60;
            var totalHours = totalMinutes / 60;
            var hours = totalHours % 24;

            Console.WriteLine($"Time Arrival: {hours:00}:{minutes:00}:{seconds:00}");
        }
    }
}
