using System;
using Xunit;

namespace GradeBook.tests
{
    public delegate string WriteLogDelegate(string logMessage);
    public class BookTests
    {
        int count = 0;

        [Fact]
        public void WriteLogDelegateCanPointToMethod()
        {
            WriteLogDelegate log = ReturnMessage;
            log += ReturnMessage;
            log += IncrementCount;
            var result = log("Go delegate!");
            Assert.Equal("Go delegate!", result);
            Assert.Equal(3, count);
        }

        string IncrementCount(string message)
        {
            count++;
            return message;
        }
        string ReturnMessage(string message)
        {
            count++;
            return message;
        }

        [Fact]
        public void BookCalculationAndAverageTest()
        {
            //arrange
            var book = new Book("");
            book.AddGrade(12.7);
            book.AddGrade(14);
            book.AddGrade(14.5);
            // act
            var AverageResult = book.GetLetterAndAverageGrade();
            var HighResult = book.GetHighestGrade();
            var LowResult = book.GetLowestGrade();
            //assert 
            Assert.Equal(13.7, AverageResult.Average, 1);
            Assert.Equal(14.5, HighResult.High, 1);
            Assert.Equal(12.7, LowResult.Low, 1);
            Assert.Equal('C', AverageResult.Letter);
        }
    }
}
