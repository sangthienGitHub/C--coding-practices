using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Sang' Grade Book");
            book.AddGrade(90.1);
            book.AddGrade(87.5);
            book.AddGrade(75.2);
            book.AddGrade(15.2);

            var stats = book.GetStatistics();

            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");

        }
    }
}
