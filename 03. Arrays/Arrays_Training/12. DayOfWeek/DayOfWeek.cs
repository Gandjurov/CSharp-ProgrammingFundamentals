using System;

namespace DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            string[] weekdays = "Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday"
               .Split(',');
            int day = int.Parse(Console.ReadLine());

            if (day >= 1 && day <= 7)
            {
                Console.WriteLine(weekdays[day - 1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
