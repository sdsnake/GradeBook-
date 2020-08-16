using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();
            book.AddGrade(15.3);
            var grades = new List<double>() { 12.7, 12.7, 12.76, 12.7 };

            double result = 0.0;
            foreach (double number in grades)
            {
                result += number;
            }
            result /= grades.Count;
            Console.WriteLine($"The average grade is {result:N1}.");

        }
    }
}
