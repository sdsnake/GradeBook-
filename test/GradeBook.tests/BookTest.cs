using System;
using Xunit;

namespace GradeBook.tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculationAndAverageTest()
        {
            //arrange
            var book = new Book("");
            book.AddGrade(12.7);
            book.AddGrade(14);
            book.AddGrade(14.5);
            // act
            var AverageResult = book.GetAverageGrade();
            var HighResult = book.GetHighestGrade();
            var LowResult = book.GetLowestGrade();
            //assert 
            Assert.Equal(13.7, AverageResult.Average, 1);
            Assert.Equal(14.5, HighResult.High, 1);
            Assert.Equal(12.7, LowResult.Low, 1);
        }
    }
}
