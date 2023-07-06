﻿namespace ChallengeApp
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }

        void AddGrade (float grade);    
        void AddGrade (double grade);
        void AddGrade(int grade);   
        void AddGrade(char grade);

        Statistics GetStatistics();
    }
}
