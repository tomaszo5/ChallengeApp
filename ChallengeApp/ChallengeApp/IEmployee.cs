using static ChallengeApp.EmployeeBase;
namespace ChallengeApp
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }
        string Sex { get; }
        int Age { get; }


        void AddGrade (float grade);    
        void AddGrade (double grade);
        void AddGrade(int grade);   
        void AddGrade(char grade);
        void AddGrade(string grade);
        void AddGrade(byte grade);
        void AddGrade(short grade);

        event GradeAddedDelegate GradeAdded;
        Statistics GetStatistics();
    }
}
