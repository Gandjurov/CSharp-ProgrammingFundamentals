using System;

namespace PokeMon
{
    class PokeMon
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var M = int.Parse(Console.ReadLine());
            var Y = int.Parse(Console.ReadLine());
            var counter = 0;
            var currentN = N;

            while (currentN >= M)
            {
                currentN -= M;
                counter++;
                
                if (currentN == N / 2 && N % 2 == 0 && Y != 0)
                {
                    currentN /= Y;
                    
                }
            }

            Console.WriteLine(currentN);
            Console.WriteLine(counter);
        }
    }
}
