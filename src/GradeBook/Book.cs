
using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public delegate void GradeBookDelegate(Object sender, EventArgs args);
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }

        public void AddLetterGrade(char letter)
        {
            switch (letter)
            {
                case 'A':
                    AddGrade(20);
                    break;
                case 'B':
                    AddGrade(16);
                    break;
                case 'C':
                    AddGrade(13);
                    break;
                case 'E':
                    AddGrade(9);
                    break;
                case 'F':
                    AddGrade(5);
                    break;
                default:
                    AddGrade(0);
                    break;
            }

        }
        public void AddGrade(double grade)
        {
            if (grade <= 20 && grade >= 0)
            {
                grades.Add(grade);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new ArgumentException($"Invalid value for {nameof(grade)}.");
            }

        }

        public event GradeBookDelegate GradeAdded;
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

        public Statistics GetLetterAndAverageGrade()
        {
            var result = new Statistics();
            result.Average = 0.0;
            foreach (double grade in this.grades)
            {
                result.Average += grade;
            }
            result.Average /= grades.Count;

            switch (result.Average)
            {
                case var d when d >= 18:
                    result.Letter = 'A';
                    break;
                case var d when d >= 14:
                    result.Letter = 'B';
                    break;
                case var d when d >= 10:
                    result.Letter = 'C';
                    break;
                case var d when d >= 8:
                    result.Letter = 'D';
                    break;
                case var d when d >= 8:
                    result.Letter = 'D';
                    break;
                default:
                    result.Letter = 'F';
                    break;
            }
            return result;
        }

        public List<double> getGrades()
        {
            return grades;
        }
        private List<double> grades;

        public string Name
        {
            get;
            set;
        }

        public const string CATEGORY = "Science";
    }
}
