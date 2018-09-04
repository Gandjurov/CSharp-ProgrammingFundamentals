using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Numbers_N._._._1
{
    class NumbersNto1
    {
        static void Main(string[] args)
        {
            int numberRead = int.Parse(Console.ReadLine());

            for (int i = numberRead; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
