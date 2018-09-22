using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Text;

namespace AnonymousThreat
{
    class AnonymousThreat
    {
        static void Main(string[] args)
        {
            var inputArr = Console.ReadLine().Split(' ').ToList();

            while (true)
            {
                var input = Console.ReadLine().Split(' ').ToArray();

                if (input[0] == "3:1")
                {
                    break;
                }

                string command = input[0];

                switch (command)
                {
                    case "merge":
                        int startIndex = int.Parse(input[1]);
                        int endIndex = int.Parse(input[2]);
                        startIndex = ValidateIndex(startIndex, inputArr.Count);
                        endIndex = ValidateIndex(endIndex, inputArr.Count);

                        string concatElements = "";

                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            concatElements += inputArr[i];
                        }
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            inputArr.RemoveAt(startIndex);
                        }
                        inputArr.Insert(startIndex, concatElements);

                        break;

                    case "divide":
                        int index = int.Parse(input[1]);
                        int partitionCount = int.Parse(input[2]);

                        List<string> partitions = SplitedEqually(inputArr[index], partitionCount);
                        inputArr.RemoveAt(index);
                        inputArr.InsertRange(index, partitions);

                        break;
                }

                
            }

            Console.WriteLine(string.Join(" ", inputArr));
        }

        private static List<string> SplitedEqually(string word, int partitionCount)
        {
            List<string> result = new List<string>();
            int part = word.Length / partitionCount;

            while (word.Length >= part)
            {
                result.Add(word.Substring(0, part));
                word = word.Substring(part);
            }
            if (word != "")
            {
                result.Add(word);
            }

            if (result.Count == partitionCount)
            {
                return result;
            }
            else
            {
                string concatLastTwoElem = result[result.Count - 2] + result[result.Count - 1];
                result.RemoveRange(result.Count - 2, 2);
                result.Add(concatLastTwoElem);
                return result;
            }
        }

        private static int ValidateIndex(int index, int length)
        {
            if (index < 0)
            {
                index = 0;
            }
            if (index > length - 1)
            {
                index = length - 1;
            }
            return index;
        }
    }
}
