namespace GradeBook
{
    internal interface Ibook
    {
        void AddGrade(double grade);
        Statistics GetLetterAndAverageGrade();
        string Name { get; }
        event GradeAddedDelegate GradeAdded;
    }
}