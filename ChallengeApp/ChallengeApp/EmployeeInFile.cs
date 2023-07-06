using System.Diagnostics;

namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";

        public EmployeeInFile(string name, string surname)
            : base(name, surname)
        {
        }
        public override void AddGrade(float grade)
        {
            using var writer = File.AppendText(fileName);
            { 
                writer.WriteLine(grade);
            }
        }
        public override void AddGrade(double grade)
        {
            using var writer = File.AppendText(fileName);
            {
                writer.WriteLine(grade);
            }
        }

        public override void AddGrade(int grade)
        {
            using var writer = File.AppendText(fileName);
            {
                writer.WriteLine(grade);
            }
        }

        public override void AddGrade(char grade)
        {
            using var writer = File.AppendText(fileName);
            {
                writer.WriteLine(grade);
            }
        }

        public override Statistics GetStatistics()
        {
            var result = new Statistics();  
            using var reader = File.OpenText(fileName);
            {
                var line = reader.ReadLine();
                while (line != null) 
                {
                    var number = float.Parse(line);
                    result.
                }
            }
            return result;
        }
    }
}
