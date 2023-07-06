using System.Diagnostics;
using System.Net.Http.Headers;
using System.Reflection.Metadata;

namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();
        public Employee()
        {
         
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            { 
                Console.WriteLine("invalid grade value");
            } 
        }
        public void AddGrade(double grade)
        {
            float gradeAsFloat = (float)grade;
            this.grades.Add((float)grade);
        }
        public void AddGrade(long grade)
        { 
            float gradeAsFloat = (float)grade;
            this.grades.Add(grade);
        }
        public void AddGrade(int grade)
        {
            float gradeAsFloat = grade;
            this.grades.Add(grade);
        }

        public void AddGrade (char grade)
        { 
            if (grade == 'A')
            {  
                this.grades.Add(100);
            }       
            else if (grade == 'B')
            { 
                this.grades.Add(80);
            }
            else if (grade == 'C')
            {
                this.grades.Add(60);
            }
            else if (grade == 'D')
            {
                this.grades.Add(40);
            }
            else if (grade == 'F')
            {
                this.grades.Add(20);
            }
            
            switch(grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;
                default:
                    Console.WriteLine("Wrong Grade");
                    this.grades.Add(0);
                    break;
            }   
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
               this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("string is not float");
                    
            }
        }
        // parsowanie w stringach chcemy zrobic liczbe lub odwrotnie.
        // metody zmiany string int float etc/ int.TryParse/
        //sprawdzenie metody Try.

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {

                if (grade >= 0)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average += grade;
                }

            }


            statistics.Average /= this.grades.Count;

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
             
            }
            

        
        
        

        
            return statistics;
        }
       
    }
}
// rodzaje petli C# : foreach, for, do ,do while, while.
//do while, a while? bardzo podobna do while wykona sie przynajmniej raz,a while rozni sie tym, że moze sie nie wykonać. 
// sposoby na przerwanie petli? 
// break
// continue
// goto 
// goto here;
// here:
