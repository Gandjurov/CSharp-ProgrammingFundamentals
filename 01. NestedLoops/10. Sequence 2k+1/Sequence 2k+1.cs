using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Sequence_2k_1
{
    class Sequence2k1
    {
        static void Main(string[] args)
        {
            int numberRead = int.Parse(Console.ReadLine());

            int num = 1;

            while (num <= numberRead)
            {
                Console.WriteLine(num);

                num = num * 2 + 1;
            }
        }
    }
}
