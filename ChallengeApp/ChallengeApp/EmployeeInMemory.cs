﻿namespace ChallengeApp;

public class EmployeeInMemory : EmployeeBase
{
    private readonly List<float> grades = new List<float>();

    public override event GradeAddedDelegate GradeAdded;

    public EmployeeInMemory(string name, string surname,string sex,int age)
        : base(name, surname,sex,age)
    {
    }

    public override void AddGrade(float grade)
    {
        if (grade >= 0 && grade <= 100)
        {
            this.grades.Add(grade);

            if(GradeAdded != null)
            {
                GradeAdded(this, new EventArgs());
            }
        }
        else
        {
            throw new Exception("invalid grade value");
        }
    }

    public override void AddGrade(string grade)
    {
        if (float.TryParse(grade, out float result))
        {
            this.AddGrade(result);
        }
        else
        {
            throw new Exception("String is not float");
        }
    }

    public override void AddGrade(byte grade)
    {
        this.AddGrade((float)grade);
    }

    public override void AddGrade(long grade)
    {
        this.AddGrade((float)grade);
    }
    public override void AddGrade(short grade)
    {
        this.AddGrade((float)grade);
    }
    public override void AddGrade(double grade)
    {
        float gradeAsFloat = (float)grade;
        this.AddGrade(gradeAsFloat);
    }

    public override void AddGrade(int grade)
    {
        float gradeAsFloat = grade;
        this.AddGrade(gradeAsFloat);
    }

    public override void AddGrade(char grade)
    {
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

    public override Statistics GetStatistics()
    {
        var statistics = new Statistics();
        foreach(var grade in this.grades)
        {
            statistics.AddGrade(grade);
        }    
        return statistics;
    }

}