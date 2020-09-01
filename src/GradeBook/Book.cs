

namespace GradeBook
{
    public abstract class Book : NamedObject, Ibook
    {
        public Book(string name) : base(name)
        {
        }

        public virtual event GradeAddedDelegate GradeAdded;

        public abstract void AddGrade(double grade);

        public virtual Statistics GetLetterAndAverageGrade()
        {
            throw new System.NotImplementedException();
        }

    }

}