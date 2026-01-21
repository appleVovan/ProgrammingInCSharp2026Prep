using System;
using System.Collections.Generic;
using System.Text;

namespace KMA.ProgrammingInCSharp2026.Samples
{
    internal class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public Student() : this("Default")
        {
        }

        public Student(string lastName) : this("Default", lastName)
        {
        }

        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = LastName;
        }
    }
}
