﻿namespace ChallengeApp;

public abstract class EmployeeBase : IEmployee
{
    public delegate void GradeAddedDelegate(object sender, EventArgs args);

    public abstract event GradeAddedDelegate GradeAdded;

    public EmployeeBase(string name, string surname, string sex, int age)
    {
        this.Name = name;
        this.Surname = surname;
        this.Sex = sex;
        this.Age = age;
    }
    public string Name { get; private set; }
    public string Surname { get; private set; }

    public string Sex { get; private set; }

    public int Age { get; private set; }

    public abstract void AddGrade(float grade);
    public abstract void AddGrade(long grade);
    public abstract void AddGrade(double grade);
    public abstract void AddGrade(int grade);
    public abstract void AddGrade(char grade);
    public abstract void AddGrade(string grade);
    public abstract void AddGrade(byte grade);
    public abstract void AddGrade(short grade);


    public abstract Statistics GetStatistics();

}
