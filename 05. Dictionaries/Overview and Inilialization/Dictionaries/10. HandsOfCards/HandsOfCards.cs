using System;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, HashSet<string>> personHands = new Dictionary<string, HashSet<string>>();
            var input = Console.ReadLine();


            while (input != "JOKER")
            {
                var arr = input.Split(':');
                var player = arr[0].Trim();
                var cards = arr[1].Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (!personHands.ContainsKey(player))
                {
                    personHands.Add(player, new HashSet<string>());
                }

                foreach (var card in cards)
                {
                    personHands[player].Add(card);
                }
                input = Console.ReadLine();

            }

            foreach (var nameAndList in personHands)
            {
                string nameOfPerson = nameAndList.Key;

                double resultOfThePersonTotal = 0;
                double resultOfThePersonOne = 0;
                double resultOfThePersonTwo = 0;
                foreach (var hands in nameAndList.Value)
                {
                    string newHands = hands.Remove(hands.Length - 1, 1);



                    switch (newHands)
                    {
                        case "2": resultOfThePersonOne = 2; break;
                        case "3": resultOfThePersonOne = 3; break;
                        case "4": resultOfThePersonOne = 4; break;
                        case "5": resultOfThePersonOne = 5; break;
                        case "6": resultOfThePersonOne = 6; break;
                        case "7": resultOfThePersonOne = 7; break;
                        case "8": resultOfThePersonOne = 8; break;
                        case "9": resultOfThePersonOne = 9; break;
                        case "10": resultOfThePersonOne = 10; break;
                        case "J": resultOfThePersonOne = 11; break;
                        case "Q": resultOfThePersonOne = 12; break;
                        case "K": resultOfThePersonOne = 13; break;
                        case "A": resultOfThePersonOne = 14; break;
                    }

                    char lastLetter = hands[hands.Length - 1];

                    switch (lastLetter)
                    {
                        case 'C': resultOfThePersonTwo = 1; break;
                        case 'D': resultOfThePersonTwo = 2; break;
                        case 'H': resultOfThePersonTwo = 3; break;
                        case 'S': resultOfThePersonTwo = 4; break;
                    }

                    resultOfThePersonTotal += resultOfThePersonOne * resultOfThePersonTwo;
                }
                Console.WriteLine($"{nameOfPerson}: {resultOfThePersonTotal}");
            }
        }
    }
}