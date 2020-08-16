using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new[] { 12.7, 12.7, 12.7, 12.7 };
            double result = 0.0;
            foreach (double number in numbers)
            {
                result += number;
            }
            Console.WriteLine(result);

            if (args.Length > 0)
            {
                Console.WriteLine($"Hello, {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hello Human");
            }
        }
    }
}
