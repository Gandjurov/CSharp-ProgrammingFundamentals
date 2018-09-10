using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace AndreyAndBilliard
{
    class AndreyAndBilliard
    {

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            
            string productName;
            double productPrice;
            Dictionary<string, double> products = new Dictionary<string, double>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('-').ToArray();

                productName = input[0];
                var numberFormatInfo = new NumberFormatInfo { NumberDecimalSeparator = "." };
                productPrice = double.Parse(input[1], numberFormatInfo);
                if (!products.ContainsKey(input[0]))
                {
                    products.Add(productName, productPrice);
                }
                else
                {
                    products[productName] = productPrice;
                }
            }

            List<Customer> allCustomers = new List<Customer>();


            while (true)
            {
                string inputCust = Console.ReadLine();

                if (inputCust == "end of clients")
                {
                    break;
                }

                string[] custList = inputCust
                    .Split(new char[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                string customerName = custList[0];
                string product = custList[1];
                double quantity = double.Parse(custList[2]);

                if (!products.ContainsKey(product))
                {
                    continue;
                }

                Customer client = new Customer();
                client.ShopList = new Dictionary<string, double>();
                client.Name = custList[0];
                client.ShopList.Add(product, quantity);

                if (allCustomers.Any(x => x.Name == customerName))
                {
                    Customer existCustomer = allCustomers.First(x => x.Name == customerName);
                    if (existCustomer.ShopList.ContainsKey(product))
                    {
                        existCustomer.ShopList[product] += (int)quantity;
                    }
                    else
                    {
                        existCustomer.ShopList[product] = (int)quantity;
                    }
                }
                else
                {
                    allCustomers.Add(client);
                }
            }

            foreach (var customer in allCustomers)
            {
                foreach (var item in customer.ShopList)
                {
                    foreach (var product in products)
                    {
                        if (item.Key == product.Key)
                        {
                            customer.Bill += item.Value * product.Value;
                        }
                    }
                }
            }

            var ordered = allCustomers
                .OrderBy(x => x.Name)
                .ThenBy(x => x.Bill)
                .ToList();

            foreach (var customer in ordered)
            {
                Console.WriteLine(customer.Name);
                foreach (KeyValuePair<string, double> item in customer.ShopList)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                }
                Console.WriteLine($"Bill: {customer.Bill:F2}");
            }

            Console.WriteLine("Total bill: {0:F2}", allCustomers.Sum(c => c.Bill));
            
        }
    }
}
