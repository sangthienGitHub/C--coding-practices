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
            book.ShowStatistics();

        }
    }
}
