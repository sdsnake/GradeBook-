
using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public double LowestGrade()
        {
            this.lowGrade = double.MaxValue;
            foreach (double number in this.grades)
            {
                this.lowGrade = Math.Min(number, this.lowGrade);
            }
            return this.lowGrade;
        }

        public double HighestGrade()
        {
            this.highGrade = double.MinValue;
            foreach (double number in this.grades)
            {
                this.highGrade = Math.Max(number, this.highGrade);
            }
            return highGrade;
        }

        public double AverageGrade()
        {
            foreach (double number in this.grades)
            {
                this.result += number;
            }
            return this.result /= grades.Count;
        }

        public void showStatistics()
        {
            Console.WriteLine($"The average grade is {this.AverageGrade():N1}.\n The maximum is {this.HighestGrade()}. \n The lowest is {this.LowestGrade()}.");

        }
        private List<double> grades;
        private double result;
        private string name;
        private double highGrade;
        private double lowGrade;
    }
}
