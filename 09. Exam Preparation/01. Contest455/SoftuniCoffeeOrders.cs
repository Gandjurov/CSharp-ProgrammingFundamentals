using System;
using System.Globalization;
using System.Numerics;

namespace SoftuniCoffeeOrders
{
    class SoftuniCoffeeOrders
    {
        static void Main(string[] args)
        {
            int numsOfOrders = int.Parse(Console.ReadLine());
            decimal totalPrice = 0.0m;

            for (int i = 0; i < numsOfOrders; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime date = DateTime.ParseExact(
                    Console.ReadLine(),
                    "d/M/yyyy",
                    CultureInfo.InvariantCulture);
                long capsules = long.Parse(Console.ReadLine());

                int daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);

                decimal price = daysInMonth * capsules * pricePerCapsule;
                totalPrice += price;

                Console.WriteLine($"The price for the coffee is: ${price:F2}");
            }
            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}
