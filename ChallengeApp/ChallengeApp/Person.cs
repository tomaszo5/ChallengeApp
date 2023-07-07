﻿namespace ChallengeApp
{
    public abstract class Person
    {
        public Person(string name, string surname, string sex, int age)
        {
            this.Surname = surname;
            this.Name = name;
            this.Sex = sex; 
            this.Age = age;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Sex { get; private set; }
        public int Age { get; private set; }
    }
}
