using System;
using System.Linq;

namespace _01._LargestCommonEnd
{
    class LargestCommonEnd
    {
        static void Main()
        {
            string[] words1 = Console.ReadLine().Split(' ').ToArray();
            string[] words2 = Console.ReadLine().Split(' ').ToArray();

            int leftCount = 0;
            int rightCount = 0;

            for (int i = 0; i < Math.Min(words1.Length, words2.Length); i++)
            {
                if(words1[i] == words2[i])
                {
                    leftCount++;
                }
                else
                {
                    break;
                }
            }

            for (int i = 0; i < Math.Min(words1.Length, words2.Length); i++)
            {
                if(words1[words1.Length-1-i] == words2[words2.Length-1-i])
                {
                    rightCount++;
                }
                else
                {
                    break;
                }
            }

            if (leftCount > rightCount)
            {
                Console.WriteLine(leftCount);
            }
            else
            {
                Console.WriteLine(rightCount);
            }
        
        }
    }
}

// below is faster solution

//string[] array1 = Console.ReadLine()
//                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
//string[] array2 = Console.ReadLine()
//    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
//int lengthL = 0;
//int lengthR = 0;
//        for (int i = 0; i<Math.Min(array1.Length, array2.Length); i++)
//        {
//            if (array1[i] == array2[i])
//                lengthL++;
//            if (array1[array1.Length - 1 - i] == array2[array2.Length - 1 - i])
//                lengthR++;
//        }
//        if (lengthL >= lengthR)
//            Console.WriteLine(lengthL);
//        else
//            Console.WriteLine(lengthR);
