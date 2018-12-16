using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class GreaterofTwoValues
{
    static void Main(string[] args)
    {
        var type = Console.ReadLine();
        if (type == "int")
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int max = GetMax(a, b);
            Console.WriteLine(max);
        }
        else if (type == "char")
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char max = GetMax(a, b);
            Console.WriteLine(max);
        }
        else
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string max = GetMax(a, b);
            Console.WriteLine(max);
        }
        //Console.WriteLine(GetMax("a", "b"));
    }

    public static int GetMax(int a, int b)
    {
        return Math.Max(a, b);
    }

    public static char GetMax(char a, char b)
    {
        return (char)GetMax((int)a, (int)b);
    }

    public static string GetMax(string a, string b)
    {
        if (a.CompareTo(b) < 0)
        {
            return b;
        }
        else
        {
            return a;
        }
    }
}

