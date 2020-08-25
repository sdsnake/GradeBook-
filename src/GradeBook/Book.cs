
using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }
        public void AddGrade(double grade)
        {
            if (grade <= 100 && grade >= 0)
            {
                grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid Value");
            }

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

        public List<double> getGrades()
        {
            return grades;
        }
        private List<double> grades;
        public string Name;
    }
}
