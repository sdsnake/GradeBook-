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
            var AverageResult = book.GetAverageGrade();
            var HighResult = book.GetHighestGrade();
            var LowResult = book.GetLowestGrade();
            Console.WriteLine($"The average grade is {AverageResult.Average:N1}.\n The maximum is {HighResult.High}. \n The lowest is {LowResult.Low}.");

        }
    }
}
