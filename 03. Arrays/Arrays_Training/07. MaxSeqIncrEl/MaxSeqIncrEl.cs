using System;
using System.Linq;

namespace _07._MaxSeqIncrEl
{
    class MaxSeqIncrEl
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counter = 1;
            int counterMax = 0;
            int position = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    counter++;
                    if (counter > counterMax)
                    {
                        counterMax = counter;
                        position = i + 1;
                    }
                }
                else
                {
                    counter = 1;
                }
            }

            int[] result = new int[counterMax];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = arr[position - counterMax + 1 + i];
            }

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
