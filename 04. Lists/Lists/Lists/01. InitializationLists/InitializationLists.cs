using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;

namespace _01._InitializationLists
{
    class InitializationLists
    {
        static void Main(string[] args)
        {
            //Arrays examples:

            int totalNumbers = 10;
            short[] numbers = new short[totalNumbers];
            string[] texts = new string[20];
            BigInteger[] bigNumbers = new BigInteger[100];

            //Lists:
            // trqbva da ima - using System.Collections.Generic;
            
            List<int> listOfNumbers = new List<int>();

            //adding element:
            listOfNumbers.Add(5);       // index 0 
            listOfNumbers.Add(10);      // index 1
            listOfNumbers.Add(100);     // index 2 
            listOfNumbers.Add(500);     // index 3 
            listOfNumbers.Add(1000);     // index 4

            //we can add an index value:
            int someNumber = listOfNumbers[2];
            listOfNumbers[2] = 5000;

            //adding element by loop

            for (int i = 0; i < 10000; i++)
            {
                listOfNumbers.Add(i);
            }

            var listOfNumbers2 = new List<int>();

            listOfNumbers2.Add(10);
            listOfNumbers2.Add(20);
            listOfNumbers2.Add(30);
            listOfNumbers2.Add(40);
            listOfNumbers2.Add(50);

            foreach (var number in listOfNumbers2)
            {
                Console.WriteLine(number);
            }

            //checking to how elements contains in listOfNumbers2, with Count.
            //overview: In arrays we have cheching with '.Length', in Lists we have checking with Count.
            
            Console.WriteLine(listOfNumbers2.Count);

            //Removing

            //listOfNumbers2.Remove(30);
            bool isDeleted = listOfNumbers2.Remove(30);
            Console.WriteLine(isDeleted);

            // with removeAt we have deleting by index

            listOfNumbers2.RemoveAt(2);

            //checking that given element will already exist in the list:

            bool someItemExist = listOfNumbers2.Contains(100);
            Console.WriteLine(someItemExist);

            //Reading from the console
            //5
            //3
            //1
            //4
            //6
            //9
            int n = int.Parse(Console.ReadLine());

            List<int> numbers2 = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int number2 = int.Parse(Console.ReadLine());
                numbers2.Add(number2);
            }

            foreach (var number2 in numbers2)
            {
                Console.WriteLine(number2);
            }

            // or

            var result = string.Join(", ", numbers);
            Console.WriteLine(result);

            //=====================================

            // 5 10 15 20 25 30 - these numbers are texts and we should insert them in list
            //lower version

            string text = Console.ReadLine();
            string[] numberAsText = text.Split(' ');

            List<int> numbers3 = new List<int>();

            for (int i = 0; i < numberAsText.Length; i++)
            {
                int number3 = int.Parse(numberAsText[i]);
                numbers3.Add(number3);
            }

            //faster version (using System.Linq;)
            List<int> numbers4 = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();


            // ================ Sort Lists =====================

            List<int> numbers5 = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            numbers5.Sort();   // from lower to higher by default
            numbers5.Reverse(); // will be sorted and reversed too

            Console.WriteLine(string.Join(' ', numbers5));




        }
    }
}
