using System;
using System.Collections.Generic;
using System.Text;

namespace KMA.ProgrammingInCSharp2026.Samples
{
    internal partial class Dog
    {
        private int age;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public string Name { get; set; }

        public void MyMethod()
        {
            int val1 = Age;
            Age = 5;
        }
    }
}
