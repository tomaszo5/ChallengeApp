﻿namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public EmployeeBase(string name, string surname)
        {
            this.Surname = surname;
            this.Name = name;
        
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }


        public abstract void AddGrade(float grade);

        public abstract void AddGrade(double grade);

        public abstract void AddGrade(int grade);

        public abstract void AddGrade(char grade);

        public abstract Statistics GetStatistics();
    }
}
