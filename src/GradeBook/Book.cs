
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

        public Statistics GetLowestGrade()
        {
            var result = new Statistics();
            result.Low = double.MaxValue;
            foreach (double grade in this.grades)
            {
                result.Low = Math.Min(grade, result.Low);
            }
            return result;
        }

        public Statistics GetHighestGrade()
        {
            var result = new Statistics();
            result.High = double.MinValue;
            foreach (double grade in this.grades)
            {
                result.High = Math.Max(grade, result.High);
            }
            return result;
        }

        public Statistics GetAverageGrade()
        {
            var result = new Statistics();
            result.Average = 0.0;
            foreach (double grade in this.grades)
            {
                result.Average += grade;
            }
            result.Average /= grades.Count;
            return result;
        }

        private List<double> grades;
        private string name;
    }
}
