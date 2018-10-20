using System;
using System.Diagnostics;
using System.Text;

namespace TimeElapsed
{
    class TimeElapsed
    {
        static void Main(string[] args)
        {
            var result = "a";

            var stopWatch = Stopwatch.StartNew();

            var stopwatch = new Stopwatch();

            for (int i = 0; i < 100000; i++)
            {
                result += 'a';
            }

            stopWatch.Stop();

            Console.WriteLine(stopWatch.Elapsed);

            Console.WriteLine(result);


            stopWatch = Stopwatch.StartNew();
            var resultWithSb = new StringBuilder();

            for (int i = 0; i < 100000; i++)
            {
                resultWithSb.Append("a");

            }

            stopWatch.Stop();

            var endResult = resultWithSb.ToString();
            Console.WriteLine(stopwatch.Elapsed);
        }
    }
    
}
