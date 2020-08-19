using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Said Grade Book");
            book.AddGrade(12.3);
            book.AddGrade(15.3);
            book.AddGrade(17.3);
            book.showStatistics();
        }
    }
}
