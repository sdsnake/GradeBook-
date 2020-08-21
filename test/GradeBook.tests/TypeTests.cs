using System;
using Xunit;

namespace GradeBook.tests
{
    public class TypeTests

    {
        [Fact]
        public void SetNameTestCopyObject()
        {
            //arrange
            var book = GetBook("Book 1");
            SetNameGetBook(book, "New Name");

            Assert.Equal("New Name", book.Name);

        }

        private void SetNameGetBook(Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void SetNameTestPointingVariable()
        {
            //arrange
            var book = GetBook("Book 1");
            setName(book, "New Name");

            Assert.Equal("New Name", book.Name);

        }

        public string setName(Book book, string newName)
        {
            return book.Name = newName;
        }

        [Fact]
        public void GetBookReturnDifferentObjects()
        {
            //arrange
            var book = GetBook("Book 1");
            var book1 = GetBook("Book 2");

            Assert.Equal("Book 1", book.Name);
            Assert.Equal("Book 2", book1.Name);
            Assert.NotSame(book, book1);

        }
        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            //arrange
            var book = GetBook("Book 1");
            var book1 = book;

            Assert.Same(book, book1);
            Assert.True(Object.ReferenceEquals(book, book1));

        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
