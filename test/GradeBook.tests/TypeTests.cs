using System;
using Xunit;

namespace GradeBook.tests
{
    public class TypeTests

    {
        [Fact]
        public void ValueTypeAlsoPassByValue()
        {
            var x = GetInt();
            setInt(ref x);

            Assert.Equal(42, x);
        }

        private void setInt(ref int x)
        {
            x = 42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void SetNameTestByRefObject()
        {
            //arrange
            var book = GetBook("Book 1");
            SetNameGetBookByRef(out book, "New Name");

            Assert.Equal("New Name", book.Name);

        }

        private void SetNameGetBookByRef(out Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void SetNameTestCopyObject()
        {
            //arrange
            var book = GetBook("Book 1");
            SetNameGetBook(book, "New Name");

            Assert.Equal("Book 1", book.Name);

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

        [Fact]
        public void StringsBehaveLikeValueTypes()
        {
            string name = "Scott";
            var upper = MakeUpperCase(name);
            Assert.Equal("Scott", name);
            Assert.Equal("SCOTT", upper);
        }

        private string MakeUpperCase(string name)
        {
            return name.ToUpper();
        }
    }
}
