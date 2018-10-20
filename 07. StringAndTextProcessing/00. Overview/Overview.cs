using System;
using System.Diagnostics;
using System.Text;

namespace Overview
{
    class Overview
    {
        static void Main()
        {
            //example:
            var text = new string('a', 50);
            Console.WriteLine(text);
            Console.WriteLine("--------------------------------------------------------------");

            string str1 = "test";
            string str2 = "Test";
            //Case-insensitive string comparison
            int result = string.Compare(str1, str2, true);  //if we want this example is case sensitive, true will be false
            //result == 0 if str1 equals str2
            //result < 0 if str1 is before str2
            //result > 0 if str1 is after str2
            Console.WriteLine("--------------------------------------------------------------");

            //Concat
            var result2 = string.Concat("First", " Second", " Third");
            Console.WriteLine(result2);
            Console.WriteLine("--------------------------------------------------------------");

            var result3 = "First" + 1 + 2;
            Console.WriteLine(result3);
            Console.WriteLine("--------------------------------------------------------------");

            //Searching in strings:
            //str.IndexOf(string) ---- returns the first index or -1;
            string email = "vasko@gmail.org";

            var indexOfKliomba = email.IndexOf('@');  // index 5
            var indexOfVasko = email.IndexOf("vasko"); // index 0
            var stepSearching = email.IndexOf('a', 2); // will search from 2 index ahead

            Console.WriteLine(indexOfKliomba);
            Console.WriteLine(indexOfVasko);

            var lastIndex = email.LastIndexOf("r");
            Console.WriteLine(lastIndex);
            Console.WriteLine("--------------------------------------------------------------");

            //Extracting substrings
            //str.Substring(int startIndex, int Length)

            string filename = @"C:\Pics\Rila2017.jpg";
            string name = filename.Substring(8, 8);
            //name "Rila2017"

            //str.Substrin(int startIndex)
            string nameAndExtension = filename.Substring(8); //will extract from index 8 to the finish.
            // nameAndExtension == "Rila2017.jpg"
            Console.WriteLine("--------------------------------------------------------------");

            //Replace
            string cocktail = "Vodka + Martini + Cherry";
            string replaced = cocktail.Replace("+", "and");
            // the result will be -> Vodka and Martini and Cherry

            //Remove
            //str.Remove(int index, int length) - deletes part of a string

            string price = "$ 1234567";
            string lowPrice = price.Remove(2, 3);
            // result will be -> $4567
            Console.WriteLine("--------------------------------------------------------------");

            //.Trim() and Trim with parameters
            var text1 = "           sxghsfhsdf    dhdgfhjdgjfgj    zdfhdh      ";
            Console.WriteLine(text1.Trim());
            Console.WriteLine(text1.TrimStart());
            Console.WriteLine(text1.TrimEnd());
            Console.WriteLine(text1.Trim('a', ' ')); //will trim first and last 'a' and ' '.
            Console.WriteLine("--------------------------------------------------------------");

            // StringBuilder()

            var resultString = "a";

            var stopWatch = Stopwatch.StartNew();

            var stopwatch = new Stopwatch();

            for (int i = 0; i < 100000; i++)
            {
                resultString += 'a';
            }

            stopWatch.Stop();

            Console.WriteLine(stopWatch.Elapsed);

            Console.WriteLine(resultString);


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
