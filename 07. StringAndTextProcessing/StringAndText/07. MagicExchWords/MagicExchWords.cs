using System;
using System.Collections.Generic;
using System.Linq;

namespace MagicExchWords
{
    class MagicExchWords
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            string w1 = input[0];
            string w2 = input[1];

            int l1 = w1.ToCharArray().Distinct().Count();
            int l2 = w2.ToCharArray().Distinct().Count();

            if (l1 == l2)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            //if (AreExchangeable(w1, w2))
            //{
            //    Console.WriteLine("true");
            //}
            //else
            //{
            //    Console.WriteLine("false");
            //}
        }

        //static bool AreExchangeable(string w1, string w2)
        //{
        //    bool areExchangeable = false;
        //    Dictionary<char, char> chars = new Dictionary<char, char>();
        //    for (int i = 0; i < Math.Min(w1.Length, w2.Length); i++)
        //    {
        //        if (!chars.ContainsKey(w1[i]))
        //        {
        //            chars.Add(w1[i], w2[i]);
        //        }
        //        else
        //        {
        //            if (w2[i] == chars[w1[i]])
        //            {

        //            }
        //            else
        //            {
        //                areExchangeable = false;
        //            }
        //        }
        //    }

        //    if (w1.Length != w2.Length)
        //    {
        //        if (w1.Length > w2.Length)
        //        {
        //            for (int i = w2.Length; i < w1.Length; i++)
        //            {
        //                if (!chars.ContainsKey(w1[i]))
        //                {
        //                    areExchangeable = false;
        //                }
        //            }
        //        }
        //        else
        //        {
        //            for (int i = w1.Length; i < w2.Length; i++)
        //            {
        //                if (!chars.ContainsValue(w2[i]))
        //                {
        //                    areExchangeable = false;
        //                }
        //            }
        //        }
        //    }
        //    return areExchangeable;
        //}
    }
}
