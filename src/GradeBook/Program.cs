using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new[] { 12.7, 12.7, 12.7, 12.7 };

            double result = numbers[0];
            result += numbers[1];
            result += numbers[2];
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
