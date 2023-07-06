namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase

    {
        private List<float> grades = new List<float>();
        public EmployeeInMemory(string name, string surname)
            : base(name, surname)
        {
            
        }
        
        public override void AddGrade(float grade)
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

        public override void AddGrade(double grade)
        {
            float gradeAsFloat = (float)grade;
            this.grades.Add((float)grade);
        }
        public override void AddGrade(int grade)
        {
            this.grades.Add(grade);
        }

        public override void AddGrade(char grade)
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
            switch (grade)
            {

                case "1":
                    AddGrade(0);
                    break;
                case "1+":
                case "+1":
                    AddGrade(5);
                    break;
                case "-2":
                case "2-":
                    AddGrade(20);
                    break;
                case "2":
                    AddGrade(25);
                    break;
                case "+2":
                case "2+":
                    AddGrade(30);
                    break;
                case "-3":
                case "3-":
                    AddGrade(35);
                    break;
                case "+3":
                case "3+":
                    AddGrade(45);
                    break;
                case "3":
                    AddGrade(40);
                    break;
                case "-4":
                case "4-":
                    AddGrade(50);
                    break;
                case "+4":
                case "4+":
                    AddGrade(70);
                    break;
                case "4":
                    AddGrade(60);
                    break;
                case "-5":
                case "5-":
                    AddGrade(65);
                    break;
                case "5+":
                case "+5":
                    AddGrade(75);
                    break;
                case "5":
                    AddGrade(80);
                    break;
                case "-6":
                case "6-":
                    AddGrade(90);
                    break;
                case "6":
                    AddGrade(100);
                    break;
            }

        }

        public override Statistics GetStatistics()
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

            statistics.AverageLetter = statistics.Average
                switch
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
