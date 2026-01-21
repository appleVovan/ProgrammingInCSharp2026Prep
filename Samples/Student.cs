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

        public Student()
        {
        }

        public Student(string lastName) : this()
        {
            LastName = lastName;
        }

        public Student(string firstName, string lastName) : this(lastName)
        {
            FirstName = firstName;
        }
    }
}
