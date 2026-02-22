using System;
using System.Collections.Generic;
using System.Text;

namespace KMA.ProgrammingInCSharp2026.Samples.Original
{
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    internal class Student
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public Student(string firstName = "Default", string lastName = "Default")
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || obj is not Student)
                return false;
            Student castedObj = (Student)obj;
            if (castedObj == null)
                return false;
            return FirstName == castedObj.FirstName && LastName == castedObj.LastName;
        }
    }
}
