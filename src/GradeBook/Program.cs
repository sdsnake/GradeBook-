using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Said Grade Book");
            book.AddGrade(15.3);
            book.AddGrade(15.3);
            book.AddGrade(15.3);
            var grades = new List<double>() { 12.7, 12.7, 12.76, 12.7 };
            grades.Add(17.7);
            double result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            foreach (double number in grades)
            {
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);
                result += number;
            }
            result /= grades.Count;
            Console.WriteLine($"The average grade is {result:N1}.\n The maximum is {highGrade}. \n The lowest is {lowGrade}.");

        }
    }
}
