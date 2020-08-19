using System;
using Xunit;
using GradeBook.Book;

namespace GradeBook.tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            //arrange
            var book = new Book("");
            book.AddGrade(12.7);
            book.AddGrade(14);
            book.AddGrade(14.5);
            // act
            var result = book.showStatistics();
            //assert 
            Assert.Equal(78, result.Average)

        }
    }
}
