
using System.Collections.Generic;

namespace GradeBook
{
    class Book
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

        public void LowestGrade()
        {
        }

        public void HighestGrade()
        {
        }

        public double AverageGrade()
        {
            return this.result /= grades.Count;
        }
        private List<double> grades;
        private double result;
        private string name;
    }
}
