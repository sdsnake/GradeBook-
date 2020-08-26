using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Said Grade Book");

            for (var index = 0; index >= 0; index++)
            {
                Console.WriteLine("Hi enter grade for calcultation :");
                var input = Console.ReadLine();
                var grade = double.Parse(input);
                book.AddGrade(grade);
                Console.WriteLine("Are you finish? (y to stop n or other to continue)");
                var askingContinue = Console.ReadLine();
                if (askingContinue == "y")
                {
                    break;
                }
                else
                {
                    continue;
                }

            }

            var AverageResult = book.GetAverageGrade();
            var HighResult = book.GetHighestGrade();
            var LowResult = book.GetLowestGrade();
            Console.WriteLine($"The average grade is {AverageResult.Average:N1}.\n The maximum is {HighResult.High}. \n The lowest is {LowResult.Low}.");

        }
    }
}
