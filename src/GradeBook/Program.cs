﻿using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Said Grade Book");

            while (true)
            {
                Console.WriteLine("Hi enter grade for calcultation or 'q' to quit:");
                var input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }
                var grade = double.Parse(input);
                book.AddGrade(grade);

            }

            var AverageAndLetterResult = book.GetLetterAndAverageGrade();
            var HighResult = book.GetHighestGrade();
            var LowResult = book.GetLowestGrade();
            Console.WriteLine($"The average grade is {AverageAndLetterResult.Average:N1}.\n The maximum is {HighResult.High}. \n The lowest is {LowResult.Low}. The letter grade is {AverageAndLetterResult.Letter}.");

        }
    }
}
