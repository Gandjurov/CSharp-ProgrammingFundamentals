using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.EnterEvenNumber
{
    class EnterEvenNumber
    {
        static void Main(string[] args)
        {
            int numberRead;

            while (true)
            {
                numberRead = int.Parse(Console.ReadLine());
                if (numberRead % 2 == 0)
                {
                    break;
                }

            }

            Console.WriteLine(numberRead);
        }
    }
}
