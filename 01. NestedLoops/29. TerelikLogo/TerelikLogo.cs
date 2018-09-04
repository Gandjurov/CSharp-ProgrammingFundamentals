using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TerelikLogo
{
    static void Main(string[] args)
    {
        int Y = int.Parse(Console.ReadLine());
        int X = Y;
        int Z = (X / 2) + 1;

        int width = ((Z + Z) - 2) + ((Y + Y) - 1);
        int hornsLength = X / 2;
        int middleDots = width - 2 * (Z);

        Console.Write(new string('.', hornsLength));
        Console.Write("*");
        Console.Write(new string('.', middleDots));
        Console.Write("*");
        Console.Write(new string('.', hornsLength));
        Console.WriteLine();

        middleDots -= 2;

        int firstHornDots = (X / 2) - 1;
        int dotsAfterHorn = 0;

        for (int i = 1; i < X - 1; i++)
        {
            if (i <= X / 2)
            {
                Console.Write(new string('.', firstHornDots));
                Console.Write("*");
                Console.Write(new string('.', dotsAfterHorn));
            }
            else
            {
                Console.Write(new string('.', hornsLength));
            }
            
            Console.Write(new string('.', i));
            Console.Write("*");
            Console.Write(new string('.', middleDots));
            Console.Write("*");
            middleDots -= 2;
            Console.Write(new string('.', i));

            if (i <= X / 2)
            {
                Console.Write(new string('.', dotsAfterHorn));
                Console.Write("*");
                Console.Write(new string('.', firstHornDots));

                firstHornDots--;
                dotsAfterHorn++;
            }
            else
            {
                Console.Write(new string('.', hornsLength));
            }
            Console.WriteLine();

            
        }
        Console.Write(new string('.', width / 2));
        Console.Write("*");
        Console.Write(new string('.', width / 2));
        Console.WriteLine();

        int leftRightDots = X - 2;
        middleDots = 1;
        for (int i = 0; i < X - 1; i++)
        {
            Console.Write(new string('.', hornsLength));
            Console.Write(new string('.', leftRightDots));
            Console.Write("*");
            Console.Write(new string('.', middleDots));
            Console.Write("*");
            Console.Write(new string('.', leftRightDots));
            Console.Write(new string('.', hornsLength));

            leftRightDots--;
            middleDots+=2;
            Console.WriteLine();
        }


        middleDots -= 4;
        for (int i = 1; i < X - 1; i++)
        {
            Console.Write(new string('.', hornsLength));
            Console.Write(new string('.', i));
            Console.Write("*");
            Console.Write(new string('.', middleDots));
            Console.Write("*");
            Console.Write(new string('.', i));
            Console.Write(new string('.', hornsLength));

            middleDots -= 2;
            Console.WriteLine();
        }

        Console.Write(new string('.', width / 2));
        Console.Write("*");
        Console.Write(new string('.', width / 2));
        Console.WriteLine();

    }
}

