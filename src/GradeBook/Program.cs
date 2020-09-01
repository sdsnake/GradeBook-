using System;
namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new InMemoryBook("Said Grade Book");
            book.GradeAdded += ReturnMessageOnGradded;

            EnterGrades(book);

            var AverageAndLetterResult = book.GetLetterAndAverageGrade();
            var HighResult = book.GetHighestGrade();
            var LowResult = book.GetLowestGrade();
            Console.WriteLine(InMemoryBook.CATEGORY);
            Console.WriteLine($"For the book named {book.Name}");
            Console.WriteLine($"The average grade is {AverageAndLetterResult.Average:N1}.\n The maximum is {HighResult.High}. \n The lowest is {LowResult.Low}. \n The letter grade is {AverageAndLetterResult.Letter}.");

        }

        private static void EnterGrades(Ibook book)
        {
            while (true)
            {
                Console.WriteLine("Hi enter grade for calcultation or 'q' to quit:");
                var input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }
                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {

                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {

                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("***");
                }
            }
        }

        static void ReturnMessageOnGradded(object sender, EventArgs e)
        {
            Console.WriteLine("Grade added!");
        }
    }
}
