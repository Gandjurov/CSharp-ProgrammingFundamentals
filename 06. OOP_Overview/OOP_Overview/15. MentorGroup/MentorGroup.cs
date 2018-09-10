using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;


namespace MentorGroup
{
    class MentorGroup
    {
        static void Main()
        {
            var students = new Dictionary<string, Student>();
            string input = Console.ReadLine();

            while (input != "end of dates")
            {
                string[] namesAndDates = input.Split(' ');
                string name = namesAndDates[0];
                List<string> dates = new List<string>();

                if (namesAndDates.Length > 1)
                {
                    dates = namesAndDates[1].Split(',').ToList();
                }

                Student student = new Student()
                {
                    Name = name,
                    Dates = new List<DateTime>(),
                    Comments = new List<string>()

                };

                foreach (var date in dates)
                {
                    student.Dates.Add(DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture));
                }

                if (!students.ContainsKey(name))
                {
                    students.Add(name, student);
                }
                else
                {
                    students[name].Dates.AddRange(student.Dates);        
                }
                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input != "end of comments")
            {
                string[] comments = input.Split('-');
                string user = comments[0];
                string comment = comments[1];

                if (students.ContainsKey(user))
                {
                    students[user].Comments.Add(comment);
                }

                input = Console.ReadLine();
            }

            foreach (var user in students.OrderBy(x => x.Key))
            {
                Console.WriteLine(user.Key);
                Console.WriteLine("Comments:");
                foreach (var comment in user.Value.Comments)
                {
                    Console.WriteLine($"- {comment}");
                }
                Console.WriteLine("Dates attended:");

                foreach (var date in user.Value.Dates.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {date.Day:d2}/{date.Month:d2}/{date.Year}");
                }
            }
        }
    }
}
