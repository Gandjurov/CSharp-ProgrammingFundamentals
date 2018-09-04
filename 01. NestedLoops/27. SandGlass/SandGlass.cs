using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SandGlass
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < ((N-1)/2) + 1; i++)
        {
                Console.WriteLine("{0}{1}{0}", new string('.', i), new string('*', N-(2*i)));
        }

        for (int i = ((N-1) / 2) - 1; i >= 0; i--)
        {
            Console.WriteLine("{0}{1}{0}", new string('.', i), new string('*', N - (2 * i)));
        }

        
    }
}

