namespace ChallengeApp
{
    public class Employee : Person
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname, string sex)
            : base(name, surname, sex)
        {

        }
        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("invalid grade value");
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
            this.grades.Add(grade);
        }

        public void AddGrade(char grade)
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

            switch (grade)
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
                    throw new Exception("Wrong Letter");


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
                throw new Exception("string is not float");

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

            statistics.AverageLetter = statistics.Average switch
            {
                var average when average >= 80 => 'A',
                var average when average >= 60 => 'B',
                var average when average >= 40 => 'C',
                var average when average >= 20 => 'D',
                _ => 'E',
            };
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
